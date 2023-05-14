using eCinema.Model.Constants;
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

namespace eCinema.WinUI
{
    public partial class frmProjectionDetails : Form
    {
        private APIService _projectionService = new APIService("Projection");
        private APIService _movieService = new APIService("Movie");
        private APIService _hallService = new APIService("Hall");
        private APIService _priceService = new APIService("Price");

        public frmProjectionDetails(ProjectionDto model = null)
        {
            InitializeComponent();
            _model = model;
            loadingPictureBox.Hide();

        }

        private async void frmProjectionDetails_Load(object sender, EventArgs e)
        {
            loadingPictureBox.Show();
            loadingPictureBox.Update();

            await LoadHalls();
            await LoadMovies();
            await LoadPrices();
            await LoadTypes();

            dtpProjectionDateTime.Format = DateTimePickerFormat.Custom;
            dtpProjectionDateTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            if (_model is not null)
            {
                cmbHall.SelectedValue = _model.HallId;
                cmbMovieName.SelectedValue = _model.MovieId;
                cmbPrice.SelectedValue = _model.PriceId;
                dtpProjectionDateTime.Value = _model.StartTime.Value;
                dtpEndTime.Value = _model.EndTime.Value;
            }
            LoadButtons();
            loadingPictureBox.Hide();
        }

        private void LoadButtons()
        {
            if(_model?.StateMachine is null)
            {
                btnActivate.Visible = false;
                btnHide.Visible = false;

            }

            if (_model?.StateMachine == StateMachineConstants.DraftState)
            {
                btnHide.Visible = false;
            }

            if (_model?.StateMachine == StateMachineConstants.ActiveState)
            {
                btnActivate.Visible = false;
                btnSave.Visible = false;
                cmbHall.Enabled = false;
                cmbMovieName.Enabled = false;
                cmbPrice.Enabled = false;
                cmbProjectionType.Enabled = false;
                dtpProjectionDateTime.Enabled = false;
            }

            if (_model?.StateMachine == StateMachineConstants.HiddenState)
            {
                btnHide.Visible = false;
            }

            if (_model?.StateMachine == StateMachineConstants.DeletedState)
            {
                btnActivate.Visible = false;
                btnHide.Visible=false;
                btnSave.Visible = false;
                cmbHall.Enabled = false;
                cmbMovieName.Enabled = false;
                cmbPrice.Enabled = false;
                cmbProjectionType.Enabled = false;
                dtpProjectionDateTime.Enabled = false;
            }

        }

        private ProjectionDto _model = null;

        private async Task LoadHalls()
        {
            var halls = await _hallService.Get<List<HallDto>>();
            cmbHall.DataSource = halls;
            cmbHall.DisplayMember = "Name";
            cmbHall.ValueMember = "Id";
        }

        private async Task LoadMovies()
        {
            var movies = await _movieService.Get<List<MovieDto>>();
            cmbMovieName.DataSource = movies;
            cmbMovieName.DisplayMember = "Name";
            cmbMovieName.ValueMember = "Id";
        }

        private async Task LoadPrices()
        {
            var prices = await _priceService.Get<List<PriceDto>>();
            cmbPrice.DataSource = prices;
            cmbPrice.DisplayMember = "Value";
            cmbPrice.ValueMember = "Id";
        }
        private async Task LoadTypes()
        {
            cmbProjectionType.DataSource = ProjectionTypes.ListTypes;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var upsert = new ProjectionUpsertRequest()
                {
                    StartTime = dtpProjectionDateTime.Value,
                    EndTime = dtpEndTime.Value,
                    ProjectionType = cmbProjectionType.Text,
                    HallId = (Guid)cmbHall?.SelectedValue,
                    PriceId = (Guid)cmbPrice?.SelectedValue,
                    MovieId = (Guid?)cmbMovieName?.SelectedValue,
                };

                if (_model is null)
                {
                    await _projectionService.Post<ProjectionDto>(upsert);
                    MessageBox.Show("Projection added.");
                    this.Close();
                }
                else
                {
                    _model = await _projectionService.Put<ProjectionDto>(_model.Id, upsert);
                    MessageBox.Show("Projection edited.");
                    this.Close();
                }
            }
            
        }

        private async void btnActivate_Click(object sender, EventArgs e)
        {
            var upsert = new ProjectionUpsertRequest()
            {
                StartTime = dtpProjectionDateTime.Value,
                ProjectionType = cmbProjectionType.Text,
                HallId = (Guid)cmbHall?.SelectedValue,
                PriceId = (Guid)cmbPrice?.SelectedValue,
                MovieId = (Guid?)cmbMovieName?.SelectedValue,
            };

            await _projectionService.Activate<ProjectionDto>(_model.Id, upsert);
            MessageBox.Show("Projection activated.");
            this.Close();
        }

        private async void btnHide_ClickAsync(object sender, EventArgs e)
        {
            var upsert = new ProjectionUpsertRequest()
            {
                StartTime = dtpProjectionDateTime.Value,
                ProjectionType = cmbProjectionType.Text,
                HallId = (Guid)cmbHall?.SelectedValue,
                PriceId = (Guid)cmbPrice?.SelectedValue,
                MovieId = (Guid?)cmbMovieName?.SelectedValue,
            };

            try
            {
                await _projectionService.Hide<ProjectionDto>(_model.Id, upsert);
                MessageBox.Show("Projection hidden.");
            }
            catch
            {
                MessageBox.Show("This projection has active reservations!");
            }
            this.Close();
        }

        private void cmbMovieName_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateComboBox(cmbMovieName, e, "Movie name", errorProvider);
        }

        private void cmbHall_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateComboBox(cmbHall, e, "Hall name", errorProvider);

        }

        private void cmbPrice_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateComboBox(cmbPrice, e, "Price name", errorProvider);

        }

        private void cmbProjectionType_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateComboBox(cmbProjectionType, e, "Projection type", errorProvider);
        }

        private void dtpProjectionDateTime_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateDateTime(dtpProjectionDateTime, e, "Start date", errorProvider, true, dtpEndTime);

        }

        private void dtpEndTime_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateDateTime(dtpEndTime, e, "End date", errorProvider, false, dtpProjectionDateTime);

        }
    }
}
