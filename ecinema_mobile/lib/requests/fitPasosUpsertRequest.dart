import 'dart:ffi';

import 'package:ecinema_mobile/models/projection.dart';
import 'package:ecinema_mobile/models/reservation.dart';
import 'package:json_annotation/json_annotation.dart';

import '../models/seat.dart';

part 'fitPasosUpsertRequest.g.dart';

@JsonSerializable()
class FITPasosUpsertRequest {
  String? userId;
  String? value;
  bool? isValid;
  DateTime? expirationDate;

  FITPasosUpsertRequest();

  /// A necessary factory constructor for creating a new User instance
  /// from a map. Pass the map to the generated `_$UserFromJson()` constructor.
  /// The constructor is named after the source class, in this case, User.
  factory FITPasosUpsertRequest.fromJson(Map<String, dynamic> json) =>
      _$FITPasosUpsertRequestFromJson(json);

  /// `toJson` is the convention for a class to declare support for serialization
  /// to JSON. The implementation simply calls the private, generated
  /// helper method `_$UserToJson`.
  Map<String, dynamic> toJson() => _$FITPasosUpsertRequestToJson(this);
}
