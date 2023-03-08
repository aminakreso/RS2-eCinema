// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'reservationUpsertRequest.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ReservationUpsertRequest _$ReservationUpsertRequestFromJson(
        Map<String, dynamic> json) =>
    ReservationUpsertRequest()
      ..projectionId = json['projectionId'] as String?
      ..userId = json['userId'] as String?
      ..seatsId =
          (json['seatsId'] as List<dynamic>?)?.map((e) => e as String).toList();

Map<String, dynamic> _$ReservationUpsertRequestToJson(
        ReservationUpsertRequest instance) =>
    <String, dynamic>{
      'projectionId': instance.projectionId,
      'userId': instance.userId,
      'seatsId': instance.seatsId,
    };
