import 'dart:convert';
import 'dart:io';

import 'package:ecinema_mobile/models/reservation.dart';
import 'package:ecinema_mobile/providers/reservationProvider.dart';
import 'package:ecinema_mobile/providers/userProvider.dart';
import 'package:ecinema_mobile/screens/movieListScreen.dart';
import 'package:ecinema_mobile/wigdets/textInputWidget.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';

import '../models/movie.dart';
import '../models/user.dart';
import '../providers/movieProvider.dart';
import '../requests/userUpdateRequest.dart';
import '../utils/util.dart';
import '../wigdets/headerWidget.dart';
import '../wigdets/master_screen.dart';

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

  @override
  void initState() {
    super.initState();
    _userProvider = context.read<UserProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData =
        await _userProvider?.getById("8624280d-0da0-48bb-c4c8-08db0f698d29");
    setState(() {
      user = tmpData;
      _firstNameController.text = tmpData!.firstName!;
      _lastnameController.text = tmpData.lastName!;
      _emailController.text = tmpData.email!;
      _phoneController.text = tmpData.phoneNumber!;
      _usernameController.text = tmpData.username!;
    });

    print(user);
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Column(
        children: [
          HeaderWidget(title: "My Profile"),
          setProfileInput(_firstNameController),
          setProfileInput(_lastnameController),
          setProfileInput(_emailController),
          setProfileInput(_phoneController),
          setProfileInput(_usernameController),
          Row(
            children: [
              TextButton(
                onPressed: () async {},
                child: Text('Change password'),
              ),
              TextButton(
                onPressed: () async {
                  userUpdateRequest.firstName = _firstNameController.text;
                  userUpdateRequest.lastName = _lastnameController.text;
                  userUpdateRequest.email = _emailController.text;
                  userUpdateRequest.phoneNumber = _phoneController.text;
                  userUpdateRequest.username = _usernameController.text;

                  await _userProvider?.update(user!.id, userUpdateRequest);
                  Navigator.pushNamed(context, MovieListScreen.routeName);
                },
                child: Text('Save'),
              )
            ],
          )
        ],
      ),
    );
  }

  Container setProfileInput(TextEditingController controller) {
    return Container(
        margin: EdgeInsets.all(8),
        decoration: BoxDecoration(
          color: Colors.white,
          borderRadius: BorderRadius.circular(10),
        ),
        child: TextField(
          style: Theme.of(context).textTheme.bodyText1,
          controller: controller,
        ));
  }
}
