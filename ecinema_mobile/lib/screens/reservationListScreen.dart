import 'package:ecinema_mobile/models/reservation.dart';
import 'package:ecinema_mobile/providers/reservationProvider.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../utils/util.dart';
import '../wigdets/headerWidget.dart';
import '../wigdets/master_screen.dart';

class ReservationListScreen extends StatefulWidget {
  static const String routeName = "/reservation";
  const ReservationListScreen({Key? key}) : super(key: key);
  @override
  State<ReservationListScreen> createState() => _ReservationListScreenState();
}

class _ReservationListScreenState extends State<ReservationListScreen> {
  ReservationProvider? _reservationProvider = null;
  List<Reservation>? data = [];
  TextEditingController _searchController = TextEditingController();
  @override
  void initState() {
    super.initState();
    _reservationProvider = context.read<ReservationProvider>();
    loadData();
  }

  Future loadData() async {
    if (Authorization.username != null) {
      var searchRequest = {'User': Authorization.username};
      // Ne posalje se request
      var tmpData = await _reservationProvider?.get(searchRequest);
      setState(() {
        data = tmpData;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    if (data == null)
      return Text("No available reservation yet",
          style: Theme.of(context).textTheme.headline3);
    return MasterScreenWidget(
      child: Column(
        children: [
          HeaderWidget(title: "Reservations"),
          Expanded(
            child: ListView.builder(
              itemCount: data?.length,
              itemBuilder: (BuildContext context, int index) {
                return _buildResevationCard(data![index]);
              },
            ),
          ),
        ],
      ),
    );
  }

  Card _buildResevationCard(Reservation x) {
    return Card(
      child: Row(
        children: [
          Container(
            height: 150,
            width: 150,
            child: imageFromBase64String(x.projection!.movie!.picture!),
          ),
          Column(
            children: [
              Text("${x.projection!.movie!.name}",
                  style: Theme.of(context).textTheme.headline5),
              SizedBox(
                height: 10,
              ),
              Text(
                "${x.projection!.movie!.director}",
                style: TextStyle(
                    color: Colors.red[900],
                    fontWeight: FontWeight.bold,
                    fontSize: 12),
              ),
              Text(
                "${x.projection!.movie!.genres}",
                style: TextStyle(
                    color: Colors.red[900],
                    fontWeight: FontWeight.bold,
                    fontSize: 12),
              ),
              Text(
                "${x.projection!.startTime.toString()}",
                style: TextStyle(
                    color: Colors.red[900],
                    fontWeight: FontWeight.bold,
                    fontSize: 12),
              )
            ],
          ),
        ],
      ),
    );
  }
}
