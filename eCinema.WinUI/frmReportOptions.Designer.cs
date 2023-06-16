namespace eCinema.WinUI
{
    partial class frmReportOptions
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
            this.btnProjectionsReport = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRezervacijePDF = new System.Windows.Forms.Button();
            this.btnProjekcijePDF = new System.Windows.Forms.Button();
            this.cmbMovies = new System.Windows.Forms.ComboBox();
            this.dtpProjectionStart = new System.Windows.Forms.DateTimePicker();
            this.dtpProjectionEnd = new System.Windows.Forms.DateTimePicker();
            this.btnReportFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProjectionsReport
            // 
            this.btnProjectionsReport.Location = new System.Drawing.Point(162, 309);
            this.btnProjectionsReport.Name = "btnProjectionsReport";
            this.btnProjectionsReport.Size = new System.Drawing.Size(142, 29);
            this.btnProjectionsReport.TabIndex = 12;
            this.btnProjectionsReport.Text = "Projekcije prihodi";
            this.btnProjectionsReport.UseVisualStyleBackColor = true;
            this.btnProjectionsReport.Click += new System.EventHandler(this.btnProjectionsReport_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(162, 34);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(149, 29);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Izvještaj rezervacija";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnRezervacijePDF
            // 
            this.btnRezervacijePDF.Location = new System.Drawing.Point(317, 34);
            this.btnRezervacijePDF.Name = "btnRezervacijePDF";
            this.btnRezervacijePDF.Size = new System.Drawing.Size(149, 29);
            this.btnRezervacijePDF.TabIndex = 32;
            this.btnRezervacijePDF.Text = "Rezervacije PDF";
            this.btnRezervacijePDF.UseVisualStyleBackColor = true;
            this.btnRezervacijePDF.Click += new System.EventHandler(this.btnRezervacijePDF_Click);
            // 
            // btnProjekcijePDF
            // 
            this.btnProjekcijePDF.Location = new System.Drawing.Point(317, 309);
            this.btnProjekcijePDF.Name = "btnProjekcijePDF";
            this.btnProjekcijePDF.Size = new System.Drawing.Size(149, 29);
            this.btnProjekcijePDF.TabIndex = 33;
            this.btnProjekcijePDF.Text = "Projekcije PDF";
            this.btnProjekcijePDF.UseVisualStyleBackColor = true;
            this.btnProjekcijePDF.Click += new System.EventHandler(this.btnProjekcijePDF_Click);
            // 
            // cmbMovies
            // 
            this.cmbMovies.FormattingEnabled = true;
            this.cmbMovies.Location = new System.Drawing.Point(147, 131);
            this.cmbMovies.Name = "cmbMovies";
            this.cmbMovies.Size = new System.Drawing.Size(151, 28);
            this.cmbMovies.TabIndex = 34;
            // 
            // dtpProjectionStart
            // 
            this.dtpProjectionStart.Location = new System.Drawing.Point(167, 181);
            this.dtpProjectionStart.Name = "dtpProjectionStart";
            this.dtpProjectionStart.Size = new System.Drawing.Size(250, 27);
            this.dtpProjectionStart.TabIndex = 35;
            // 
            // dtpProjectionEnd
            // 
            this.dtpProjectionEnd.Location = new System.Drawing.Point(167, 225);
            this.dtpProjectionEnd.Name = "dtpProjectionEnd";
            this.dtpProjectionEnd.Size = new System.Drawing.Size(250, 27);
            this.dtpProjectionEnd.TabIndex = 36;
            // 
            // btnReportFilter
            // 
            this.btnReportFilter.Location = new System.Drawing.Point(317, 258);
            this.btnReportFilter.Name = "btnReportFilter";
            this.btnReportFilter.Size = new System.Drawing.Size(149, 29);
            this.btnReportFilter.TabIndex = 37;
            this.btnReportFilter.Text = "Filter report";
            this.btnReportFilter.UseVisualStyleBackColor = true;
            this.btnReportFilter.Click += new System.EventHandler(this.btnReportFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sve rezervacije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Rezervacije po projekciji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Projekcije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Početni datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Završni datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Sve projekcije";
            // 
            // frmReportOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReportFilter);
            this.Controls.Add(this.dtpProjectionEnd);
            this.Controls.Add(this.dtpProjectionStart);
            this.Controls.Add(this.cmbMovies);
            this.Controls.Add(this.btnProjekcijePDF);
            this.Controls.Add(this.btnRezervacijePDF);
            this.Controls.Add(this.btnProjectionsReport);
            this.Controls.Add(this.btnReport);
            this.Name = "frmReportOptions";
            this.Text = "frmReportOptions";
            this.Load += new System.EventHandler(this.frmReportOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnProjectionsReport;
        private Button btnReport;
        private Button btnRezervacijePDF;
        private Button btnProjekcijePDF;
        private ComboBox cmbMovies;
        private DateTimePicker dtpProjectionStart;
        private DateTimePicker dtpProjectionEnd;
        private Button btnReportFilter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}