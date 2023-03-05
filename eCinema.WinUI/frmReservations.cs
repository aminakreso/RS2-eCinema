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
    public partial class frmReservations : Form
    {
        private APIService _reservationService = new APIService("Reservation");

        public frmReservations()
        {
            InitializeComponent();
            dgvReservations.AutoGenerateColumns = false;
        }

        private void frmReservations_Load(object sender, EventArgs e)
        {
         
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            var searchObject = new ReservationSearchObject
            {
                Name = txtMovie.Text,
                User = txtUser.Text,
                DateTime = dtpDate.Value,
                IncludeUsers = true,
                IncludeProjection = true,
                IncludeMovies = true,
                IncludePayments = true,
                IncludePrices = true
            };

            var list = await _reservationService.Get<List<ReservationDto>>(searchObject);
            dgvReservations.DataSource = list;
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

                    if (reservation.Projection is not null && e.ColumnIndex == 1)
                    {
                        e.Value = reservation.Projection.StartTime.ToString();
                    }

                    if (reservation.Projection?.Movie is not null && e.ColumnIndex == 2)
                    {
                        e.Value = reservation.Projection.Movie.Name;
                    }
                    if (reservation.Projection?.Price is not null && e.ColumnIndex == 3)
                    {
                        e.Value = reservation.Projection.Price.Name;
                    }
                    if (reservation.Payment is not null && e.ColumnIndex == 4)
                    {
                        e.Value = reservation.Payment.Amount;
                    }
                }
            }
        }
    }
}
