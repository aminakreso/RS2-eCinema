﻿using eCinema.Model.Constants;
using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.WinUI.Helpers;
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
    public partial class frmNotificationDetails : Form
    {
        private APIService _notificationService = new APIService("Notification");
        public frmNotificationDetails(NotificationDto model = null)
        {
            InitializeComponent();
            _model = model;
        }

        private NotificationDto _model = null;

        private async void frmNotificationDetails_Load(object sender, EventArgs e)
        {
            if(_model is not null)
            {
                txtTitle.Text = _model.Title;
                txtContent.Text = _model.Description;
                cmbNotificationType.Text = _model.NotificationType;
                if (_model.Picture != null)
                    pbSlika.Image = ImageHelper.FromByteToImage(_model.Picture);
            }
            await LoadTypes();
        }



        private async Task LoadTypes()
        {
            var typesList = NotificationTypes.ListOfNotificationTypes;
            cmbNotificationType.DataSource = typesList;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_model is null)
                {
                    var insert = new NotificationInsertRequest()
                    {
                        Title = txtTitle.Text,
                        Description = txtContent.Text,
                        NotificationType = cmbNotificationType.Text,
                        //UserId = APIService.Id

                    };
                    if (pbSlika.Image != null)
                        insert.Picture = ImageHelper.FromImageToBase64(pbSlika.Image);

                    await _notificationService.Post<NotificationDto>(insert);
                    MessageBox.Show("Notification added.");
                    this.Close();
                }
                else
                {
                    var update = new NotificationUpdateRequest()
                    {
                        Title = txtTitle.Text,
                        Description = txtContent.Text,
                        NotificationType = cmbNotificationType.Text,
                    };

                    if (pbSlika.Image != null)
                        update.Picture = ImageHelper.FromImageToBase64(pbSlika.Image);

                    _model = await _notificationService.Put<NotificationDto>(_model.Id, update);
                    MessageBox.Show("Notification edited.");
                    this.Close();
                }
            }
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtTitle, e, "Title", errorProvider);

        }

        private void txtContent_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateRichTextBox(txtContent, e, "Content", errorProvider);
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofdPicture.FileName);
            }
        }
    }
}
