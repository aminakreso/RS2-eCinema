﻿using System;
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
    public partial class mdiMain : Form
    {
        private int childFormNumber = 0;

        public mdiMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void getUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = new frmUsers();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void adToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers obj = (frmUsers)Application.OpenForms["frmUsers"];
            if (obj!=null)
                obj.Close();
            var childForm = new frmUserDetails();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
           
        }

        private void obavijestiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var childForm = new frmNotification();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void dodajObavijestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotification obj = (frmNotification)Application.OpenForms["frmNotification"];
            if (obj != null)
                obj.Close();
            var childForm = new frmNotificationDetails();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void filmoviToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var childForm = new frmMovies();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void dodajFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovies obj = (frmMovies)Application.OpenForms["frmMovies"];
            if (obj != null)
                obj.Close();
            var childForm = new frmMovieDetails();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void projekcijeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var childForm = new frmProjection();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void dodajProjekcijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProjection obj = (frmProjection)Application.OpenForms["frmProjection"];
            if (obj != null)
                obj.Close();
            var childForm = new frmProjectionDetails();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void cijeneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var childForm = new frmPrices();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void dodajCijenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrices obj = (frmPrices)Application.OpenForms["frmPrices"];
            if (obj != null)
                obj.Close();
            var childForm = new frmPriceDetails();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void rezervacijeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var childForm = new frmReservations();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }
    }
}
