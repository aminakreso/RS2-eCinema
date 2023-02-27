import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';

class MovieCardLine extends StatelessWidget {
  const MovieCardLine(
      {Key? key,
      required this.label,
      required this.text,
      this.font = 12,
      this.padding = 0})
      : super(key: key);

  final String label;
  final String? text;
  final double? font;
  final double? padding;

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: EdgeInsets.all(padding!),
      child: RichText(
        text: TextSpan(
          text: label,
          style: TextStyle(
              color: Colors.red[900],
              fontWeight: FontWeight.bold,
              fontSize: font),
          children: <TextSpan>[
            TextSpan(
              text: '$text' ?? "",
              style: TextStyle(
                  color: Colors.black,
                  fontSize: font,
                  fontWeight: FontWeight.normal),
            ),
          ],
        ),
      ),
    );
  }
}
