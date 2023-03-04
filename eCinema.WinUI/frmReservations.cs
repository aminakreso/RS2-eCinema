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
            };

            var list = await _reservationService.Get<List<ReservationDto>>(searchObject);
            dgvReservations.DataSource = list;
        }
    }
}
