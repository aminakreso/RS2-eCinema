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

        private int _selectedPage;
        private const int _pageSize = 5;

        public frmProjection()
        {
            InitializeComponent();
            _selectedPage = 0;
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
                        e.Value = projection.Price.Value;
                    }
                }
            }
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            loadingPictureBox.Show();
            loadingPictureBox.Update();
            
            var searchObject = new ProjectionSearchObject
            {
                StartDate = dtpDate.Value,
                IncludeHalls = true,
                IncludeMovies = true,
                IncludePrices = true,
                PageSize = _pageSize,
                Page = _selectedPage,
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

            loadingPictureBox.Hide();

            if (list.Any() || _selectedPage == 0)
            {
                dgvProjection.DataSource = list;
            }
            //else if (_selectedPage == 0) { }
            else
            {
               _selectedPage--;
               MessageBox.Show("There are no more pages!");
               
            }

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
            var list = new List<HallDto>
            {
                new HallDto { Name = "Svi" }
            };
            var halls = await _hallService.Get<List<HallDto>>();
            list.AddRange(halls);
            cmbHall.DataSource = list;
            cmbHall.DisplayMember = "Name";
            cmbHall.ValueMember = "Id";
        }
        private async Task LoadStatus()
        {
            var list = new List<ProjectionDto>
            {
                new ProjectionDto { StateMachine = "Svi" }
            };
            var projections = await _projectionService.Get<List<ProjectionDto>>();
            projections = projections.DistinctBy(x => x.StateMachine).ToList();
            list.AddRange(projections);

            cmbStatus.DataSource = list;
            cmbStatus.DisplayMember = "StateMachine";
            cmbStatus.ValueMember = "StateMachine";
        }

        private async void dgvProjection_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var projection = dgvProjection.SelectedRows[0].DataBoundItem as ProjectionDto;

            var frmProjectionDetails = new frmProjectionDetails(projection);
            frmProjectionDetails.ShowDialog();
            await LoadData();
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_selectedPage == 0)
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
