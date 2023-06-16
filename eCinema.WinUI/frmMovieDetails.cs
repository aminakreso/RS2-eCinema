using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eCinema.WinUI.Helpers;
using eCinema.Model.Constants;

namespace eCinema.WinUI
{
    public partial class frmMovieDetails : Form
    {
        private APIService _movieService = new APIService("Movie");
        public frmMovieDetails(MovieDto model = null)
        {
            InitializeComponent();
            _model = model;
        }

        private MovieDto _model = null;
        private bool isPressed = false;
        private async void frmMovieDetails_Load(object sender, EventArgs e)
        {
            if (_model is not null)
            {
                txtName.Text = _model.Name;
                
                for (int count = 0; count < clbGenres.Items.Count; count++)
                {
                    if (_model.Genres.Contains(clbGenres.Items[count].ToString()))
                    {
                        clbGenres.SetItemChecked(count, true);
                    }
                }
                txtReleaseYear.Text = _model.ReleaseYear.ToString();
                txtDuration.Text = _model.Duration.ToString();
                txtDirector.Text = _model.Director;
                txtDescription.Text = _model.Description;
                txtCountry.Text = _model.Country;
                txtActors.Text = _model.Actors;
                if(_model.Picture != null)
                    pbPicture.Image = ImageHelper.FromByteToImage(_model.Picture);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if(pbPicture.Image != null)
                {
                    errorProvider.SetError(pbPicture, "");
                    errorProvider.Clear();
                }
                else
                {
                    pbPicture.Focus();
                    errorProvider.SetError(pbPicture, "You must upload movie image!");
                    return;

                }
                var genreList = "";
                foreach (var genre in Genres.ListOfGenres)
                {
                    if (clbGenres.CheckedItems.Contains(genre))
                        genreList += genre + ", ";
                }
                var upsert = new MovieUpsertRequest()
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Actors = txtActors.Text,
                    Director = txtDirector.Text,
                    Country = txtDirector.Text,
                    Genres = genreList,
                    Duration = Convert.ToInt32(txtDuration?.Text),
                    ReleaseYear = Convert.ToInt32(txtReleaseYear?.Text)

                };
                if (!isPressed && _model!=null)
                    upsert.Picture = _model.Picture;
                else 
                    upsert.Picture = ImageHelper.FromImageToBase64(pbPicture.Image);

                if (_model is null)
                {
                    await _movieService.Post<MovieDto>(upsert);
                    MessageBox.Show("Movie added.");
                    var frmMovies = new frmMovies();
                    frmMovies.MdiParent = this.MdiParent;
                    frmMovies.StartPosition = FormStartPosition.CenterScreen;
                    frmMovies.WindowState = FormWindowState.Maximized;
                    this.Close();
                    frmMovies.Show();
                }
                else
                {
                    _model = await _movieService.Put<MovieDto>(_model.Id, upsert);
                    MessageBox.Show("Movie edited.");
                    this.Close();
                }
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdPicture.FileName);
                isPressed = true;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtName, e, "Name", errorProvider);
        }

        private void txtDirector_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtDirector, e, "Director", errorProvider);

        }

        private void txtDuration_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtDuration, e, "Duration", errorProvider, true);

        }

        private void txtReleaseYear_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtReleaseYear, e, "ReleaseYear", errorProvider, true);

        }

        private void txtCountry_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtCountry, e, "Country", errorProvider);

        }

        private void txtGenres_Validating(object sender, CancelEventArgs e)
        {
            //ValidationHelper.ValidateRichTextBox(txtGenres, e, "Genres", errorProvider);

        }

        private void txtActors_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateRichTextBox(txtActors, e, "Actors", errorProvider);

        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateRichTextBox(txtDescription, e, "Description", errorProvider);
        }
    }
}
