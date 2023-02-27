import 'package:ecinema_mobile/providers/stripeAppServiceProvider.dart';
import 'package:ecinema_mobile/requests/addStripeCard.dart';
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:provider/provider.dart';

import '../requests/addStripeCustomer.dart';

class PaymentScreen extends StatefulWidget {
  static const String routeName = "/payment";

late Payment payment;
  PaymentForm(this.payment, {super.key});

  @override
  _PaymentScreenState createState() => _PaymentScreenState();
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

  //StripeCustomerProvider _stripeCustomerProvider = StripeCustomerProvider();
  StripeAppServiceProvider _stripeAppServiceProvider = StripeAppServiceProvider();
  //StripeCustomerProvider _stripeCustomerProvider = StripeCustomerProvider();

//AddPaymentProvider addPaymentProvider = AddPaymentProvider();
  Payment payment = Payment();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Payment"),
      ),
      body: Form(
        key: _formKey,
        child: Column(
          children: [
            Text( "Credit Card Information"),
            //SizedBox(height: 16),
             TextFormField(
              controller: _cardNameController,
              decoration:  InputDecoration(
                labelText: 'Name on card',
              ),
              validator: (value) {
                if (value!.isEmpty) {
                  return 'Please enter the name on your card';
                }
                return null;
              },
              // onSaved: (value) {
              //   _cardName = value!;
              // },
            ),
             TextFormField(
              controller: _cardNumberController,
              decoration: const InputDecoration(
                labelText: 'Card number',
              ),
              keyboardType: TextInputType.number,
              validator: (value) {
                if (value!.isEmpty) {
                  return 'Please enter your card number';
                } else if (value.length < 16) {
                  return 'Please enter a valid card number';
                }
                return null;
              },
              // onSaved: (value) {
              //   _cardNumber = value!;
              // },
            ),
            Row(
              children: [
                Expanded(
                  child: TextFormField(
                    controller: _expYearController,
                    decoration: const InputDecoration(
                      labelText: 'Expiration year',
                    ),
                    keyboardType: TextInputType.number,
                    validator: (value) {
                      if (value!.isEmpty) {
                        return 'Please enter the expiration year';
                      } else if (value!.length < 4) {
                        return 'Please enter a valid expiration year';
                      }
                      return null;
                    },
                    // onSaved: (value) {
                    //   _expYear = int.parse(value!);
                    // },
                  ),
                ),
                const SizedBox(width: 16.0),
                Expanded(
                  child: TextFormField(
                    controller: __expMonthController,
                    decoration: const InputDecoration(
                      labelText: 'Expiration month',
                    ),
                    keyboardType: TextInputType.number,
                    validator: (value) {
                      if (value!.isEmpty) {
                        return 'Please enter the expiration month';
                      } else if (value!.length < 2) {
                        return 'Please enter a valid expiration month';
                      }
                      return null;
                    },
                    // onSaved: (value) {
                    //   _expMonth = int.parse(value!);
                    // },
                  ),
                ),
                const SizedBox(width: 16.0),
                Expanded(
                  child: TextFormField(
                    controller: __cvcController,
                    decoration: const InputDecoration(
                      labelText: 'CVC',
                    ),
                    keyboardType: TextInputType.number,
                    validator: (value) {
                      if (value!.isEmpty) {
                        return 'Please enter the CVC';
                      } else if (value!.length < 4) {
                        return 'Please enter the CVC';
                      }
                      return null;
                    },
                    // onSaved: (value) {
                    //   _cvc = int.parse(value!);
                    // },
                  ),
                ),
            TextButton(
              onPressed: () async {
                try {
                    // SharedPreferences prefs =
                    //     await SharedPreferences.getInstance();
                    // String? email = prefs.getString('korisnikEmail');
                    // String? name = prefs.getString('korisnikImePrezime');
                    var creditCard = {
                      //'name': 'Visa',
                      'cardNumber': _cardNumberController?.text,
                      'expirationYear': _expYearController?.text,
                      'expirationMonth': __expMonthController?.text,
                      'cvc': __cvcController?.text
                    };
                    var customerDetails = {
                      'name': "Amina",
                      'email': "amina@gmail.com",
                      'creditCard': creditCard
                    };
                    var stripeCustomer =
                        await _stripeAppServiceProvider.addCustomer(customerDetails); // sta koristi
                    if (stripeCustomer?.customerId != null) {
                      try {
                        var stripePayment = {
                          "customerId": stripeCustomer?.customerId,
                          "receiptEmail": stripeCustomer?.email,
                          "description": payment.naslov,
                          "currency": "usd",
                          "amount": (payment.iznos! * 100).toInt(),
                        };
                        var temp =
                            await _stripeAppServiceProvider.addPayment(stripePayment);
                        if (temp?.paymentId != null) {
                          var update = {
                            "paymentId": temp?.paymentId,
                            "isProcessed": true,
                            "nekretninaPayment": payment.nekretninaPayment,
                            "komentar": payment.komentar,
                            "iznos": payment.iznos,
                            "mjesecno": payment.mjesecno,
                            "nekretnina": payment.nekretnina,
                            "korisnikPaymentId": payment.korisnikPaymentId,
                          };
                          var temp2 = AllPaymentsProvider()
                              .update(payment.paymentRequestId!, update);
                          if (temp2 != null) {
                            showDialog(
                                context: context,
                                builder: (context) {
                                  Future.delayed(Duration(seconds: 5), () {
                                    Navigator.of(context).pop(true);
                                    Navigator.push(
                                      context,
                                      MaterialPageRoute(
                                          builder: (context) =>
                                              const NekretnineListScreen()),
                                    );
                                  });
                                  return AlertDialog(
                                    title: Text('Placanje uspješno!'),
                                  );
                                });
                          }
                        }
                      } catch (e) {
                        showDialog(
                            context: context,
                            builder: (BuildContext context) => AlertDialog(
                                  title: const Text("Error"),
                                  content: Text(e.toString()),
                                  actions: [
                                    TextButton(
                                      child: const Text("Ok"),
                                      onPressed: () => Navigator.pop(context),
                                    )
                                  ],
                                ));
                      }
                    }
                  } catch (e) {
                    showDialog(
                        context: context,
                        builder: (BuildContext context) => AlertDialog(
                              title: const Text("Error"),
                              content: Text(e.toString()),
                              actions: [
                                TextButton(
                                  child: const Text("Ok"),
                                  onPressed: () => Navigator.pop(context),
                                )
                              ],
                            ));
                  }
              },
              child: Text("Submit"),
              
            ),
          ],
        ),
      ]),
    )
    );
  }

  void _handlePayPress() {}
}
