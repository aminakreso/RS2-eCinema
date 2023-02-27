import '../models/stripeCustomer.dart';
import '../requests/addStripeCustomer.dart';
import 'baseProvider.dart';
import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:flutter/foundation.dart';
import 'package:http/http.dart';
import 'package:http/io_client.dart';

class StripeAppServiceProvider extends BaseProvider<StripeCustomer> {
  StripeAppServiceProvider() : super("Stripe");
  @override
  StripeCustomer fromJson(data) {
    return StripeCustomer.fromJson(data);
  }

  /*   final response = await http.post(
                        Uri.parse("https://api.stripe.com/v1/customers"),
                        headers: {
                          "Content-Type": "application/x-www-form-urlencoded",
                          "Authorization": "Bearer ${sKey}",
                        },
                        body: json.encode(body),
                      );
                      print('resvfdg: ${jsonDecode(response.body)}');
                      return jsonDecode(response.body);*/
}
