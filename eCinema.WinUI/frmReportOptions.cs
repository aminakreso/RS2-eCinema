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
    public partial class frmReportOptions : Form
    {
        private APIService _reservationService = new APIService("Reservation");
        private APIService _projectionService = new APIService("Projection");
        private APIService _movieService = new APIService("Movie");

        public frmReportOptions()
        {
            InitializeComponent();
        }

        private async void btnProjectionsReport_Click(object sender, EventArgs e)
        {
            var projectionSearchObject = new ProjectionSearchObject { IncludeMovies = true, IncludePrices = true };
            List<ProjectionDto> data = await _projectionService.Get<List<ProjectionDto>>(projectionSearchObject);
            List<ReservationDto> reservations = new List<ReservationDto>();
            foreach (ProjectionDto item in data)
            {
                ReservationSearchObject reservation = new ReservationSearchObject();
                reservation.ProjectionId = item.Id;
                reservation.IncludePayments = true;
                List<ReservationDto> temp = await _reservationService.Get<List<ReservationDto>>(reservation);
                reservations.AddRange(temp);
            }

            frmReport2 frmReport2 = new frmReport2(data, reservations);
            frmReport2.ShowDialog();
           
            //MessageBox.Show("Report generated on desktop.");
            //this.Close();
        }

        private async void btnReport_Click(object sender, EventArgs e)
        {

            var searchObject = new ReservationSearchObject
            {
                IncludeUsers = true,
                IncludeProjection = true,
                IncludeMovies = true,
                IncludePayments = true,
                IncludePrices = true
            };

            List<ReservationDto> data = await _reservationService.Get<List<ReservationDto>>(searchObject);

            frmReport1 frmReport1 = new frmReport1(data);
            frmReport1.ShowDialog();

           
            //MessageBox.Show("Report generated on desktop.");
            //this.Close();
        }

        private async void btnRezervacijePDF_Click(object sender, EventArgs e)
        {
            var searchObject = new ReservationSearchObject
            {
                IncludeUsers = true,
                IncludeProjection = true,
                IncludeMovies = true,
                IncludePayments = true,
                IncludePrices = true
            };

            List<ReservationDto> data = await _reservationService.Get<List<ReservationDto>>(searchObject);

            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\rezervacije.pdf"));

            Document doc = new Document(pdfDoc);

            Table table = new Table(6);

            table.AddHeaderCell("Korisnik");
            table.AddHeaderCell("Datum projekcije");
            table.AddHeaderCell("Film");
            table.AddHeaderCell("Tip projekcije");
            table.AddHeaderCell("Iznos");
            table.AddHeaderCell("Datum rezervacije");


            foreach (ReservationDto item in data)
            {
                table.AddCell(item.User.FirstName ?? "");
                table.AddCell(item.Projection?.StartTime.ToString() ?? "");
                table.AddCell(item.Projection?.Movie.Name ?? "");
                table.AddCell(item.Projection?.Price.Name ?? "");
                table.AddCell(item.Payment?.Amount.ToString() ?? "");
                table.AddCell(item.DateTime.ToString() ?? "");
            }

            Paragraph title = new Paragraph("Lista rezervacija")
                .SetFont(PdfFontFactory
                .CreateFont("Helvetica-Bold"))
                .SetFontSize(22)
                .SetTextAlignment(TextAlignment.CENTER);
            Paragraph para = new Paragraph("Broj rezervacija " + data.Count + ".");
            // add the table to the document
            doc.Add(title);
            doc.Add(table);
            doc.Add(para);

            // close the document
            doc.Close();

            MessageBox.Show("Izvještaj generisan na desktopu.");
            //this.Close();
        }

        private async void btnProjekcijePDF_Click(object sender, EventArgs e)
        {
            var projectionSearchObject = new ProjectionSearchObject { IncludeMovies = true, IncludePrices = true };
            List<ProjectionDto> data = await _projectionService.Get<List<ProjectionDto>>(projectionSearchObject);
            List<ReservationDto> reservations = new List<ReservationDto>();
            foreach (ProjectionDto item in data)
            {
                ReservationSearchObject reservation = new ReservationSearchObject();
                reservation.ProjectionId = item.Id;
                reservation.IncludePayments = true;
                List<ReservationDto> temp = await _reservationService.Get<List<ReservationDto>>(reservation);
                reservations.AddRange(temp);
            }
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ukupanPrihod.pdf"));

            // create a new document instance
            Document doc = new Document(pdfDoc);

            // create a new table with 1 column
            Table table = new Table(4);

            // add header row with column names
            table.AddHeaderCell("Naziv projekcije");
            table.AddHeaderCell("Cijena");
            table.AddHeaderCell("Br. Korisnika");
            table.AddHeaderCell("Ukupan prihod");

            decimal? ukupniPrihodi = 0;
            // add table rows dynamically based on API data
            foreach (ProjectionDto projection in data)
            {
                table.AddCell(projection.Movie.Name);
                table.AddCell(projection.Price.Value.ToString());
                table.AddCell(reservations.Where(x => x.ProjectionId == projection.Id).Count().ToString());
                int reservationPerProjectionCount = reservations.Where(x => x.ProjectionId == projection.Id).Count();
                ukupniPrihodi += projection!.Price!.Value! * reservationPerProjectionCount;
                table.AddCell((projection.Price.Value * reservationPerProjectionCount).ToString());
            }

            Paragraph title = new Paragraph("Ukupni profit")
                .SetFont(PdfFontFactory
                .CreateFont("Helvetica-Bold"))
                .SetFontSize(22)
                .SetTextAlignment(TextAlignment.CENTER);
            Paragraph para = new Paragraph("Broj projekcija " + data.Count + ".");
            Paragraph ukupniPrihod = new Paragraph("Ukupni prihodi " + ukupniPrihodi.ToString() + ".");
            // add the table to the document
            doc.Add(title);
            doc.Add(table);
            doc.Add(para);
            doc.Add(ukupniPrihod);


            // close the document
            doc.Close();
            MessageBox.Show("Izvještaj generisan na desktopu.");
            //this.Close();
        }

        private async void frmReportOptions_Load(object sender, EventArgs e)
        {
            btnReportFilter.Enabled = false;
            await LoadMovies();
        }

        private async Task LoadMovies()
        {
            var list = new List<MovieDto>
            {
                new MovieDto { Name = "Svi" }
            };
            var movies = await _movieService.Get<List<MovieDto>>();
            list.AddRange(movies);
            cmbMovies.DataSource = list;
            cmbMovies.DisplayMember = "Name";
            cmbMovies.ValueMember = "Id";
            btnReportFilter.Enabled = true;
        }

        private async void btnReportFilter_Click(object sender, EventArgs e)
        {
            var searchObject = new ReservationSearchObject
            {
                IncludeUsers = true,
                IncludeProjection = true,
                IncludeMovies = true,
                IncludePayments = true,
                IncludePrices = true
            };

            List<ReservationDto> data = await _reservationService.Get<List<ReservationDto>>(searchObject);

            data = data.Where(x => x.Projection.StartTime.Value >= dtpProjectionStart.Value && x.Projection.StartTime.Value <= dtpProjectionEnd.Value).ToList();
            frmReport1 frmReport1 = new frmReport1(data);
            frmReport1.ShowDialog();

        }
    }
}
