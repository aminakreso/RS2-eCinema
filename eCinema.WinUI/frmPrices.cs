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
   
    public partial class frmPrices : Form
    {
        private APIService _priceService = new APIService("Price");

        public frmPrices()
        {
            InitializeComponent();
            dgvPrices.AutoGenerateColumns = false;

        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            var searchObject = new PriceSearchObject();
            searchObject.Name = txtName.Text;

            var list = await _priceService.Get<List<PriceDto>>(searchObject);
            dgvPrices.DataSource = list;
        }

        private void dgvPrices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var price = dgvPrices.SelectedRows[0].DataBoundItem as PriceDto;

            var frmPriceDetails = new frmPriceDetails(price);
            frmPriceDetails.ShowDialog();
        }
    }
}
