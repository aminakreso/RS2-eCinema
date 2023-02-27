// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'user.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

User _$UserFromJson(Map<String, dynamic> json) => User(
      json['id'] as String,
      json['firstName'] as String?,
      json['lastName'] as String?,
      json['email'] as String?,
      json['phoneNumber'] as String?,
      json['username'] as String?,
      json['password'] as String?,
      json['confirmPassword'] as String?,
      (json['reservations'] as List<dynamic>?)
          ?.map((e) => Reservation.fromJson(e as Map<String, dynamic>))
          .toList(),
    );

Map<String, dynamic> _$UserToJson(User instance) => <String, dynamic>{
      'id': instance.id,
      'firstName': instance.firstName,
      'lastName': instance.lastName,
      'email': instance.email,
      'phoneNumber': instance.phoneNumber,
      'username': instance.username,
      'password': instance.password,
      'confirmPassword': instance.confirmPassword,
      'reservations': instance.reservations,
    };
