﻿namespace eCinema.WinUI
{
    partial class frmMovieDetails
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
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtActors = new System.Windows.Forms.RichTextBox();
            this.txtGenres = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(54, 190);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(125, 27);
            this.txtDuration.TabIndex = 21;
            this.txtDuration.Validating += new System.ComponentModel.CancelEventHandler(this.txtDuration_Validating);
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(54, 127);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(125, 27);
            this.txtDirector.TabIndex = 20;
            this.txtDirector.Validating += new System.ComponentModel.CancelEventHandler(this.txtDirector_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(54, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 19;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Naziv";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Režiser";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Trajanje";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(54, 320);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(125, 27);
            this.txtCountry.TabIndex = 26;
            this.txtCountry.Validating += new System.ComponentModel.CancelEventHandler(this.txtCountry_Validating);
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(54, 256);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(125, 27);
            this.txtReleaseYear.TabIndex = 25;
            this.txtReleaseYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtReleaseYear_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Godina izlaska";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Država";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Opis";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(245, 256);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(212, 113);
            this.txtDescription.TabIndex = 27;
            this.txtDescription.Text = "";
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // txtActors
            // 
            this.txtActors.Location = new System.Drawing.Point(245, 159);
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(212, 71);
            this.txtActors.TabIndex = 28;
            this.txtActors.Text = "";
            this.txtActors.Validating += new System.ComponentModel.CancelEventHandler(this.txtActors_Validating);
            // 
            // txtGenres
            // 
            this.txtGenres.Location = new System.Drawing.Point(245, 72);
            this.txtGenres.Name = "txtGenres";
            this.txtGenres.Size = new System.Drawing.Size(212, 52);
            this.txtGenres.TabIndex = 29;
            this.txtGenres.Text = "";
            this.txtGenres.Validating += new System.ComponentModel.CancelEventHandler(this.txtGenres_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Žanrovi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Glumci";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Spasi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPicture.Location = new System.Drawing.Point(512, 71);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(188, 295);
            this.pbPicture.TabIndex = 34;
            this.pbPicture.TabStop = false;
            // 
            // ofdPicture
            // 
            this.ofdPicture.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Slika";
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(606, 387);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(94, 29);
            this.btnAddPicture.TabIndex = 36;
            this.btnAddPicture.Text = "Dodaj sliku";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmMovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGenres);
            this.Controls.Add(this.txtActors);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Name = "frmMovieDetails";
            this.Text = "MovieDetails";
            this.Load += new System.EventHandler(this.frmMovieDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDuration;
        private TextBox txtDirector;
        private TextBox txtName;
        private Label label8;
        private Label label9;
        private Label label6;
        private TextBox txtCountry;
        private TextBox txtReleaseYear;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox txtDescription;
        private RichTextBox txtActors;
        private RichTextBox txtGenres;
        private Label label4;
        private Label label5;
        private Button btnSave;
        private PictureBox pbPicture;
        private OpenFileDialog ofdPicture;
        private Label label7;
        private Button btnAddPicture;
        private ErrorProvider errorProvider;
    }
}