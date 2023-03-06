import 'package:ecinema_mobile/providers/movieProvider.dart';
import 'package:ecinema_mobile/providers/paymentProvider.dart';
import 'package:ecinema_mobile/providers/projectionProvider.dart';
import 'package:ecinema_mobile/providers/reservationProvider.dart';
import 'package:ecinema_mobile/providers/hallProvider.dart';
import 'package:ecinema_mobile/providers/seatReservationProvider.dart';
import 'package:ecinema_mobile/providers/userProvider.dart';
import 'package:ecinema_mobile/screens/movieDetailsScreen.dart';
import 'package:ecinema_mobile/screens/movieListScreen.dart';
import 'package:ecinema_mobile/screens/myProfileScreen.dart';
import 'package:ecinema_mobile/screens/reservationListScreen.dart';
import 'package:ecinema_mobile/screens/seatSelectionScreen.dart';
import 'package:ecinema_mobile/screens/userRegistrationScreen.dart';
import 'package:ecinema_mobile/utils/util.dart';
import 'package:ecinema_mobile/wigdets/logoTextWidget.dart';
import 'package:ecinema_mobile/wigdets/textInputWidget.dart';
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:provider/provider.dart';
import 'package:ecinema_mobile/.env';

import 'models/payment.dart';
import 'models/user.dart';

Future<void> main() async {
  WidgetsFlutterBinding.ensureInitialized();
  Stripe.publishableKey = stripePublishableKey;
  Stripe.merchantIdentifier = 'any string works';
  await Stripe.instance.applySettings();

  runApp(MultiProvider(
    providers: [
      ChangeNotifierProvider(create: (_) => MovieProvider()),
      ChangeNotifierProvider(create: (_) => UserProvider()),
      ChangeNotifierProvider(create: (_) => ProjectionProvider()),
      ChangeNotifierProvider(create: (_) => ReservationProvider()),
      ChangeNotifierProvider(create: (_) => SeatReservationProvider()),
      ChangeNotifierProvider(create: (_) => HallProvider()),
      ChangeNotifierProvider(create: (_) => PaymentProvider()),
    ],
    child: MaterialApp(
        debugShowCheckedModeBanner: true,
        theme: ThemeData(
          brightness: Brightness.dark,
          primaryColor: Colors.red[900],
          textButtonTheme: TextButtonThemeData(
              style: TextButton.styleFrom(
                  foregroundColor: Colors.red[900],
                  textStyle: TextStyle(
                    fontSize: 24,
                    fontWeight: FontWeight.bold,
                  ))),
          textTheme: TextTheme(
              headline1: TextStyle(
                  fontSize: 72.0,
                  fontWeight: FontWeight.bold,
                  color: Colors.red[900]),
              headline4: TextStyle(
                  fontSize: 72.0,
                  fontWeight: FontWeight.bold,
                  color: Colors.white70),
              headline2: TextStyle(fontSize: 36.0, color: Colors.red[900]),
              headline3: TextStyle(fontSize: 36.0, color: Colors.white70),
              headline5: TextStyle(fontSize: 24.0, color: Colors.black),
              bodyText1: TextStyle(fontSize: 18.0, color: Colors.red[900]),
              bodyText2: TextStyle(
                  fontSize: 12.0,
                  color: Colors.white60,
                  fontStyle: FontStyle.italic)),
          cardTheme: CardTheme(
            color: Colors.white,
            elevation: 5.0,
            margin: EdgeInsets.only(top: 20.0),
            shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(20.0),
            ),
          ),
        ),
        home: MovieList(),
        onGenerateRoute: (settings) {
          if (settings.name == MovieListScreen.routeName) {
            return MaterialPageRoute(builder: ((context) => MovieListScreen()));
          } else if (settings.name == ReservationListScreen.routeName) {
            return MaterialPageRoute(
                builder: ((context) => ReservationListScreen()));
          } else if (settings.name == MovieList.routeName) {
            return MaterialPageRoute(builder: ((context) => MovieList()));
          } else if (settings.name == UserRegistrationScreen.routeName) {
            return MaterialPageRoute(
                builder: ((context) => UserRegistrationScreen()));
          } else if (settings.name == MyProfileScreen.routeName) {
            return MaterialPageRoute(builder: ((context) => MyProfileScreen()));
          }

          var uri = Uri.parse(settings.name!);
          if (uri.pathSegments.length == 2 &&
              "/${uri.pathSegments.first}" == MovieDetailsScreen.routeName) {
            var id = uri.pathSegments[1];
            return MaterialPageRoute(
                builder: (context) => MovieDetailsScreen(id));
          } else if (uri.pathSegments.length == 2 &&
              "/${uri.pathSegments.first}" == SeatSelectionScreen.routeName) {
            var id = uri.pathSegments[1];
            return MaterialPageRoute(
                builder: (context) => SeatSelectionScreen(id));
          }
        }),
  ));
}

class MovieList extends StatelessWidget {
  static const String routeName = "/login";
  TextEditingController _usernameController = TextEditingController();
  TextEditingController _passwordController = TextEditingController();

  final _formKey = GlobalKey<FormState>();
  late UserProvider _userProvider;

  @override
  Widget build(BuildContext context) {
    _userProvider = Provider.of<UserProvider>(context, listen: false);
    return Form(
      key: _formKey,
      child: Scaffold(
        body: SingleChildScrollView(
          child: Column(children: [
            Center(
              child: LogoTextWidget(
                login: true,
              ),
            ),
            Container(
                decoration: BoxDecoration(
                  color: Colors.white70,
                  borderRadius: BorderRadius.circular(10),
                ),
                child: Column(
                  children: [
                    TextInputWidget(
                      controller: _usernameController,
                      labelText: 'E-mail',
                    ),
                    TextInputWidget(
                      controller: _passwordController,
                      labelText: 'Password',
                    ),
                    SizedBox(
                      height: 10,
                    ),
                    Row(
                      children: [
                        Expanded(
                          child: TextButton(
                              onPressed: () async {
                                if (_formKey.currentState!.validate()) {
                                  try {
                                    Authorization.username =
                                        _usernameController.text;
                                    Authorization.password =
                                        _passwordController.text;

                                    List<User> users =
                                        await _userProvider.get();
                                    Authorization.id = users
                                        .firstWhere((user) =>
                                            user.username ==
                                            Authorization.username)
                                        .id;

                                    Navigator.pushNamed(
                                        context, MovieListScreen.routeName);
                                  } catch (e) {
                                    errorDialog(context, e);
                                  }
                                }
                              },
                              child: Text("Login")),
                        ),
                        Expanded(
                            child: TextButton(
                                onPressed: () async {
                                  try {
                                    Navigator.pushNamed(context,
                                        UserRegistrationScreen.routeName);
                                  } catch (e) {
                                    errorDialog(context, e);
                                  }
                                },
                                child: Text("Register")))
                      ],
                    )
                  ],
                ))
          ]),
        ),
      ),
    );
  }

  Future<dynamic> errorDialog(BuildContext context, Object e) {
    return showDialog(
        context: context,
        builder: (BuildContext context) => AlertDialog(
              title: Text("Error"),
              content: Text(e.toString()),
              actions: [
                TextButton(
                  child: Text("Ok"),
                  onPressed: () => Navigator.pop(context),
                )
              ],
            ));
  }
}
