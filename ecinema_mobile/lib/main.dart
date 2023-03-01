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
import 'package:ecinema_mobile/screens/paymentScreen.dart';
import 'package:ecinema_mobile/screens/reservationListScreen.dart';
import 'package:ecinema_mobile/screens/seatSelectionScreen.dart';
import 'package:ecinema_mobile/screens/userRegistrationScreen.dart';
import 'package:ecinema_mobile/utils/util.dart';
import 'package:ecinema_mobile/wigdets/textInputWidget.dart';
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:provider/provider.dart';
import 'package:ecinema_mobile/.env';

import 'models/payment.dart';

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
              headline5: TextStyle(fontSize: 36.0, color: Colors.black),
              bodyText1: TextStyle(fontSize: 18.0, color: Colors.red[900]),
              bodyText2: TextStyle(
                  fontSize: 12.0,
                  color: Colors.white60,
                  fontStyle: FontStyle.italic)),
          cardTheme: CardTheme(
            color: Colors.white,
            elevation: 5.0,
            margin: EdgeInsets.fromLTRB(10.0, 20.0, 10.0, 20.0),
            shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(10.0),
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
  //late UserProvider _userProvider;

  @override
  Widget build(BuildContext context) {
    //_userProvider = Provider.of<UserProvider>(context, listen: false);
    return Scaffold(
      body: SingleChildScrollView(
        child: Column(children: [
          Center(
            child: LogoText(
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
                    labelText: 'e-mail',
                  ),
                  TextInputWidget(
                    controller: _passwordController,
                    labelText: 'password',
                  ),
                  SizedBox(
                    height: 10,
                  ),
                  Row(
                    children: [
                      Expanded(
                        child: TextButton(
                          onPressed: () async {
                            try {
                              Authorization.username = _usernameController.text;
                              Authorization.password = _passwordController.text;

                              Navigator.pushNamed(
                                  context, MovieListScreen.routeName);
                            } catch (e) {
                              errorDialog(context, e);
                            }
                          },
                          child: Text("Login"),
                        ),
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

class LogoText extends StatelessWidget {
  final bool login;
  const LogoText({
    required this.login,
    Key? key,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Container(
          padding: EdgeInsets.fromLTRB(0, 50.0, 0, 0),
          child: Icon(
            Icons.airplane_ticket,
            color: Colors.red[900],
            size: 100,
          ),
        ),
        Row(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text(
              "e",
              style: Theme.of(context).textTheme.headline2,
            ),
            Text(
              "Cinema",
              style: Theme.of(context).textTheme.headline3,
            ),
          ],
        ),
        Text(
          "ticket in your pocket",
          style: Theme.of(context).textTheme.bodyText2,
        ),
        SizedBox(
          height: 50,
        ),
        if (login) LoginText(),
        SizedBox(
          height: 50,
        ),
      ],
    );
  }
}

class LoginText extends StatelessWidget {
  const LoginText({
    Key? key,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        Text(
          "Log",
          style: Theme.of(context).textTheme.headline1,
        ),
        Text(
          "In",
          style: Theme.of(context).textTheme.headline4,
        ),
      ],
    );
  }
}
