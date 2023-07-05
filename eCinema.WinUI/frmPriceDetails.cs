using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCinema.WinUI
{
    public partial class frmPriceDetails : Form
    {
        private APIService _priceService = new APIService("Price");

        public frmPriceDetails(PriceDto model = null)
        {
            InitializeComponent();
            _model = model;
        }

        private PriceDto _model;

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var upsert = new PriceUpsertRequest()
                {
                    Name = txtName.Text,
                    Value = Convert.ToDecimal(txtPrice.Text),
                };

                if (_model is null)
                {
                    await _priceService.Post<PriceDto>(upsert);
                    MessageBox.Show("Cijena dodana.");
                    var frmPrices = new frmPrices();
                    frmPrices.MdiParent = this.MdiParent;
                    frmPrices.StartPosition = FormStartPosition.CenterScreen;
                    frmPrices.WindowState = FormWindowState.Maximized;
                    this.Close();
                    frmPrices.Show();
                }
                else
                {
                    _model = await _priceService.Put<PriceDto>(_model.Id, upsert);
                    MessageBox.Show("Cijena uređena.");
                    this.Close();

                }
            }
        }

        private void frmPriceDetails_Load(object sender, EventArgs e)
        {
            if (_model is not null)
            {
                txtName.Text = _model.Name;
                txtPrice.Text = _model.Value.ToString();
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtName, e, "Naziv", errorProvider, false, 3);

        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtPrice, e, "Vrijednost", errorProvider);
            if (!IsNumber(txtPrice.Text))
            {
                e.Cancel = true;
                txtPrice.Focus();
                errorProvider.SetError(txtPrice, "Vrijednost mora biti brojčana.");
            }

        }

        bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }
    }
}
