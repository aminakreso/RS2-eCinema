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
            await LoadData();
        }

        private async Task LoadData()
        {
            var searchObject = new PriceSearchObject();
            searchObject.Name = txtName.Text;
            searchObject.IsActive = true;

            var list = await _priceService.Get<List<PriceDto>>(searchObject);
            dgvPrices.DataSource = list;
        }

        private async void dgvPrices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var price = dgvPrices.SelectedRows[0].DataBoundItem as PriceDto;

            var frmPriceDetails = new frmPriceDetails(price);
            frmPriceDetails.ShowDialog();
            await LoadData();
        }

        private async void dgvPrices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    var price = (PriceDto)(this.dgvPrices.Rows[e.RowIndex]
                       .DataBoundItem);

                    await _priceService.Delete<PriceDto>(price.Id);
                }

                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Postoje aktivne projekcije za odabranu cijenu!");

            }
        }
    }
}
