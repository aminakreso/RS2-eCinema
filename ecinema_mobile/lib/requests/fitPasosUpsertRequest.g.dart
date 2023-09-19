// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'fitPasosUpsertRequest.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

FITPasosUpsertRequest _$FITPasosUpsertRequestFromJson(
        Map<String, dynamic> json) =>
    FITPasosUpsertRequest()
      ..userId = json['userId'] as String?
      ..value = json['value'] as String?
      ..isValid = json['isValid'] as bool?
      ..expirationDate = json['expirationDate'] == null
          ? null
          : DateTime.parse(json['expirationDate'] as String);

Map<String, dynamic> _$FITPasosUpsertRequestToJson(
        FITPasosUpsertRequest instance) =>
    <String, dynamic>{
      'userId': instance.userId,
      'value': instance.value,
      'isValid': instance.isValid,
      'expirationDate': instance.expirationDate?.toIso8601String(),
    };
