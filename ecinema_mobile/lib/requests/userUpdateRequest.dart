import 'dart:ffi';

import 'package:ecinema_mobile/models/reservation.dart';
import 'package:json_annotation/json_annotation.dart';

part 'userUpdateRequest.g.dart';

@JsonSerializable()
class UserUpdateRequest {
  String? firstName;
  String? lastName;
  String? email;
  String? phoneNumber;
  String? username;

  UserUpdateRequest() {}

  /// A necessary factory constructor for creating a new User instance
  /// from a map. Pass the map to the generated `_$UserFromJson()` constructor.
  /// The constructor is named after the source class, in this case, User.
  factory UserUpdateRequest.fromJson(Map<String, dynamic> json) =>
      _$UserUpdateRequestFromJson(json);

  /// `toJson` is the convention for a class to declare support for serialization
  /// to JSON. The implementation simply calls the private, generated
  /// helper method `_$UserToJson`.
  Map<String, dynamic> toJson() => _$UserUpdateRequestToJson(this);
}
