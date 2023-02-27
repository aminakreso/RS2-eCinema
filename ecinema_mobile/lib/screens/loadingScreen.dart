import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';

class LoadingScreen extends StatelessWidget {
  static const String routeName = "/loading";

  //late UserProvider _userProvider;

  @override
  Widget build(BuildContext context) {
    return Scaffold(body: Text("Loading..."));
  }
}
