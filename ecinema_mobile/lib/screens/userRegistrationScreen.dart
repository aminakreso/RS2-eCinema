import 'dart:convert';
import 'dart:io';

import 'package:ecinema_mobile/models/reservation.dart';
import 'package:ecinema_mobile/providers/reservationProvider.dart';
import 'package:ecinema_mobile/providers/userProvider.dart';
import 'package:ecinema_mobile/wigdets/headerWidget.dart';
import 'package:ecinema_mobile/wigdets/textInputWidget.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../main.dart';
import '../models/movie.dart';
import '../models/user.dart';
import '../providers/movieProvider.dart';
import '../requests/registrationRequest.dart';
import '../utils/util.dart';
import '../wigdets/master_screen.dart';

class UserRegistrationScreen extends StatefulWidget {
  static const String routeName = "/registration";
  const UserRegistrationScreen({Key? key}) : super(key: key);

  @override
  State<UserRegistrationScreen> createState() => _UserRegistrationScreenState();
}

class _UserRegistrationScreenState extends State<UserRegistrationScreen> {
  UserProvider? _userProvider = null;

  RegistrationRequest registrationRequest = new RegistrationRequest();

  TextEditingController _firstNameController = TextEditingController();

  TextEditingController _lastnameController = TextEditingController();

  TextEditingController _emailController = TextEditingController();

  TextEditingController _phoneController = TextEditingController();

  TextEditingController _usernameController = TextEditingController();

  TextEditingController _passwordController = TextEditingController();

  TextEditingController _confirmPasswordController = TextEditingController();

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _userProvider = context.read<UserProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SingleChildScrollView(
            child: Column(
      children: [
        HeaderWidget(
          title: 'Registration',
        ),
        TextInputWidget(
          labelText: "First name:",
          controller: _firstNameController,
        ),
        TextInputWidget(
          labelText: "Last name:",
          controller: _lastnameController,
        ),
        TextInputWidget(
          labelText: "E-mail:",
          controller: _emailController,
        ),
        TextInputWidget(
          labelText: "Phone number:",
          controller: _phoneController,
        ),
        TextInputWidget(
          labelText: "Username:",
          controller: _usernameController,
        ),
        TextInputWidget(
          labelText: "Password:",
          controller: _passwordController,
        ),
        TextInputWidget(
          labelText: "Confirm password:",
          controller: _confirmPasswordController,
        ),
        ElevatedButton(
          onPressed: () async {
            registrationRequest.firstName = _firstNameController.text;
            registrationRequest.lastName = _lastnameController.text;
            registrationRequest.email = _emailController.text;
            registrationRequest.phoneNumber = _phoneController.text;
            registrationRequest.username = _usernameController.text;
            registrationRequest.password = _passwordController.text;
            registrationRequest.confirmPassword =
                _confirmPasswordController.text;

            await _userProvider?.register(registrationRequest);
            Navigator.pushNamed(context, MovieList.routeName);
          },
          child: Text('Send POST'),
        )
      ],
    )));
  }
}

//HeaderWidget("Registration"),
  

