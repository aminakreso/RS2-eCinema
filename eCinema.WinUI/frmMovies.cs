using eCinema.Model.Constants;
using eCinema.Model.Dtos;
using eCinema.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCinema.WinUI
{
    public partial class frmMovies : Form
    {
        private APIService _movieService = new APIService("Movie");
        private int _totalPage;
        private int _selectedPage;
        private const int _pageSize = 5;

        public frmMovies()
        {
            InitializeComponent();
            dgvMovies.AutoGenerateColumns = false;
            _selectedPage = 0;
        }

        private async void frmMovies_Load(object sender, EventArgs e)
        {
            await LoadGenres();
            cmbGenre.SelectedItem = null;
            cmbGenre.SelectedText = "Svi";
            loadingPictureBox.Hide();
        }

        private async Task LoadGenres()
        {
            var genresList = Genres.ListOfGenres;
            cmbGenre.DataSource = genresList;
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            loadingPictureBox.Show();
            loadingPictureBox.Update();

            var searchObject = new MovieSearchObject();
            searchObject.Name = txtName.Text;
            searchObject.Director = txtDirector.Text;
            searchObject.Genres = cmbGenre.Text;
            searchObject.IsActive = true;
            searchObject.PageSize = _pageSize;
            searchObject.Page = _selectedPage;

            var list = await _movieService.Get<List<MovieDto>>(searchObject);

            loadingPictureBox.Hide();

            if (list.Any() || _selectedPage == 0)
            {
                dgvMovies.DataSource = list;
            }
            else
            {
                _selectedPage--;
                MessageBox.Show("There are no more pages!");
            }
        }

        private async void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var movie = dgvMovies.SelectedRows[0].DataBoundItem as MovieDto;

            var frmMovieDetails = new frmMovieDetails(movie);
            frmMovieDetails.ShowDialog();
            await LoadData();

        }

        private async void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            try
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    var movie = (MovieDto)(this.dgvMovies.Rows[e.RowIndex]
                       .DataBoundItem);

                    await _movieService.Delete<MovieDto>(movie.Id);
                }

                await LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There are active projections for selected movie!");
            }
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if(_selectedPage == 0)
            {
                MessageBox.Show("There are no previous pages!");
                return;
            }
            _selectedPage--;
            await LoadData();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            _selectedPage++;
            await LoadData();
        }
    }
}
