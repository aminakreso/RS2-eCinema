// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'projection.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Projection _$ProjectionFromJson(Map<String, dynamic> json) => Projection(
      json['id'] as String,
      json['startTime'] == null
          ? null
          : DateTime.parse(json['startTime'] as String),
      json['endTime'] == null
          ? null
          : DateTime.parse(json['endTime'] as String),
      json['hallId'] as String,
      json['hall'] == null
          ? null
          : Hall.fromJson(json['hall'] as Map<String, dynamic>),
      json['movieId'] as String,
      json['movie'] == null
          ? null
          : Movie.fromJson(json['movie'] as Map<String, dynamic>),
      json['priceId'] as String,
      json['price'] == null
          ? null
          : Price.fromJson(json['price'] as Map<String, dynamic>),
      json['projectionType'] as String?,
      json['status'] as String?,
      json['isActive'] as bool?,
    );

Map<String, dynamic> _$ProjectionToJson(Projection instance) =>
    <String, dynamic>{
      'id': instance.id,
      'startTime': instance.startTime?.toIso8601String(),
      'endTime': instance.endTime?.toIso8601String(),
      'hallId': instance.hallId,
      'hall': instance.hall,
      'movieId': instance.movieId,
      'movie': instance.movie,
      'priceId': instance.priceId,
      'price': instance.price,
      'projectionType': instance.projectionType,
      'status': instance.status,
      'isActive': instance.isActive,
    };
