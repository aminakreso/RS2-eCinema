import 'dart:convert';
import 'package:ecinema_mobile/models/projection.dart';
import 'package:ecinema_mobile/models/seatxrefReservation.dart';
import 'package:ecinema_mobile/providers/movieProvider.dart';
import 'package:ecinema_mobile/providers/projectionProvider.dart';
import 'package:ecinema_mobile/providers/reservationProvider.dart';
import 'package:ecinema_mobile/providers/seatReservationProvider.dart';
import 'package:ecinema_mobile/requests/paymentUpsertRequest.dart';
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:provider/provider.dart';
import '../models/movie.dart';
import '../models/seat.dart';
import '../providers/paymentProvider.dart';
import '../requests/reservationUpsertRequest.dart';
import '../utils/util.dart';
import '../wigdets/master_screen.dart';
import '../wigdets/movieCardLine.dart';
import 'loadingScreen.dart';
import 'package:http/http.dart' as http;

import 'movieDetailsScreen.dart';
import 'seatSelectionScreen.dart';

class ReservationDetailsScreen extends StatefulWidget {
  static const String routeName = "/reservation_details";
  late ReservationUpsertRequest? reservationInsertRequest;
  late String? id;
  //late Projection projection;

  ReservationDetailsScreen({this.reservationInsertRequest, this.id, super.key});

  @override
  _ReservationDetailsScreenState createState() =>
      _ReservationDetailsScreenState(reservationInsertRequest, id);
}

class _ReservationDetailsScreenState extends State<ReservationDetailsScreen> {
  _ReservationDetailsScreenState(reservationInsertRequest, id);
  Map<String, dynamic>? paymentIntentData;
  ReservationUpsertRequest? reservationInsertRequest =
      ReservationUpsertRequest();
  String? id = null;
  Projection? projection = null;

  PaymentProvider? _paymentProvider = null;
  ReservationProvider? _reservationProvider = null;
  ProjectionProvider? _projectionProvider = null;
  SeatReservationProvider? _seatReservationProvider = null;

  @override
  void initState() {
    super.initState();

    loadData();
    bool flag = true;
    //projection = widget.projection;
    _paymentProvider = context.read<PaymentProvider>();
    _reservationProvider = context.read<ReservationProvider>();
    _seatReservationProvider = context.read<SeatReservationProvider>();
    _projectionProvider = context.read<ProjectionProvider>();
  }

  Future loadData() async {
    if (widget.reservationInsertRequest != null) {
      reservationInsertRequest = widget.reservationInsertRequest!;
      loadProjection();
    } else if (widget.id != null) {
      id = widget.id;
      loadReservation();
    }
  }

  Future loadReservation() async {
    var temp = await _reservationProvider?.getById(id!);
    setState(() {
      reservationInsertRequest?.userId = temp?.userId;
      // var seats = temp?.seats?.map((seat) => seat.seat).toList();
      // reservationInsertRequest?.seats = seats;
      reservationInsertRequest?.projectionId = temp?.projectionId;
      loadSeats();
      loadProjection();
    });
  }

  Future loadSeats() async {
    if (id == null) return;
    List<SeatxrefReservation>? temp = await _seatReservationProvider
        ?.get({'ReservationId': id, 'IncludeSeats': true});
    if (temp != null) {
      setState(() {
        reservationInsertRequest?.seats =
            temp.map((seats) => seats.seat!).toList();
      });
    }
  }

  Future loadProjection() async {
    if (reservationInsertRequest?.projectionId == null) return;
    var temp = await _projectionProvider
        ?.getById(reservationInsertRequest!.projectionId!);
    setState(() {
      projection = temp;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (reservationInsertRequest == null ||
        projection == null ||
        reservationInsertRequest?.seats == null) {
      loadData();
      return LoadingScreen();
    } else {
      return MasterScreenWidget(
        child: Center(
          child: Container(
            margin: EdgeInsets.only(top: 30),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                MovieCardLine(
                  label: "Movie: ",
                  text: '${projection?.movie?.name}',
                  font: 18,
                  padding: 8,
                ),
                MovieCardLine(
                    label: "Date: ",
                    text: getDate(projection?.startTime!),
                    font: 18,
                    padding: 8),
                MovieCardLine(
                  label: "Time ",
                  text: getTime(projection?.startTime!),
                  font: 18,
                  padding: 8,
                ),
                MovieCardLine(
                  label: "Hall: ",
                  text: '${projection?.hall?.name}',
                  font: 18,
                  padding: 8,
                ),
                MovieCardLine(
                  label: "Number of reserved seats: ",
                  text: '${reservationInsertRequest?.seats?.length}',
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
                          reservationInsertRequest?.seats?.length ?? 0,
                          (index) {
                        return Container(
                          decoration: BoxDecoration(
                              color: Colors.grey,
                              borderRadius: BorderRadius.circular(10.0)),
                          child: Center(
                            child: Text(
                              "${projection?.projectionType}  - Sjedalo ${reservationInsertRequest!.seats![index].name}", // da pise ime
                              style: TextStyle(color: Colors.black),
                            ),
                          ),
                        );
                      })),
                ),
                if (id == null)
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

                        //Navigator.popAndPushNamed(context);
                        Navigator.popAndPushNamed(context,
                            "${MovieDetailsScreen.routeName}/${projection?.movie?.id}");
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
    return projection!.price!.value! * reservationInsertRequest!.seats!.length;
  }

  Future<void> InsertPayment() async {
    PaymentUpsertRequest paymentUpsertRequest = new PaymentUpsertRequest();

    reservationInsertRequest?.userId = Authorization.id;

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
