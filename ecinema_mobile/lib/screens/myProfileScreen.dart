import 'package:ecinema_mobile/providers/userProvider.dart';
import 'package:ecinema_mobile/screens/movieListScreen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:email_validator/email_validator.dart';

import '../models/user.dart';
import '../requests/userUpdateRequest.dart';
import '../utils/util.dart';
import '../wigdets/headerWidget.dart';
import '../wigdets/master_screen.dart';
import 'loadingScreen.dart';

class MyProfileScreen extends StatefulWidget {
  static const String routeName = "/profile";
  const MyProfileScreen({Key? key}) : super(key: key);
  @override
  State<MyProfileScreen> createState() => _MyProfileScreenState();
}

class _MyProfileScreenState extends State<MyProfileScreen> {
  UserProvider? _userProvider = null;
  User? user = null;
  UserUpdateRequest userUpdateRequest = new UserUpdateRequest();

  TextEditingController _firstNameController = new TextEditingController();
  TextEditingController _lastnameController = new TextEditingController();
  TextEditingController _emailController = new TextEditingController();
  TextEditingController _phoneController = new TextEditingController();
  TextEditingController _usernameController = new TextEditingController();

  final _formKey = GlobalKey<FormState>();

  @override
  void initState() {
    super.initState();
    _userProvider = context.read<UserProvider>();
    loadData();
  }

  Future loadData() async {
    if (Authorization.id != null) {
      var tmpData = await _userProvider?.getById(Authorization.id!);

      setState(() {
        user = tmpData;
        _firstNameController.text = tmpData?.firstName ?? "";
        _lastnameController.text = tmpData?.lastName ?? "";
        _emailController.text = tmpData?.email ?? "";
        _phoneController.text = tmpData?.phoneNumber ?? "";
        _usernameController.text = tmpData?.username ?? "";
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    if (user == null) return LoadingScreen();
    return Form(
      key: _formKey,
      child: MasterScreenWidget(
        child: SingleChildScrollView(
          child: Column(
            children: [
              HeaderWidget(title: "Moj Profil"),
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text("Ime ", style: Theme.of(context).textTheme.bodyText2),
                    setProfileInput(_firstNameController, "First name", 2),
                    Text("Prezime ",
                        style: Theme.of(context).textTheme.bodyText2),
                    setProfileInput(_lastnameController, "Last name", 2),
                    Text("Email ",
                        style: Theme.of(context).textTheme.bodyText2),
                    setProfileInput(_emailController, "Email", 7, true),
                    Text("Broj telefona ",
                        style: Theme.of(context).textTheme.bodyText2),
                    setProfileInput(
                        _phoneController, "Phone number", 9, false, true),
                    Text("Korisničko ime ",
                        style: Theme.of(context).textTheme.bodyText2),
                    setProfileInput(_usernameController, "Username", 4),
                  ],
                ),
              ),
              TextButton(
                onPressed: () async {
                  if (_formKey.currentState!.validate()) {
                    try {
                      userUpdateRequest.firstName = _firstNameController.text;
                      userUpdateRequest.lastName = _lastnameController.text;
                      userUpdateRequest.email = _emailController.text;
                      userUpdateRequest.phoneNumber = _phoneController.text;
                      userUpdateRequest.username = _usernameController.text;

                      await _userProvider?.update(user!.id, userUpdateRequest);
                      Navigator.pushNamed(context, MovieListScreen.routeName);
                    } catch (e) {
                      errorDialog(context, e);
                    }
                  }
                },
                child: Text('Sačuvaj'),
              )
            ],
          ),
        ),
      ),
    );
  }

  Container setProfileInput(TextEditingController controller, String labelText,
      [int minLenght = 0, bool isEmail = false, bool isPhoneNumber = false]) {
    RegExp phoneNumberRegex = RegExp(r'^\d{3}\s\d{3}\s\d{3,4}$');
    return Container(
        margin: EdgeInsets.all(8),
        decoration: BoxDecoration(
          color: Colors.white,
          borderRadius: BorderRadius.circular(10),
        ),
        child: TextFormField(
          validator: (value) {
            if (value!.isEmpty) {
              return '$labelText ne smije biti prazno!';
            } else if (minLenght > 0 && value.length < minLenght) {
              return '$labelText mora imat minimalno $minLenght karaktera!';
            } else if (isEmail && !EmailValidator.validate(value)) {
              return '$labelText mora biti u tačnom formatu';
            } else if (isPhoneNumber && !phoneNumberRegex.hasMatch(value)) {
              return '$labelText mora biti u formatu kao npr 061 111 111';
            }
            return null;
          },
          style: Theme.of(context).textTheme.bodyText1,
          controller: controller,
        ));
  }
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
