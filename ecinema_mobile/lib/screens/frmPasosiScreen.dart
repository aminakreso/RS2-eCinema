import 'package:ecinema_mobile/models/fitPasos.dart';
import 'package:ecinema_mobile/models/user.dart';
import 'package:ecinema_mobile/providers/fitPasosProvider.dart';
import 'package:ecinema_mobile/providers/userProvider.dart';
import 'package:ecinema_mobile/screens/frmPasosNoviScreen.dart';
import 'package:ecinema_mobile/screens/loadingScreen.dart';
import 'package:ecinema_mobile/wigdets/headerWidget.dart';
import 'package:ecinema_mobile/wigdets/master_screen.dart';
import 'package:ecinema_mobile/wigdets/movieCardLine.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class FrmPasosiScreen extends StatefulWidget {
  const FrmPasosiScreen({super.key});
  static const String routeName = "/frmPasosi";

  @override
  State<FrmPasosiScreen> createState() => _FrmPasosiScreenState();
}

class _FrmPasosiScreenState extends State<FrmPasosiScreen> {
  FITPasosProvider? _fitPasosProvider = null;

  List<FITPasos>? _pasosi = null;
  User? _user = null;

  TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _fitPasosProvider = context.read<FITPasosProvider>();

    loadData();
  }

  Future loadData() async {
    var pasosi = await _fitPasosProvider?.get({'IncludeUsers': true});
    setState(() {
      _pasosi = pasosi;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (_pasosi == null || _pasosi == []) {
      loadData();
      return LoadingScreen();
    } else {
      return MasterScreenWidget(
          child: Column(
        children: [
          Row(
            children: [
              HeaderWidget(title: "Pasosi"),
              TextButton(
                  onPressed: () {
                    Navigator.pushNamed(context, FrmPasosNoviScreen.routeName);
                  },
                  child: Text("Dodaj pasoš")),
            ],
          ),
          Container(
            margin: EdgeInsets.all(8),
            height: 50,
            child: TextField(
                controller: _searchController,
                decoration: const InputDecoration(
                    labelText: "Naziv",
                    hintStyle:
                        TextStyle(fontSize: 20.0, fontWeight: FontWeight.bold)),
                onSubmitted: (value) async {
                  var tmpData = await _fitPasosProvider
                      ?.get({'User': _searchController.text});
                  setState(() {
                    _pasosi = tmpData!;
                  });
                }),
          ),
          Expanded(
            child: ListView.builder(
              itemCount: _pasosi?.length,
              itemBuilder: (BuildContext context, int index) {
                return _buildPasosCard(_pasosi![index]);
              },
            ),
          ),
        ],
      ));
    }
  }
}

Widget _buildPasosCard(FITPasos x) {
  return SingleChildScrollView(
    scrollDirection: Axis.horizontal,
    child: Card(
      child: Row(
        children: [
          Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Text("${x.value}"),
              SizedBox(
                height: 20,
              ),
              MovieCardLine(
                  label: "User :", text: x.user?.firstName.toString()),
              MovieCardLine(label: "Issue date:", text: x.issueDate.toString()),
              MovieCardLine(
                  label: "Expiration date:", text: x.expirationDate.toString()),
            ],
          ),
        ],
      ),
    ),
  );
}
