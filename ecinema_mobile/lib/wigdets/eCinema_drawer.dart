import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class eCinemaDrawer extends StatelessWidget {
  eCinemaDrawer({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: ListView(
        children: [
          ListTile(
            title: Text('Home'),
          ),
          ListTile(
            title: Text('Cart'),
          ),
        ],
      ),
    );
  }
}
