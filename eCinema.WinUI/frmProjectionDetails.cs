﻿using eCinema.Model.Constants;
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
                //cmbProjectionType.Enabled = false;
                dtpProjectionDateTime.Enabled = false;
                dtpEndTime.Enabled = false;
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
                //cmbProjectionType.Enabled = false;
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
            cmbPrice.DisplayMember = "Name";
            cmbPrice.ValueMember = "Id";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var upsert = new ProjectionUpsertRequest()
                {
                    StartTime = dtpProjectionDateTime.Value,
                    EndTime = dtpEndTime.Value,
                    HallId = (Guid)cmbHall?.SelectedValue,
                    PriceId = (Guid)cmbPrice?.SelectedValue,
                    MovieId = (Guid?)cmbMovieName?.SelectedValue,
                };

                if (_model is null)
                {
                    await _projectionService.Post<ProjectionDto>(upsert);
                    MessageBox.Show("Projekcija dodana.");
                    var frmProjection = new frmProjection();
                    frmProjection.MdiParent = this.MdiParent;
                    frmProjection.StartPosition = FormStartPosition.CenterScreen;
                    frmProjection.WindowState = FormWindowState.Maximized;
                    this.Close();
                    frmProjection.Show();
                }
                else
                {
                    _model = await _projectionService.Put<ProjectionDto>(_model.Id, upsert);
                    MessageBox.Show("Projekcija uređena.");
                    this.Close();
                }
            }
            
        }

        private async void btnActivate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                loadingPictureBox.Show();
                loadingPictureBox.Update();

                var upsert = new ProjectionUpsertRequest()
                {
                    StartTime = dtpProjectionDateTime.Value,
                    EndTime = dtpEndTime.Value,
                    HallId = (Guid)cmbHall?.SelectedValue,
                    PriceId = (Guid)cmbPrice?.SelectedValue,
                    MovieId = (Guid?)cmbMovieName?.SelectedValue,
                };

                await _projectionService.Put<ProjectionDto>(_model.Id, upsert);
                await _projectionService.Activate<ProjectionDto>(_model.Id, upsert);
                loadingPictureBox.Hide();

                MessageBox.Show("Projekcija aktivirana.");
                this.Close();
            }
        }

        private async void btnHide_ClickAsync(object sender, EventArgs e)
        {
            loadingPictureBox.Show();
            loadingPictureBox.Update();

            var upsert = new ProjectionUpsertRequest()
            {
                StartTime = dtpProjectionDateTime.Value,
                EndTime = dtpEndTime.Value,
                HallId = (Guid)cmbHall?.SelectedValue,
                PriceId = (Guid)cmbPrice?.SelectedValue,
                MovieId = (Guid?)cmbMovieName?.SelectedValue,
            };

            try
            {
                await _projectionService.Hide<ProjectionDto>(_model.Id, upsert);
                loadingPictureBox.Hide();

                MessageBox.Show("Projekcija skrivena.");
            }
            catch
            {
                MessageBox.Show("Ova projekcija ima aktivnih rezervacija!");
            }
            this.Close();
        }

        private void cmbMovieName_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateComboBox(cmbMovieName, e, "Naziv", errorProvider);
        }

        private void cmbHall_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateComboBox(cmbHall, e, "Sala", errorProvider);

        }

        private void cmbPrice_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateComboBox(cmbPrice, e, "Cijena", errorProvider);

        }

        private void dtpProjectionDateTime_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateDateTime(dtpProjectionDateTime, e, "Početno vrijeme", errorProvider, true, dtpEndTime);

        }

        private void dtpEndTime_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateDateTime(dtpEndTime, e, "Završno vrijeme", errorProvider, false, dtpProjectionDateTime);

        }
    }
}
