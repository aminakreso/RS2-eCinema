import 'dart:convert';
import 'dart:io';

import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../models/movie.dart';
import '../providers/movieProvider.dart';
import '../utils/util.dart';
import '../wigdets/master_screen.dart';
import 'movieDetailsScreen.dart';

class MovieListScreen extends StatefulWidget {
  static const String routeName = "/movie";

  const MovieListScreen({Key? key}) : super(key: key);

  @override
  State<MovieListScreen> createState() => _MovieListScreenState();
}

class _MovieListScreenState extends State<MovieListScreen> {
  MovieProvider? _movieProvider = null;
  List<Movie>? data = [];
  TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _movieProvider = context.read<MovieProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _movieProvider?.get(null);
    setState(() {
      data = tmpData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
        child: ListView.builder(
      itemCount: data?.length,
      itemBuilder: (BuildContext context, int index) {
        return _buildMovieCard(data![index]);
      },
    ));
  }

  Card _buildMovieCard(Movie x) {
    return Card(
      child: InkWell(
        onTap: () {
          Navigator.pushNamed(
              context, "${MovieDetailsScreen.routeName}/${x.id}");
        },
        child: Row(
          children: [
            Container(
              height: 150,
              width: 150,
              child: imageFromBase64String(x.picture!),
            ),
            Column(
              children: [
                Text("${x.name}", style: Theme.of(context).textTheme.headline5),
                SizedBox(
                  height: 20,
                ),
                movieCardLine("Duration:", x.duration.toString()),
                movieCardLine("Actors:", x.actors),
                movieCardLine("Director:", x.director.toString()),
                movieCardLine("Genres: ", x.genres.toString()),
                movieCardLine("Country:", x.country.toString()),
              ],
            ),
          ],
        ),
      ),
    );
  }

  RichText movieCardLine(String label, String? text) {
    return RichText(
      text: TextSpan(
        text: label,
        style: TextStyle(
            color: Colors.red[900], fontWeight: FontWeight.bold, fontSize: 12),
        children: <TextSpan>[
          TextSpan(
            text: '$text' ?? "",
            style: TextStyle(
                color: Colors.black,
                fontSize: 12,
                fontWeight: FontWeight.normal),
          ),
        ],
      ),
    );
  }
}
