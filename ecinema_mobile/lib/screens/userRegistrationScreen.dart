import 'package:ecinema_mobile/providers/userProvider.dart';
import 'package:ecinema_mobile/wigdets/headerWidget.dart';
import 'package:ecinema_mobile/wigdets/logoTextWidget.dart';
import 'package:ecinema_mobile/wigdets/textInputWidget.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../main.dart';
import '../requests/registrationRequest.dart';

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

  final _formKey = GlobalKey<FormState>();

  @override
  void initState() {
    super.initState();
    _userProvider = context.read<UserProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return Form(
      key: _formKey,
      child: Scaffold(
          body: SingleChildScrollView(
              child: Column(
        children: [
          LogoTextWidget(login: false),
          TextInputWidget(
            labelText: "First name",
            controller: _firstNameController,
            minLength: 6,
            isEmail: false,
          ),
          TextInputWidget(
            labelText: "Last name",
            controller: _lastnameController,
            minLength: 6,
            isEmail: false,
          ),
          TextInputWidget(
            labelText: "E-mail",
            controller: _emailController,
            minLength: 7,
            isEmail: true,
          ),
          TextInputWidget(
            labelText: "Phone number",
            controller: _phoneController,
            minLength: 9,
            isEmail: false,
          ),
          TextInputWidget(
            labelText: "Username",
            controller: _usernameController,
            minLength: 6,
            isEmail: false,
          ),
          TextInputWidget(
            labelText: "Password",
            controller: _passwordController,
            minLength: 6,
            isEmail: false,
          ),
          TextInputWidget(
            labelText: "Confirm password",
            controller: _confirmPasswordController,
            minLength: 6,
            isEmail: false,
          ),
          TextButton(
            onPressed: () async {
              if (_formKey.currentState!.validate()) {
                try {
                  registrationRequest.firstName = _firstNameController.text;
                  registrationRequest.lastName = _lastnameController.text;
                  registrationRequest.email = _emailController.text;
                  registrationRequest.phoneNumber = _phoneController.text;
                  registrationRequest.username = _usernameController.text;
                  registrationRequest.password = _passwordController.text;
                  registrationRequest.confirmPassword =
                      _confirmPasswordController.text;

                  var registeredUser =
                      await _userProvider?.register(registrationRequest);
                  if (registeredUser != null) {
                    showDialog(
                        context: context,
                        builder: (BuildContext context) => AlertDialog(
                              title: Text("User registration successful!"),
                              content: Text(
                                  style: Theme.of(context).textTheme.bodyText1,
                                  "Successfully registered user ${registeredUser.firstName}"),
                              actions: [
                                TextButton(
                                    onPressed: () => Navigator.popAndPushNamed(
                                        context, MovieList.routeName),
                                    child: Text("Ok"))
                              ],
                            ));
                  }
                } catch (e) {
                  showDialog(
                      context: context,
                      builder: (BuildContext context) => AlertDialog(
                            title: Text("Error"),
                            content: Text(
                                style: Theme.of(context).textTheme.bodyText1,
                                e.toString()),
                            actions: [
                              TextButton(
                                  onPressed: () => Navigator.pop(context),
                                  child: Text("Ok"))
                            ],
                          ));
                }
              }
            },
            child: Text('Sačuvaj'),
          )
        ],
      ))),
    );
  }
}

//HeaderWidget("Registration"),
  

