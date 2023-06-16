namespace eCinema.WinUI
{
    partial class frmProjectionDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectionDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMovieName = new System.Windows.Forms.ComboBox();
            this.cmbProjectionType = new System.Windows.Forms.ComboBox();
            this.cmbHall = new System.Windows.Forms.ComboBox();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.dtpProjectionDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.loadingPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip projekcije";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrijeme pocetka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sala";
            // 
            // cmbMovieName
            // 
            this.cmbMovieName.FormattingEnabled = true;
            this.cmbMovieName.Location = new System.Drawing.Point(55, 70);
            this.cmbMovieName.Name = "cmbMovieName";
            this.cmbMovieName.Size = new System.Drawing.Size(151, 28);
            this.cmbMovieName.TabIndex = 6;
            this.cmbMovieName.Validating += new System.ComponentModel.CancelEventHandler(this.cmbMovieName_Validating);
            // 
            // cmbProjectionType
            // 
            this.cmbProjectionType.FormattingEnabled = true;
            this.cmbProjectionType.Location = new System.Drawing.Point(316, 197);
            this.cmbProjectionType.Name = "cmbProjectionType";
            this.cmbProjectionType.Size = new System.Drawing.Size(151, 28);
            this.cmbProjectionType.TabIndex = 7;
            this.cmbProjectionType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbProjectionType_Validating);
            // 
            // cmbHall
            // 
            this.cmbHall.FormattingEnabled = true;
            this.cmbHall.Location = new System.Drawing.Point(316, 70);
            this.cmbHall.Name = "cmbHall";
            this.cmbHall.Size = new System.Drawing.Size(151, 28);
            this.cmbHall.TabIndex = 9;
            this.cmbHall.Validating += new System.ComponentModel.CancelEventHandler(this.cmbHall_Validating);
            // 
            // cmbPrice
            // 
            this.cmbPrice.FormattingEnabled = true;
            this.cmbPrice.Location = new System.Drawing.Point(316, 134);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Size = new System.Drawing.Size(151, 28);
            this.cmbPrice.TabIndex = 11;
            this.cmbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPrice_Validating);
            // 
            // dtpProjectionDateTime
            // 
            this.dtpProjectionDateTime.Location = new System.Drawing.Point(55, 135);
            this.dtpProjectionDateTime.Name = "dtpProjectionDateTime";
            this.dtpProjectionDateTime.Size = new System.Drawing.Size(245, 27);
            this.dtpProjectionDateTime.TabIndex = 12;
            this.dtpProjectionDateTime.Validating += new System.ComponentModel.CancelEventHandler(this.dtpProjectionDateTime_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(340, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Spasi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(55, 242);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(72, 29);
            this.btnActivate.TabIndex = 15;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(134, 242);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(72, 29);
            this.btnHide.TabIndex = 16;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_ClickAsync);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Location = new System.Drawing.Point(55, 198);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(250, 27);
            this.dtpEndTime.TabIndex = 17;
            this.dtpEndTime.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEndTime_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Vrijeme završetka";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // loadingPictureBox
            // 
            this.loadingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("loadingPictureBox.Image")));
            this.loadingPictureBox.Location = new System.Drawing.Point(55, 12);
            this.loadingPictureBox.Name = "loadingPictureBox";
            this.loadingPictureBox.Size = new System.Drawing.Size(435, 287);
            this.loadingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingPictureBox.TabIndex = 19;
            this.loadingPictureBox.TabStop = false;
            // 
            // frmProjectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(547, 329);
            this.Controls.Add(this.loadingPictureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpProjectionDateTime);
            this.Controls.Add(this.cmbPrice);
            this.Controls.Add(this.cmbHall);
            this.Controls.Add(this.cmbProjectionType);
            this.Controls.Add(this.cmbMovieName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProjectionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji projekcije";
            this.Load += new System.EventHandler(this.frmProjectionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbMovieName;
        private ComboBox cmbProjectionType;
        private ComboBox cmbHall;
        private ComboBox cmbPrice;
        private DateTimePicker dtpProjectionDateTime;
        private Button btnSave;
        private Button btnActivate;
        private Button btnHide;
        private DateTimePicker dtpEndTime;
        private Label label6;
        private ErrorProvider errorProvider;
        private PictureBox loadingPictureBox;
    }
}