using eCinema.Model.Dtos;
using eCinema.Model.SearchObjects;
using eCinema.WinUI.Reports;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Data;

namespace eCinema.WinUI
{
    public partial class frmReservations : Form
    {
        private APIService _reservationService = new APIService("Reservation");
        private int _selectedPage;
        private const int _pageSize = 10;

        public frmReservations()
        {
            InitializeComponent();
            _selectedPage = 0;
            dgvReservations.AutoGenerateColumns = false;
            loadingPictureBox.Hide();
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            await LoadData();

        }

        private async Task LoadData()
        {
            btnShow.Enabled = false;

            loadingPictureBox.Show();
            loadingPictureBox.Update();

            var searchObject = new ReservationSearchObject
            {
                Name = txtMovie.Text,
                User = txtUser.Text,
                DateTime = dtpDate.Value,
                IncludeUsers = true,
                IncludeProjection = true,
                IncludeMovies = true,
                IncludePayments = true,
                IncludePrices = true,
                PageSize = _pageSize,
                Page = _selectedPage,
            };

            var list = await _reservationService.Get<List<ReservationDto>>(searchObject);
            loadingPictureBox.Hide();
            btnShow.Enabled = true;


            if (list.Any() || _selectedPage == 0)
            {
                dgvReservations.DataSource = list;
            }
            else
            {
                MessageBox.Show("Nema više stranica!");
                _selectedPage--;
            }
        }

        private void dgvReservations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var reservation = (ReservationDto)(this.dgvReservations.Rows[e.RowIndex]
                    .DataBoundItem);

                if (reservation is not null)
                {
                    if (reservation.User is not null && e.ColumnIndex == 0)
                    {
                        e.Value = $"{reservation.User.FirstName} {reservation.User.LastName}";
                    }
                    if (reservation.Projection?.Movie is not null && e.ColumnIndex == 2)
                    {
                        e.Value = reservation.Projection.Movie.Name;
                    }
                    if (reservation.Projection?.Price is not null && e.ColumnIndex == 3)
                    {
                        e.Value = reservation.Projection.Price.Value;
                    }
                    if (reservation.Payment is not null && e.ColumnIndex == 4)
                    {
                        e.Value = reservation.Payment.Amount;
                    }
                    if (reservation.Projection is not null && e.ColumnIndex == 5)
                    {
                        e.Value = reservation.Projection.StartTime.ToString();
                    }
                }
            }
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_selectedPage == 0)
            {
                MessageBox.Show("Nema više prethodnih stranica!");
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

        private void frmReservations_Load(object sender, EventArgs e)
        {

        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            frmReportOptions frmReportOptions = new frmReportOptions();
            frmReportOptions.Show();
        }
    }
}
