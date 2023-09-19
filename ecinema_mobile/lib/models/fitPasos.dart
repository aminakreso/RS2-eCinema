import 'dart:ffi';
import 'package:ecinema_mobile/models/projection.dart';
import 'package:ecinema_mobile/models/projection.dart';
import 'package:ecinema_mobile/models/user.dart';
import 'package:json_annotation/json_annotation.dart';

part 'fitPasos.g.dart';

@JsonSerializable()
class FITPasos {
  String? id;
  String? userId;
  String? value;
  bool? isValid;
  User? user;
  DateTime? issueDate;
  DateTime? expirationDate;

  FITPasos();

  /// A necessary factory constructor for creating a new User instance
  /// from a map. Pass the map to the generated `_$UserFromJson()` constructor.
  /// The constructor is named after the source class, in this case, User.
  factory FITPasos.fromJson(Map<String, dynamic> json) =>
      _$FITPasosFromJson(json);

  /// `toJson` is the convention for a class to declare support for serialization
  /// to JSON. The implementation simply calls the private, generated
  /// helper method `_$UserToJson`.
  Map<String, dynamic> toJson() => _$FITPasosToJson(this);
}
