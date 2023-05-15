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
    public partial class frmReport2 : Form
    {
        public List<Model.Dtos.ProjectionDto> _data { get; set; }
        public List<Model.Dtos.ReservationDto> _reservations { get; set; }
        public frmReport2(List<Model.Dtos.ProjectionDto> data, List<Model.Dtos.ReservationDto> reservations)
        {
            InitializeComponent();
            _data = data;
            _reservations = reservations;
        }

        //table.AddCell(projection.Movie.Name);
        //        table.AddCell(projection.Price.Value.ToString());
        //        table.AddCell(reservations.Where(x => x.ProjectionId == projection.Id).Count().ToString());
        //        int reservationPerProjectionCount = reservations.Where(x => x.ProjectionId == projection.Id).Count();
        //ukupniPrihodi += projection!.Price!.Value! * reservationPerProjectionCount;
        //        table.AddCell((projection.Price.Value* reservationPerProjectionCount).ToString());
        private void frmReport2_Load(object sender, EventArgs e)
        {
            report1ds.ProjekcijeDataTable rezervacije = new report1ds.ProjekcijeDataTable();

            decimal? ukupniPrihod = 0;
            foreach (var r in _reservations)
            {
                var red = rezervacije.NewProjekcijeRow();
                red.BrKorisnika = _data.Where(x=> x.Id == r.ProjectionId).Count().ToString();
                red.NazivProjekcije = _data.Where(x=> x.Id == r.ProjectionId).Select(x=>x.Movie.Name).FirstOrDefault();
                red.Cijena = _data.Where(x => x.Id == r.ProjectionId).Select(x => x.Price.Name).FirstOrDefault();
                decimal? reservationPerProjectionCount = _data.Where(x => x.Id == r.ProjectionId).Count();

                ukupniPrihod += r.Payment?.Amount * reservationPerProjectionCount;

                red.UkupanPrihod = ukupniPrihod.ToString();

                rezervacije.Rows.Add(red);


            }
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = rezervacije;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "eCinema.WinUI.Reports.Report2.rdlc";

            // Refresh the report viewer control
            reportViewer1.RefreshReport();
        }
    }
}
