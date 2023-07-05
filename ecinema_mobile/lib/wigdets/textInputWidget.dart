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
    bool password = labelText == "Lozinka" || labelText == "Potvrdi lozinku";
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
              } else if (minLength > 0 && value.length < minLength) {
                return '$labelText mora imat minimalno $minLength karaktera!';
              } else if (isEmail && !EmailValidator.validate(value)) {
                return '$labelText mora biti u tačnom formatu!';
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
