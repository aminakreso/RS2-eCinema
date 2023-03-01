import 'package:flutter/material.dart';

class TextInputWidget extends StatelessWidget {
  const TextInputWidget({
    Key? key,
    required this.controller,
    required this.labelText,
  }) : super(key: key);

  final TextEditingController controller;
  final String? labelText;

  @override
  Widget build(BuildContext context) {
    bool password = labelText == "Password" || labelText == "Confirm password";
    return Container(
        margin: EdgeInsets.all(8),
        decoration: BoxDecoration(
          color: Colors.white,
          borderRadius: BorderRadius.circular(10),
        ),
        child: TextFormField(
            validator: (value) {
              if (value!.isEmpty) {
                return '$labelText must not be empty!';
              }
              return null;
            },
            style: Theme.of(context).textTheme.bodyText1,
            obscureText: password,
            controller: controller,
            decoration: InputDecoration(
              hintText: this.labelText ?? "",
              hintStyle: Theme.of(context).textTheme.bodyText1,
            )));
  }
}
