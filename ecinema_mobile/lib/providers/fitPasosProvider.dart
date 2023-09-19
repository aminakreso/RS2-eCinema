import 'package:ecinema_mobile/models/fitPasos.dart';
import 'package:ecinema_mobile/providers/baseProvider.dart';

class FITPasosProvider extends BaseProvider<FITPasos> {
  FITPasosProvider() : super("FITPasos");

  @override
  FITPasos fromJson(data) {
    return FITPasos.fromJson(data);
  }
}
