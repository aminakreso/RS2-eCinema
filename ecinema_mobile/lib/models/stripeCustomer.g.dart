// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'stripeCustomer.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

StripeCustomer _$StripeCustomerFromJson(Map<String, dynamic> json) =>
    StripeCustomer(
      json['email'] as String,
      json['name'] as String,
      json['customerId'] as String,
    );

Map<String, dynamic> _$StripeCustomerToJson(StripeCustomer instance) =>
    <String, dynamic>{
      'email': instance.email,
      'name': instance.name,
      'customerId': instance.customerId,
    };
