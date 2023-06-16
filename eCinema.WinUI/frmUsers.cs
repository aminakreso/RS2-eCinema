using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
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
    public partial class frmUsers : Form
    {
        private APIService _userService = new APIService("User");
        private APIService _roleService = new APIService("Role");

        public frmUsers()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
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

            var searchObject = new UserSearchObject();
            searchObject.Name = txtName.Text;
            searchObject.Role = cmbRoles.Text;
            searchObject.IncludeRoles = true;

            switch (cmbIsActive.Text)
            {
                case "Aktivni": searchObject.IsActive = true; break;
                case "Neaktivni": searchObject.IsActive = false; break;
                default:
                    searchObject.IsActive = null;
                    break;
            }

            var list = await _userService.Get<List<UserDto>>(searchObject);
            loadingPictureBox.Hide();
            btnShow.Enabled = true;

            //list = list.OrderBy(x => x.IsActive).ToList();
            dgvUsers.DataSource = list.OrderByDescending(x=> x.IsActive).ToList();
        }

        private async void frmUsers_Load(object sender, EventArgs e)
        {
            await LoadRoles();
            await LoadIsActive();
            cmbRoles.SelectedItem = null;
            cmbRoles.SelectedText = "Svi";
            loadingPictureBox.Hide();
        }

        public async Task LoadRoles()
        {
            var list = new List<RoleDto>
            {
                new RoleDto { Name = "Svi" }
            };
            var roles = await _roleService.Get<List<RoleDto>>(); ;
            list.AddRange(roles);
            cmbRoles.DataSource = list;
            cmbRoles.DisplayMember = "Name";
        }

        public async Task LoadIsActive()
        {
            var list = new List<string> { "Svi", "Aktivni", "Neaktivni" };
            cmbIsActive.DataSource = list;
        }

        private async void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var user = dgvUsers.SelectedRows[0].DataBoundItem as UserDto;

            var frmUserDetails = new frmUserDetails(user);
            frmUserDetails.ShowDialog();
            await LoadData();

        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var user = (UserDto)(this.dgvUsers.Rows[e.RowIndex]
                    .DataBoundItem);

                if (user is not null)
                {
                    if (user.Role is not null && e.ColumnIndex == 3)
                    {
                        e.Value = user.Role.Name;
                    }
                }
            }
        }

        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
