using eCinema.Model.Constants;
using eCinema.Model.Dtos;
using eCinema.Model.SearchObjects;
using eCinema.WinUI.Helpers;
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
    public partial class frmProjection : Form
    {
        private APIService _projectionService = new APIService("Projection");
        private APIService _movieService = new APIService("Movie");
        private APIService _hallService = new APIService("Hall");

        public frmProjection()
        {
            InitializeComponent();
            dgvProjection.AutoGenerateColumns = false;
            loadingPictureBox.Hide();
        }


        private void dgvProjection_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var projection = (ProjectionDto)(this.dgvProjection.Rows[e.RowIndex]
                    .DataBoundItem);

               if(projection is not null)
                {
                    if (projection.Movie is not null && e.ColumnIndex == 0)
                    {
                        e.Value = projection.Movie.Name;
                    }

                    if (projection.Hall is not null && e.ColumnIndex == 2)
                    {
                        e.Value = projection.Hall.Name;
                    }

                    if (projection.Price is not null && e.ColumnIndex == 3)
                    {
                        e.Value = projection.Price.Name;
                    }
                }
            }
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            await LoadData(sender,e);
        }

        private async Task LoadData(object sender, EventArgs e)
        {
            loadingPictureBox.Show();
            loadingPictureBox.Update();
            
            var searchObject = new ProjectionSearchObject
            {
                StartDate = dtpDate.Value,
                IncludeHalls = true,
                IncludeMovies = true,
                IncludePrices = true
            };

            if (!string.IsNullOrEmpty(txtName.Text))
            {
                searchObject.Name = txtName.Text;
            }

            if (cmbHall.Text != "Svi")
            {
                searchObject.HallId = (Guid)cmbHall.SelectedValue;
            }

            if (cmbStatus.Text != "Svi")
            {
                searchObject.StateMachine = cmbStatus.SelectedValue.ToString();
            }

            var list = await _projectionService.Get<List<ProjectionDto>>(searchObject);

            dgvProjection.DataSource = list;

            loadingPictureBox.Hide();

        }

        private async void frmProjection_Load(object sender, EventArgs e)
        {
            await LoadHalls();
            await LoadStatus();

            cmbHall.SelectedItem = null;
            cmbHall.SelectedText = "Svi";
            cmbStatus.SelectedItem = null;
            cmbStatus.SelectedText = "Svi";
        }

        private async Task LoadHalls()
        {
            var halls = await _hallService.Get<List<HallDto>>();
            cmbHall.DataSource = halls;
            cmbHall.DisplayMember = "Name";
            cmbHall.ValueMember = "Id";
        }
        private async Task LoadStatus()
        {
            var projections = await _projectionService.Get<List<ProjectionDto>>();
            projections = projections.DistinctBy(x => x.StateMachine).ToList();
            cmbStatus.DataSource = projections;
            cmbStatus.DisplayMember = "StateMachine";
            cmbStatus.ValueMember = "StateMachine";
        }

        private async void dgvProjection_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var projection = dgvProjection.SelectedRows[0].DataBoundItem as ProjectionDto;

            var frmProjectionDetails = new frmProjectionDetails(projection);
            frmProjectionDetails.ShowDialog();
            await LoadData(sender, e);
        }
    }
}
