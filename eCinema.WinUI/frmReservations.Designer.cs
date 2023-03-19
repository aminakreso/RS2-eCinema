namespace eCinema.WinUI
{
    partial class frmReservations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.reservationDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Film = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnProjectionsReport = new System.Windows.Forms.Button();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AutoGenerateColumns = false;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.projectionIdDataGridViewTextBoxColumn,
            this.projectionDataGridViewTextBoxColumn,
            this.Price,
            this.Tickets,
            this.dateTimeDataGridViewTextBoxColumn});
            this.dgvReservations.DataSource = this.reservationDtoBindingSource;
            this.dgvReservations.Location = new System.Drawing.Point(12, 79);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 29;
            this.dgvReservations.Size = new System.Drawing.Size(764, 306);
            this.dgvReservations.TabIndex = 0;
            this.dgvReservations.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReservations_CellFormatting);
            // 
            // reservationDtoBindingSource
            // 
            this.reservationDtoBindingSource.DataSource = typeof(eCinema.Model.Dtos.ReservationDto);
            // 
            // Film
            // 
            this.Film.AutoSize = true;
            this.Film.Location = new System.Drawing.Point(12, 45);
            this.Film.Name = "Film";
            this.Film.Size = new System.Drawing.Size(37, 20);
            this.Film.TabIndex = 1;
            this.Film.Text = "Film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Korisnik";
            // 
            // txtMovie
            // 
            this.txtMovie.Location = new System.Drawing.Point(68, 44);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(115, 27);
            this.txtMovie.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(266, 42);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(107, 27);
            this.txtUser.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(433, 43);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(243, 27);
            this.dtpDate.TabIndex = 5;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(682, 42);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(94, 29);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Prikazi";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(627, 409);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(149, 29);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Izvještaj rezervacija";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProjectionsReport
            // 
            this.btnProjectionsReport.Location = new System.Drawing.Point(479, 409);
            this.btnProjectionsReport.Name = "btnProjectionsReport";
            this.btnProjectionsReport.Size = new System.Drawing.Size(142, 29);
            this.btnProjectionsReport.TabIndex = 9;
            this.btnProjectionsReport.Text = "Projekcije prihodi";
            this.btnProjectionsReport.UseVisualStyleBackColor = true;
            this.btnProjectionsReport.Click += new System.EventHandler(this.btnProjectionsReport_Click);
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectionIdDataGridViewTextBoxColumn
            // 
            this.projectionIdDataGridViewTextBoxColumn.HeaderText = "Datum projekcije";
            this.projectionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectionIdDataGridViewTextBoxColumn.Name = "projectionIdDataGridViewTextBoxColumn";
            this.projectionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectionIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectionDataGridViewTextBoxColumn
            // 
            this.projectionDataGridViewTextBoxColumn.HeaderText = "Film";
            this.projectionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectionDataGridViewTextBoxColumn.Name = "projectionDataGridViewTextBoxColumn";
            this.projectionDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectionDataGridViewTextBoxColumn.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Cijena karte";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Tickets
            // 
            this.Tickets.HeaderText = "Količina";
            this.Tickets.MinimumWidth = 6;
            this.Tickets.Name = "Tickets";
            this.Tickets.ReadOnly = true;
            this.Tickets.Width = 125;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Datum rezervacije";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProjectionsReport);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Film);
            this.Controls.Add(this.dgvReservations);
            this.Name = "frmReservations";
            this.Text = "frmReservations";
            this.Load += new System.EventHandler(this.frmReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvReservations;
        private Label Film;
        private Label label2;
        private TextBox txtMovie;
        private TextBox txtUser;
        private DateTimePicker dtpDate;
        private Button btnShow;
        private Label label3;
        private BindingSource reservationDtoBindingSource;
        private Button btnReport;
        private Button btnProjectionsReport;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn projectionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn projectionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Tickets;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
    }
}