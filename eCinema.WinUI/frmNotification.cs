using eCinema.Model.Constants;
using eCinema.Model.Dtos;
using eCinema.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;

namespace eCinema.WinUI
{
    public partial class frmNotification : Form
    {
        private APIService _notificationService = new APIService("Notification");
        private APIService _userService = new APIService("User");

        public frmNotification()
        {
            InitializeComponent();
            dgvNotifications.AutoGenerateColumns = false;

        }

        private async void frmNotification_Load(object sender, EventArgs e)
        {
            await LoadUsers();
            await LoadTypes();

            cmbAuthor.SelectedItem = null;
            cmbAuthor.SelectedText = "Svi";
            cmbNotificationType.SelectedItem = null;
            cmbNotificationType.SelectedText = "Svi";
            loadingPictureBox.Hide();

        }

        private async Task LoadTypes()
        {
            var list = new List<string>
            {
                "Svi" 
            };
            var typesList = NotificationTypes.ListOfNotificationTypes;
            list.AddRange(typesList.ToList());
            cmbNotificationType.DataSource = list;
            //cmbNotificationType.DisplayMember = "NotificationType";
            //cmbNotificationType.ValueMember = "Id";
        }

        private async Task LoadUsers()
        {
            var list = new List<UserDto>
            {
                new UserDto { FirstName = "Svi" }
            };
            var users = await _userService.Get<List<UserDto>>();
            list.AddRange(users);
            cmbAuthor.DataSource = list;
            cmbAuthor.DisplayMember = "FullName";
            cmbAuthor.ValueMember = "Id";
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            await LoadData();

        }

        private async Task LoadData()
        {
            btnShow.Enabled = false;

            loadingPictureBox.Show();
            loadingPictureBox.Update();

            var searchObject = new NotificationSearchObject();
            searchObject.Title = txtTitle.Text;

            if (cmbAuthor.SelectedItem is not null && !string.IsNullOrWhiteSpace(cmbAuthor.Text))
            {
                searchObject.AuthorId = (Guid)cmbAuthor.SelectedValue;
            }
            else
            {
                searchObject.AuthorId = Guid.Empty;
            }

            searchObject.NotificationType = cmbNotificationType.Text;
            searchObject.IncludeUsers = true;

            
            var list = await _notificationService.Get<List<NotificationDto>>(searchObject);
            loadingPictureBox.Hide();
            btnShow.Enabled = true;

            list = list.Where(x => x.IsActive == true).ToList();
            dgvNotifications.DataSource = list;
        }

        private async void dgvNotifications_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var notification = dgvNotifications.SelectedRows[0].DataBoundItem as NotificationDto;

            var frmNotificationDetails = new frmNotificationDetails(notification);
            frmNotificationDetails.ShowDialog();
            await LoadData();

        }

        private void dgvNotifications_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var notification = (NotificationDto)(this.dgvNotifications.Rows[e.RowIndex]
                    .DataBoundItem);

                if (notification is not null)
                {
                    if (notification.Author is not null && e.ColumnIndex == 2)
                    {
                        e.Value = $"{notification.Author.FirstName} {notification.Author.LastName}";
                    }

                }
            }
        }

        private async void dgvNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var notification = (NotificationDto)(this.dgvNotifications.Rows[e.RowIndex]
                   .DataBoundItem);

                await _notificationService.Delete<NotificationDto>(notification.Id);
            }

            await LoadData();

        }
    }
}
