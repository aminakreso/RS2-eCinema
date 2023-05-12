using eCinema.Model.Dtos;
using eCinema.Model.SearchObjects;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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
        private APIService _projectionService = new APIService("Projection");

        public frmReservations()
        {
            InitializeComponent();
            dgvReservations.AutoGenerateColumns = false;
            loadingPictureBox.Hide();
        }

        private void frmReservations_Load(object sender, EventArgs e)
        {
         
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
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
                IncludePrices = true
            };

            var list = await _reservationService.Get<List<ReservationDto>>(searchObject);
            loadingPictureBox.Hide();

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
                        e.Value = reservation.Projection.Price.Value;
                    }
                    if (reservation.Payment is not null && e.ColumnIndex == 4)
                    {
                        e.Value = reservation.Payment.Amount;
                    }
                }
            }
        }

        private async void btnReport_Click(object sender, EventArgs e)
        {
            loadingPictureBox.Show();
            loadingPictureBox.Update();

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
            loadingPictureBox.Hide();

            // close the document
            doc.Close();

            MessageBox.Show("Report generated on desktop.");
            this.Close();
        }

        private async void btnProjectionsReport_Click(object sender, EventArgs e)
        {
            loadingPictureBox.Show();
            loadingPictureBox.Update();

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
            table.AddHeaderCell("Naziv Nekretnine");
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

            loadingPictureBox.Hide();

            // close the document
            doc.Close();
            MessageBox.Show("Report generated on desktop.");
            this.Close();
        }
    }
}
