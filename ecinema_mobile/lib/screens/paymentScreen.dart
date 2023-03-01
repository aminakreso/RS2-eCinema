import 'dart:convert';

//import 'package:ecinema_mobile/providers/stripeAppServiceProvider.dart';
import 'package:ecinema_mobile/requests/addStripeCard.dart';
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:provider/provider.dart';

import '../models/payment.dart';
import '../requests/addStripeCustomer.dart';
import 'package:http/http.dart' as http;

class PaymentScreen extends StatefulWidget {
  static const String routeName = "/payment";

  late Payment payment;
  PaymentScreen(this.payment, {super.key});

  @override
  _PaymentScreenState createState() => _PaymentScreenState(payment);
}

class _PaymentScreenState extends State<PaymentScreen> {
  final _formKey = GlobalKey<FormState>();
  _PaymentScreenState(payment);

  late AddStripeCustomer addStripeCustomer;
  late AddStripeCard addStripeCard;

  @override
  void initState() {
    super.initState();
    payment = widget.payment;
    //Stripe.publishableKey = "your_publishable_key_here";
  }

  TextEditingController? _cardNameController = TextEditingController();
  TextEditingController? _cardNumberController = TextEditingController();
  TextEditingController? _expYearController = TextEditingController();
  TextEditingController? __expMonthController = TextEditingController();
  TextEditingController? __cvcController = TextEditingController();

  Map<String, dynamic>? paymentIntentData;

  //StripeCustomerProvider _stripeCustomerProvider = StripeCustomerProvider();
  // StripeAppServiceProvider _stripeAppServiceProvider =
  //     StripeAppServiceProvider();
  //StripeCustomerProvider _stripeCustomerProvider = StripeCustomerProvider();

//AddPaymentProvider addPaymentProvider = AddPaymentProvider();
  Payment payment = Payment();

  late AddStripeCard creditCard;
  late AddStripeCustomer customer;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Payment"),
      ),
      body: Form(
        key: _formKey,
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text('Card details'),
            // CardField(
            //   onCardChanged: (card) {
            //     print('Card changed: ${card?.toJson()}');
            //   },
            // ),
            SizedBox(height: 20),
            ElevatedButton(
              onPressed: () async {
                //if (_formKey.currentState!.validate()) {
                // Create the payment method with card information
                // _formKey.currentState?.save();
                //final paymentMethod =
                //     await Stripe.instance.createPaymentMethod(
                //   params: PaymentMethodParams.card(
                //     paymentMethodData: PaymentMethodData(
                //       billingDetails: BillingDetails(
                //         name: 'John Doe',
                //         email: 'johndoe@example.com',
                //       ),
                //     ),
                //   ),
                // );

                paymentIntentData = await createPaymentIntent(
                    (7.5 * 100).round().toString(), 'bam');
                await Stripe.instance
                    .initPaymentSheet(
                        paymentSheetParameters: SetupPaymentSheetParameters(
                            paymentIntentClientSecret:
                                paymentIntentData!['client_secret'],
                            style: ThemeMode.dark,
                            merchantDisplayName: 'eCinema'))
                    .then((value) {})
                    .onError((error, stackTrace) {
                  print('Exception/DISPLAYPAYMENTSHEET==> $error $stackTrace');
                  showDialog(
                      context: context,
                      builder: (_) => const AlertDialog(
                            content: Text("Ponistena transakcija"),
                          ));
                  throw Exception("Payment declined");
                });
                //print('Payment method created: ${paymentMethod.id}');
                print("payment sheet created");

                await Stripe.instance.presentPaymentSheet();

                //await InsertReservation();

                //   ScaffoldMessenger.of(context)
                //       .showSnackBar(const SnackBar(content: Text("Uplata uspjesna")));
                // } on StripeException catch (e) {
                //   showDialog(
                //       context: context,
                //       builder: (_) => const AlertDialog(
                //             content: Text("Ponistena transakcija"),
                //           ));
                // } catch (e) {
                //   print('$e');
                // }
              }
              //   }
              ,
              child: Text('Submit'),
            ),
          ],
        ),
      ),
    );
  }

// Future<void> makePayment(double iznos) async {
//     try {
//       paymentIntentData =
//           await createPaymentIntent((iznos * 100).round().toString(), 'bam');
//       await Stripe.instance
//           .initPaymentSheet(
//               paymentSheetParameters: SetupPaymentSheetParameters(
//                   paymentIntentClientSecret:
//                       paymentIntentData!['client_secret'],
//                   applePay: true,
//                   googlePay: true,
//                   testEnv: true,
//                   style: ThemeMode.dark,
//                   merchantCountryCode: 'BIH',
//                   merchantDisplayName: 'eCinema'))
//           .then((value) {});

//           //await insertUplata(iznos, paymentIntentData!['id']);

//       displayPaymentSheet();
//     } catch (e, s) {
//       print('exception:$e$s');
//     }
//   }

//  displayPaymentSheet() async {
//     try {
//       await Stripe.instance
//           .presentPaymentSheet(
//             SetupPaymentSheetParameters(
//                 paymentIntentClientSecret :paymentIntentData!['client_secret'],
//               ),
//         //confirmPayment: true,
//       )
//           .onError((error, stackTrace) {
//         print('Exception/DISPLAYPAYMENTSHEET==> $error $stackTrace');
//          showDialog(
//           context: context,
//           builder: (_) => const AlertDialog(
//                 content: Text("Ponistena transakcija"),
//               ));
//         throw Exception("Payment declined");
//       });

//       //await InsertStavkeNarudzbe();

//       ScaffoldMessenger.of(context)
//           .showSnackBar(const SnackBar(content: Text("Uplata uspjesna")));
//     } on StripeException catch (e) {
//       showDialog(
//           context: context,
//           builder: (_) => const AlertDialog(
//                 content: Text("Ponistena transakcija"),
//               ));
//     } catch (e) {
//       print('$e');
//     }
//   }
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
}

// Future<void> InsertPayment() async {
//   await insertReservation(iznos, paymentIntentData!['id']);

//     List<Map> narudzbaProizvodi = [];
//     _cartProvider.cart.items.forEach((element) {
//       narudzbaProizvodi.add({
//         "proizvodID" : element.product.proizvodID,
//         "kolicina" : element.count,
//       });
//     });
//     Map narudzba = {
//       "korisnikID" : Authorization.korisnik!.korisnikID,
//       "uplataID" : uplata!.uplataID,
//       "listaProizvoda": narudzbaProizvodi
//     };

//     await _narudzbaProvider!.insert(narudzba);
//     setState(() {
//       paymentIntentData = null;
//       _cartProvider.cart.items.clear();
//     });
//   }

//   insertReservation(double amount, String brojTransakcije) async {
//       Map request = {
//       "iznos": amount,
//       "brojTransakcije": brojTransakcije,
//     };

//    uplata = await _uplataProvider!.insert(request);
//   }
