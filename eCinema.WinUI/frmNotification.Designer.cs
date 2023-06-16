namespace eCinema.WinUI
{
    partial class frmNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotification));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.cmbNotificationType = new System.Windows.Forms.ComboBox();
            this.dgvNotifications = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbriši = new System.Windows.Forms.DataGridViewButtonColumn();
            this.notificationDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            this.loadingPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(77, 55);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(125, 27);
            this.txtTitle.TabIndex = 3;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(268, 55);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(103, 28);
            this.cmbAuthor.TabIndex = 4;
            // 
            // cmbNotificationType
            // 
            this.cmbNotificationType.FormattingEnabled = true;
            this.cmbNotificationType.Location = new System.Drawing.Point(413, 55);
            this.cmbNotificationType.Name = "cmbNotificationType";
            this.cmbNotificationType.Size = new System.Drawing.Size(98, 28);
            this.cmbNotificationType.TabIndex = 5;
            // 
            // dgvNotifications
            // 
            this.dgvNotifications.AllowUserToAddRows = false;
            this.dgvNotifications.AllowUserToDeleteRows = false;
            this.dgvNotifications.AutoGenerateColumns = false;
            this.dgvNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.authorIdDataGridViewTextBoxColumn,
            this.notificationTypeDataGridViewTextBoxColumn,
            this.Description,
            this.Izbriši});
            this.dgvNotifications.DataSource = this.notificationDtoBindingSource;
            this.dgvNotifications.Location = new System.Drawing.Point(25, 90);
            this.dgvNotifications.Name = "dgvNotifications";
            this.dgvNotifications.ReadOnly = true;
            this.dgvNotifications.RowHeadersWidth = 51;
            this.dgvNotifications.RowTemplate.Height = 29;
            this.dgvNotifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotifications.Size = new System.Drawing.Size(687, 305);
            this.dgvNotifications.TabIndex = 6;
            this.dgvNotifications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotifications_CellContentClick);
            this.dgvNotifications.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotifications_CellContentDoubleClick);
            this.dgvNotifications.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNotifications_CellFormatting);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorIdDataGridViewTextBoxColumn
            // 
            this.authorIdDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
            this.authorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notificationTypeDataGridViewTextBoxColumn
            // 
            this.notificationTypeDataGridViewTextBoxColumn.DataPropertyName = "NotificationType";
            this.notificationTypeDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.notificationTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notificationTypeDataGridViewTextBoxColumn.Name = "notificationTypeDataGridViewTextBoxColumn";
            this.notificationTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Sadržaj";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Izbriši
            // 
            this.Izbriši.HeaderText = "Izbriši";
            this.Izbriši.MinimumWidth = 6;
            this.Izbriši.Name = "Izbriši";
            this.Izbriši.ReadOnly = true;
            this.Izbriši.Text = "Izbriši";
            this.Izbriši.ToolTipText = "Izbriši";
            this.Izbriši.UseColumnTextForButtonValue = true;
            // 
            // notificationDtoBindingSource
            // 
            this.notificationDtoBindingSource.DataSource = typeof(eCinema.Model.Dtos.NotificationDto);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(618, 55);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(94, 29);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Prikaži";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // loadingPictureBox
            // 
            this.loadingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("loadingPictureBox.Image")));
            this.loadingPictureBox.Location = new System.Drawing.Point(299, 176);
            this.loadingPictureBox.Name = "loadingPictureBox";
            this.loadingPictureBox.Size = new System.Drawing.Size(125, 116);
            this.loadingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingPictureBox.TabIndex = 32;
            this.loadingPictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "Lista notifikacija";
            // 
            // frmNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 405);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loadingPictureBox);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvNotifications);
            this.Controls.Add(this.cmbNotificationType);
            this.Controls.Add(this.cmbAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notifikacije";
            this.Load += new System.EventHandler(this.frmNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitle;
        private ComboBox cmbAuthor;
        private ComboBox cmbNotificationType;
        private DataGridView dgvNotifications;
        private BindingSource notificationDtoBindingSource;
        private Button btnShow;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notificationTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewButtonColumn Izbriši;
        private PictureBox loadingPictureBox;
        private Label label4;
    }
}