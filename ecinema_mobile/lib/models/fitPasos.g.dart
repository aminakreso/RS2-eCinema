// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'fitPasos.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

FITPasos _$FITPasosFromJson(Map<String, dynamic> json) => FITPasos()
  ..id = json['id'] as String?
  ..userId = json['userId'] as String?
  ..value = json['value'] as String?
  ..isValid = json['isValid'] as bool?
  ..user = json['user'] == null
      ? null
      : User.fromJson(json['user'] as Map<String, dynamic>)
  ..issueDate = json['issueDate'] == null
      ? null
      : DateTime.parse(json['issueDate'] as String)
  ..expirationDate = json['expirationDate'] == null
      ? null
      : DateTime.parse(json['expirationDate'] as String);

Map<String, dynamic> _$FITPasosToJson(FITPasos instance) => <String, dynamic>{
      'id': instance.id,
      'userId': instance.userId,
      'value': instance.value,
      'isValid': instance.isValid,
      'user': instance.user,
      'issueDate': instance.issueDate?.toIso8601String(),
      'expirationDate': instance.expirationDate?.toIso8601String(),
    };
