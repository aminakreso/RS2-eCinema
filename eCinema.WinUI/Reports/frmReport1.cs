using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportDataSource = Microsoft.Reporting.WinForms.ReportDataSource;

namespace eCinema.WinUI.Reports
{
    public partial class frmReport1 : Form
    {
        private List<Model.Dtos.ReservationDto> _data { get; set; }
        public frmReport1(List<Model.Dtos.ReservationDto> data)
        {
            InitializeComponent();
            _data = data;
        }

        private void frmReport1_Load(object sender, EventArgs e)
        {
            report1ds.RezervacijeDataTable rezervacije = new report1ds.RezervacijeDataTable();
            foreach (var r in _data)
            {
                var red = rezervacije.NewRezervacijeRow();
                red.Korisnik = r.User.FullName;
                red.DatumRezervacije = r.DateTime.ToString();
                red.TipProjekcije = r.Projection?.PriceName;
                red.Iznos = r.Payment.Amount.ToString();
                red.Film = r.Projection?.Movie.Name;
                red.PocetakProjekcije = r.Projection?.StartTime.ToString();

                rezervacije.Rows.Add(red);
            }
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = rezervacije;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "eCinema.WinUI.Reports.Report1.rdlc";

            // Refresh the report viewer control
            reportViewer1.RefreshReport();
        }
    }
}
