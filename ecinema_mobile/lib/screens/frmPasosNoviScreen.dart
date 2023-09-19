import 'package:ecinema_mobile/models/fitPasos.dart';
import 'package:ecinema_mobile/models/user.dart';
import 'package:ecinema_mobile/providers/fitPasosProvider.dart';
import 'package:ecinema_mobile/providers/userProvider.dart';
import 'package:ecinema_mobile/screens/frmPasosiScreen.dart';
import 'package:ecinema_mobile/screens/loadingScreen.dart';
import 'package:ecinema_mobile/wigdets/datePicker.dart';
import 'package:ecinema_mobile/wigdets/headerWidget.dart';
import 'package:ecinema_mobile/wigdets/master_screen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class FrmPasosNoviScreen extends StatefulWidget {
  const FrmPasosNoviScreen({super.key});
  static const String routeName = "/frmPasosNovi";

  @override
  State<FrmPasosNoviScreen> createState() => _FrmPasosNoviScreenState();
}

//validacija!
class _FrmPasosNoviScreenState extends State<FrmPasosNoviScreen> {
  UserProvider? _userProvider = null;
  FITPasosProvider? _fitPasosProvider = null;
  bool isChecked = false;
  List<User>? _userList = null;
  List<FITPasos>? _pasosList = null;
  List<String>? _userNames = null;
  DateTime date = DateTime.now();
  String? _dropdownValue = null;

  @override
  void initState() {
    super.initState();
    _userProvider = context.read<UserProvider>();
    _fitPasosProvider = context.read<FITPasosProvider>();

    loadData();
  }

  Future loadData() async {
    var tmpData = await _userProvider?.get(null);
    var tmpPasos = await _fitPasosProvider?.get(null);

    setState(() {
      _userList = tmpData;
      _pasosList = tmpPasos;
      if (_userList != null && _pasosList != null) {
        _userNames = _userList
            ?.where(
                (user) => !_pasosList!.any((pasos) => pasos.userId == user.id))
            .map((user) => user.firstName!)
            .toList();
        if (_userNames?.length != 0) _dropdownValue = _userNames?.first;
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    if (_userList == null || _pasosList == null) {
      loadData();
      return LoadingScreen();
    } else {
      return MasterScreenWidget(
          child: SingleChildScrollView(
        child: Column(
          children: [
            HeaderWidget(title: "Dodaj pasos"),
            Padding(
              padding: const EdgeInsets.all(8.0),
              child: _buildDropdown(),
            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.start,
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                Checkbox(
                    value: isChecked,
                    onChanged: (value) {
                      setState(() {
                        isChecked = value!;
                      });
                    }),
                Text("Validan")
              ],
            ),
            TextButton(
              onPressed: () async {
                final DateTime? picked = await datePicker(context);
                if (picked != null && picked != date) {
                  setState(() {
                    date = picked;
                  });
                }
              },
              child: const Text('Odaberi datum'),
            ),
            if (_userNames!.isNotEmpty)
              TextButton(
                  onPressed: () async {
                    try {
                      var selectedId = _userList
                          ?.where(
                              (u) => u.firstName == _dropdownValue.toString())
                          .first
                          .id;

                      await _fitPasosProvider?.insert({
                        'UserId': selectedId,
                        'Value': "225883",
                        'IssueDate': DateTime.now().toIso8601String(),
                        'ExpirationDate': date.toIso8601String(),
                        'IsValid': isChecked
                      });
                      Navigator.pushNamed(context, FrmPasosiScreen.routeName);
                    } catch (e) {
                      showDialog(
                          context: context,
                          builder: (BuildContext context) => AlertDialog(
                                title: const Text("Error"),
                                content: Text(e.toString()),
                                actions: [
                                  TextButton(
                                    child: const Text("Ok"),
                                    onPressed: () => Navigator.pop(context),
                                  )
                                ],
                              ));
                    }
                  },
                  child: const Text('Spasi'))
            else
              const Text("Nema"),
            Text("Datum: ${date.day}/${date.month}/${date.year}")
          ],
        ),
      ));
    }
  }

  DropdownButton<String> _buildDropdown() {
    return DropdownButton<String>(
      hint: const Text("Korisnici"),
      value: _dropdownValue,
      onChanged: (String? value) {
        setState(() {
          _dropdownValue = value.toString();
        });
      },
      items: _userNames?.map((String value) {
        return DropdownMenuItem<String>(
          value: value,
          child: Text(value.toString()),
        );
      }).toList(),
    );
  }
}
