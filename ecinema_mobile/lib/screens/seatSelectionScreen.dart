import 'package:ecinema_mobile/models/projection.dart';
import 'package:ecinema_mobile/models/seat.dart';
import 'package:ecinema_mobile/providers/projectionProvider.dart';
import 'package:ecinema_mobile/requests/reservationUpsertRequest.dart';
import 'package:ecinema_mobile/screens/reservationDetailsScreen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../models/seatxrefReservation.dart';
import '../providers/hallProvider.dart';
import '../providers/seatReservationProvider.dart';
import '../utils/util.dart';
import '../wigdets/master_screen.dart';
import 'loadingScreen.dart';

class SeatSelectionScreen extends StatefulWidget {
  static const String routeName = "/seat_selection";
  String id;

  SeatSelectionScreen(this.id, {Key? key}) : super(key: key);
  @override
  State<SeatSelectionScreen> createState() => _SeatSelectionScreenState();
}

class _SeatSelectionScreenState extends State<SeatSelectionScreen> {
  List<SeatxrefReservation>? _reservedSeats = null;
  List<Seat>? _allSeats = null;
  Projection? _projection = null;

  SeatReservationProvider? _seatReservationProvider = null;
  HallProvider? _hallProvider = null;
  ProjectionProvider? _projectionProvider = null;

  List<MaterialColor>? _colors = List.generate(30, (_) => Colors.grey);
  List<int>? _selectedIndexes = [];
  List<Seat>? _selectedSeats = [];

  MaterialColor? _buttonColor;

  ReservationUpsertRequest? insert = ReservationUpsertRequest();

  void _changeButtonColor(int index) {
    bool _isTaken = _reservedSeats!
        .any((element) => element.seatId == _allSeats![index].id);
    if (_isTaken) {
      _buttonColor = Colors.red;
    } else if (_selectedIndexes?.any((element) => element == index) == true &&
        !_isTaken) {
      _buttonColor = Colors.amber;
    } else {
      _buttonColor = Colors.grey;
    }

    _colors?[index] = _buttonColor!;
  }

  @override
  void initState() {
    super.initState();
    _seatReservationProvider = context.read<SeatReservationProvider>();
    _hallProvider = context.read<HallProvider>();
    _projectionProvider = context.read<ProjectionProvider>();
    loadData();
  }

  Future loadData() async {
    var projection = await _projectionProvider?.getById(this.widget.id);

    setState(() {
      _projection = projection;
      loadAllSeats(_projection!.hallId);
      load_ReservedSeats(_projection!.id);
    });
  }

  Future loadAllSeats(String hallId) async {
    var hall = await _hallProvider?.getById(hallId);
    setState(() {
      _allSeats = hall?.seat;
    });
  }

  Future load_ReservedSeats(String projectionId) async {
    var searchRequest = {'ProjectionId': projectionId};
    var tmp_ReservedSeats = await _seatReservationProvider?.get(searchRequest);
    setState(() {
      _reservedSeats = tmp_ReservedSeats;
    });
  }

  @override
  Widget build(BuildContext context) {
    final screenWidth = MediaQuery.of(context).size.width;
    if (_reservedSeats == null || _allSeats == null) {
      loadData();
      return LoadingScreen();
    } else {
      return MasterScreenWidget(
          child: Column(
        children: [
          Stack(children: [
            Container(
              height: 200,
              width: screenWidth,
              child: imageFromBase64String(_projection!.movie!.picture!),
            ),
            Positioned(
              left: 10,
              top: 100,
              child: Text(
                _projection!.movie!.name!,
                style: Theme.of(context).textTheme.headline1,
              ),
            )
          ]),
          Expanded(
            child: Container(
              margin: EdgeInsets.symmetric(vertical: 20, horizontal: 10),
              color: Colors.white,
              height: 500,
              child: Column(
                children: [
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Container(
                        padding: const EdgeInsets.all(8.0),
                        child: Text(
                          "${getDate(_projection!.startTime!)}",
                          style: TextStyle(color: Colors.black, fontSize: 16),
                        ),
                      ),
                      Container(
                          margin: EdgeInsets.fromLTRB(0, 10, 10, 0),
                          padding: EdgeInsets.all(5),
                          color: Colors.red[900],
                          child: Text(
                            "${getTime(_projection!.startTime!)}",
                            style: TextStyle(color: Colors.white, fontSize: 16),
                          )),
                    ],
                  ),
                  Center(
                    child: Text(
                      "Pick seats:",
                      style: TextStyle(
                          color: Colors.black,
                          fontSize: 14,
                          fontWeight: FontWeight.bold),
                    ),
                  ),
                  Expanded(
                    child: GridView.count(
                        crossAxisCount: 5,
                        children: List.generate(_allSeats!.length, (index) {
                          _changeButtonColor(index);
                          return InkWell(
                            onLongPress: () => {
                              setState(
                                () {
                                  if (_selectedIndexes!
                                      .any((element) => element == index)) {
                                    _selectedIndexes?.remove(index);
                                    _selectedSeats?.remove(_allSeats![index]);
                                  } else {
                                    _selectedIndexes?.add(index);
                                    _selectedSeats?.add(_allSeats![index]);
                                  }
                                },
                              )
                            },
                            child: Icon(Icons.square, color: _colors![index]),
                          );
                        })

                        //_changeButtonColor(index);

                        ),
                  ),
                  TextButton(
                    onPressed: () {
                      insert?.projectionId = _projection!.id;
                      insert?.projection = _projection;
                      insert?.seats = _selectedSeats;

                      Navigator.push(
                        context,
                        MaterialPageRoute(
                          builder: (context) => ReservationDetailsScreen(
                              reservationInsertRequest: insert!),
                        ),
                      );
                    },
                    child: Text("Confirm reservation"),
                  )
                ],
              ),
            ),
          ),
        ],
      ));
    }
  }
}
