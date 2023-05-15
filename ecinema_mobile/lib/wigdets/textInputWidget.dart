import 'package:email_validator/email_validator.dart';
import 'package:flutter/material.dart';

class TextInputWidget extends StatelessWidget {
  const TextInputWidget(
      {Key? key,
      required this.controller,
      required this.labelText,
      required this.minLength,
      required this.isEmail})
      : super(key: key);

  final TextEditingController controller;
  final String? labelText;
  final int minLength;
  final bool isEmail;

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
              } else if (minLength > 0 && value.length < minLength) {
                return '$labelText must have at least $minLength characters!';
              } else if (isEmail && !EmailValidator.validate(value)) {
                return '$labelText must have correct format';
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
