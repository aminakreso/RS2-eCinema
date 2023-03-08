import 'dart:convert';
import 'dart:io';

import 'package:ecinema_mobile/models/projection.dart';
import 'package:ecinema_mobile/providers/projectionProvider.dart';
import 'package:ecinema_mobile/requests/paymentUpsertRequest.dart';
import 'package:ecinema_mobile/screens/seatSelectionScreen.dart';
import 'package:ecinema_mobile/wigdets/textInputWidget.dart';
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:collection/collection.dart';

import '../models/movie.dart';
import '../models/payment.dart';
import '../providers/movieProvider.dart';
import '../providers/paymentProvider.dart';
import '../requests/reservationUpsertRequest.dart';
import '../utils/util.dart';
import '../wigdets/master_screen.dart';
import '../wigdets/movieCardLine.dart';
import 'loadingScreen.dart';
import 'package:http/http.dart' as http;

class ReservationDetailsScreen extends StatefulWidget {
  static const String routeName = "/reservation_details";
  late ReservationUpsertRequest reservationInsertRequest;
  late Projection projection;

  ReservationDetailsScreen(
      {required this.reservationInsertRequest,
      required this.projection,
      super.key});

  @override
  _ReservationDetailsScreenState createState() =>
      _ReservationDetailsScreenState(reservationInsertRequest);
}

class _ReservationDetailsScreenState extends State<ReservationDetailsScreen> {
  _ReservationDetailsScreenState(reservationInsertRequest);
  Map<String, dynamic>? paymentIntentData;
  ReservationUpsertRequest reservationInsertRequest =
      ReservationUpsertRequest();
  Projection projection = Projection();
// izvuc projekciju
  PaymentProvider? _paymentProvider = null;

  @override
  void initState() {
    super.initState();
    reservationInsertRequest = widget.reservationInsertRequest;
    projection = widget.projection;
    _paymentProvider = context.read<PaymentProvider>();
  }

  @override
  Widget build(BuildContext context) {
    if (widget.reservationInsertRequest == null)
      return LoadingScreen();
    else {
      return MasterScreenWidget(
        child: Center(
          child: Container(
            margin: EdgeInsets.only(top: 30),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                MovieCardLine(
                  label: "Movie: ",
                  text: '${widget.projection?.movie?.name}',
                  font: 18,
                  padding: 8,
                ),
                MovieCardLine(
                    label: "Date: ",
                    text: getDate(widget.projection!.startTime!),
                    font: 18,
                    padding: 8),
                MovieCardLine(
                  label: "Time ",
                  text: getTime(widget.projection!.startTime!),
                  font: 18,
                  padding: 8,
                ),
                MovieCardLine(
                  label: "Hall: ",
                  text: '${widget.projection?.hall?.name}',
                  font: 18,
                  padding: 8,
                ),
                MovieCardLine(
                  label: "Number of reserved seats: ",
                  text: '${widget.reservationInsertRequest.seatsId?.length}',
                  font: 18,
                  padding: 8,
                ),
                SizedBox(height: 10),
                Expanded(
                  child: GridView.count(
                      crossAxisCount: 1,
                      childAspectRatio: 3 / 1,
                      mainAxisSpacing: 20,
                      children: List.generate(
                          widget.reservationInsertRequest.seatsId!.length,
                          (index) {
                        return Container(
                          decoration: BoxDecoration(
                              color: Colors.grey,
                              borderRadius: BorderRadius.circular(10.0)),
                          child: Center(
                            child: Text(
                              "${widget.projection?.projectionType}  - Sjedalo ${widget.reservationInsertRequest.seatsId![index]}", // da pise ime
                              style: TextStyle(color: Colors.black),
                            ),
                          ),
                        );
                      })

                      //_changeButtonColor(index);

                      ),
                ),
                Center(
                  child: ElevatedButton(
                    onPressed: () async {
                      double toPay = calculateToPay();
                      paymentIntentData = await createPaymentIntent(
                          (calculateToPay() * 100).round().toString(), 'bam');
                      await Stripe.instance
                          .initPaymentSheet(
                              paymentSheetParameters:
                                  SetupPaymentSheetParameters(
                                      paymentIntentClientSecret:
                                          paymentIntentData!['client_secret'],
                                      style: ThemeMode.dark,
                                      merchantDisplayName: 'eCinema'))
                          .then((value) {})
                          .onError((error, stackTrace) {
                        print(
                            'Exception/DISPLAYPAYMENTSHEET==> $error $stackTrace');
                        showDialog(
                            context: context,
                            builder: (_) => const AlertDialog(
                                  content: Text("Ponistena transakcija"),
                                ));
                        throw Exception("Payment declined");
                      });
                      print("payment sheet created");

                      await Stripe.instance.presentPaymentSheet();

                      await InsertPayment();
                    },
                    child: Text('Submit'),
                  ),
                )
              ],
            ),
          ),
        ),
      );
    }
  }

  double calculateToPay() {
    return projection!.price!.value! * reservationInsertRequest.seatsId!.length;
  }

  Future<void> InsertPayment() async {
    //await insertReservation(iznos, paymentIntentData!['id']);
    PaymentUpsertRequest paymentUpsertRequest = new PaymentUpsertRequest();

    //promijenit da kupi od logovanog usera
    reservationInsertRequest.userId = "46f58fbf-05cb-442d-9068-976e85a9f71c";

    paymentUpsertRequest.stripePaymentId = paymentIntentData!['id'];
    paymentUpsertRequest.reservation = reservationInsertRequest;
    paymentUpsertRequest.amount = calculateToPay();
    await _paymentProvider?.insert(paymentUpsertRequest);
    setState(() {
      paymentIntentData = null;
    });
  }
}

createPaymentIntent(String amount, String currency) async {
  try {
    Map<String, dynamic> body = {
      'amount': amount,
      'currency': currency,
      'payment_method_types[]': 'card'
    };

    var response = await http.post(
        Uri.parse('https://api.stripe.com/v1/payment_intents'),
        body: body,
        headers: {
          'Authorization':
              'Bearer sk_test_51MeoKkJ60Z5ZRZNFXDlMDAW8hUmorXllZZrovtIewlbbIX9W79JHSj4OSjMEuyGvlTujSektfOkzmhFHaf8DA0S500Mfaldrf9',
          'Content-Type': 'application/x-www-form-urlencoded'
        });
    return jsonDecode(response.body);
  } catch (err) {
    print('err charging user: ${err.toString()}');
  }
}
