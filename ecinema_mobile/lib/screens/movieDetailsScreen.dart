import 'package:ecinema_mobile/models/projection.dart';
import 'package:ecinema_mobile/providers/projectionProvider.dart';
import 'package:ecinema_mobile/screens/seatSelectionScreen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../models/movie.dart';
import '../providers/movieProvider.dart';
import '../utils/util.dart';
import '../wigdets/master_screen.dart';
import '../wigdets/movieCardLine.dart';
import 'loadingScreen.dart';

class MovieDetailsScreen extends StatefulWidget {
  static const String routeName = "/movie_details";
  String id;

  MovieDetailsScreen(this.id, {Key? key}) : super(key: key);

  @override
  State<MovieDetailsScreen> createState() => _MovieDetailsScreenState();
}

class _MovieDetailsScreenState extends State<MovieDetailsScreen> {
  MovieProvider? _movieProvider = null;
  ProjectionProvider? _projectionProvider = null;

  Movie? movie = null;
  List<Projection>? movieProjection = null;
  List<String>? movieProjectionDates = null;

  TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _movieProvider = context.read<MovieProvider>();
    _projectionProvider = context.read<ProjectionProvider>();

    loadData().then((movie) {
      setState(() {
        this.movie = movie;
      });
    });

    loadProjections().then((movieProjection) {
      setState(() {
        this.movieProjection = movieProjection;
        loadProjectionsDates();
      });
    });
  }

  Future loadData() async {
    var movie = await _movieProvider?.getById(this.widget.id);
    return movie;
  }

  Future loadProjections() async {
    var searchRequest = {'Name': movie?.name};
    var movieProjection = await _projectionProvider?.get(searchRequest);
    return movieProjection;
  }

  Future loadProjectionsDates() async {
    List<String>? movieProjectionDates =
        movieProjection?.map((x) => getDate(x.startTime!)).toSet().toList();
    setState(() {
      this.movieProjectionDates = movieProjectionDates;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (movie == null ||
        movieProjection == null ||
        movieProjectionDates == null) {
      loadData();
      return LoadingScreen();
    } else {
      return MasterScreenWidget(
          child: Column(
        children: [
          Container(
            height: 200,
            child: imageFromBase64String(movie!.picture!),
          ),
          MovieCardLine(label: 'Duration', text: movie!.duration.toString()),
          MovieCardLine(label: 'Actors', text: movie!.actors),
          MovieCardLine(label: 'Director', text: movie!.director),
          MovieCardLine(label: 'Genres', text: movie!.genres),
          MovieCardLine(label: 'Country', text: movie!.country),
          Container(
            height: 300,
            child: ListView.builder(
                itemCount: movieProjectionDates?.length,
                itemBuilder: (BuildContext context, int index) {
                  return _buildProjectionCard(movieProjectionDates![index]);
                }),
          )
        ],
      ));
    }
  }

  Widget _buildProjectionCard(String date) {
    return Card(
        child: Container(
            height: 100,
            child: Column(
              children: [
                Text(
                  date,
                  style: Theme.of(context).textTheme.bodyText1,
                ),
                Row(
                  children: _createTimeButtonsList(date),
                )
              ],
            )));
  }

  List<Widget> _createTimeButtonsList(String date) {
    List<Projection?>? list =
        movieProjection?.where((x) => getDate(x.startTime) == date).toList();

    if (list == null) {
      Text text = Text("No available projections",
          style: Theme.of(context).textTheme.headline2);
      List<Text> list = List.empty();
      list.add(text);
      return list;
    }

    List<Widget> newList = list
        .map((x) => Container(
              padding: EdgeInsets.all(8.0),
              child: InkWell(
                onTap: () {
                  Navigator.pushNamed(
                      context, "${SeatSelectionScreen.routeName}/${x?.id}");
                },
                child: Text(
                  getTime(x?.startTime),
                  style: Theme.of(context).textTheme.bodyText1,
                ),
              ),
            ))
        .cast<Widget>()
        .toList();

    return newList;
  }
}
