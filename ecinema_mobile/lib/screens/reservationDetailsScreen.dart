import 'dart:convert';
import 'dart:io';

import 'package:ecinema_mobile/models/projection.dart';
import 'package:ecinema_mobile/providers/projectionProvider.dart';
import 'package:ecinema_mobile/screens/seatSelectionScreen.dart';
import 'package:ecinema_mobile/wigdets/textInputWidget.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:collection/collection.dart';

import '../models/movie.dart';
import '../providers/movieProvider.dart';
import '../requests/reservationUpsertRequest.dart';
import '../utils/util.dart';
import '../wigdets/master_screen.dart';
import '../wigdets/movieCardLine.dart';
import 'loadingScreen.dart';

class ReservationDetailsScreen extends StatelessWidget {
  static const String routeName = "/reservation_details";
  ReservationUpsertRequest reservationInsertRequest;

  ReservationDetailsScreen({required this.reservationInsertRequest, Key? key})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    if (reservationInsertRequest == null)
      return LoadingScreen();
    else {
      return MasterScreenWidget(
        child: Center(
          child: Container(
            margin: EdgeInsets.only(top: 30),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                MovieCardLine(
                  label: "Movie: ",
                  text: '${reservationInsertRequest.projection?.movie?.name}',
                  font: 18,
                  padding: 8,
                ),
                MovieCardLine(
                    label: "Date: ",
                    text: getDate(
                        reservationInsertRequest.projection!.startTime!),
                    font: 18,
                    padding: 8),
                MovieCardLine(
                  label: "Time ",
                  text:
                      getTime(reservationInsertRequest.projection!.startTime!),
                  font: 18,
                  padding: 8,
                ),
                MovieCardLine(
                  label: "Hall: ",
                  text: '${reservationInsertRequest.projection?.hall?.name}',
                  font: 18,
                  padding: 8,
                ),
                MovieCardLine(
                  label: "Number of reserved seats: ",
                  text: '${reservationInsertRequest.seats?.length}',
                  font: 18,
                  padding: 8,
                ),
                SizedBox(height: 10),
                Expanded(
                  child: GridView.count(
                      crossAxisCount: 1,
                      childAspectRatio: 3 / 1,
                      mainAxisSpacing: 20,
                      children: List.generate(
                          reservationInsertRequest.seats!.length, (index) {
                        return Container(
                          decoration: BoxDecoration(
                              color: Colors.grey,
                              borderRadius: BorderRadius.circular(10.0)),
                          child: Center(
                            child: Text(
                              "${reservationInsertRequest.projection?.projectionType}  - Sjedalo ${reservationInsertRequest.seats![index].name}",
                              style: TextStyle(color: Colors.black),
                            ),
                          ),
                        );
                      })

                      //_changeButtonColor(index);

                      ),
                ),
                Center(
                  child: TextButton(
                    onPressed: () {},
                    child: Text("Nastavi"),
                  ),
                )
              ],
            ),
          ),
        ),
      );
    }
  }
}
