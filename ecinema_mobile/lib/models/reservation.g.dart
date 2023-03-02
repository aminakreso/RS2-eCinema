// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'reservation.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Reservation _$ReservationFromJson(Map<String, dynamic> json) => Reservation(
      json['id'] as String?,
      json['userId'] as String?,
      json['projectionId'] as String?,
      json['projection'] == null
          ? null
          : Projection.fromJson(json['projection'] as Map<String, dynamic>),
      json['isActive'] as bool?,
      json['dateTime'] == null
          ? null
          : DateTime.parse(json['dateTime'] as String),
    );

Map<String, dynamic> _$ReservationToJson(Reservation instance) =>
    <String, dynamic>{
      'id': instance.id,
      'userId': instance.userId,
      'projectionId': instance.projectionId,
      'projection': instance.projection,
      'isActive': instance.isActive,
      'dateTime': instance.dateTime?.toIso8601String(),
    };
