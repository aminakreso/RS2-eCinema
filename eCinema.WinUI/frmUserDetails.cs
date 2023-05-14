using eCinema.Model.Dtos;
using eCinema.Model.Requests;
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
    public partial class frmUserDetails : Form
    {
        private APIService _userService = new APIService("User");
        private readonly APIService _roleService = new APIService("Role");
        public frmUserDetails(UserDto model = null)
        {
            InitializeComponent();
            _model = model;
        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {
            await LoadRoles();

            if (_model is not null)
            {
                LoadAccessInfo();
                var role = _model.Role?.Name;

                if(role == "Admin")
                {
                    SetAdminReadOnly();
                }
                txtFirstName.Text = _model.FirstName;
                txtLastName.Text = _model.LastName;
                txtEmail.Text = _model.Email;
                txtPhoneNumber.Text = _model.PhoneNumber;
                txtUsernamee.Text = _model.Username;
                cmbRole.Text = _model.Role?.Name;
                cbIsActive.Checked = _model.IsActive.GetValueOrDefault(false);
            }
        }

        private void SetAdminReadOnly()
        {
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
            btnSave.Visible = false;
            //cmbRole.CanSelect = false;
            //cbIsActive.CanSelect = false;
        }

            private void LoadAccessInfo()
        {
            if(_model is not null)
            {
                txtUsernamee.ReadOnly = true;
                lblPassword.Visible = false;
                txtUserPassword.Visible = false;
                lblConfirmPassword.Visible = false;
                txtPasswordConfirm.Visible = false;
                
            }
        }

        private UserDto _model = null;


        public async Task LoadRoles()
        {
            var roles = await _roleService.Get<List<RoleDto>>();
            cmbRole.DataSource = roles;
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "Id";
            
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var roleId = (Guid)cmbRole.SelectedValue;

                var users = await _userService.Get<List<UserDto>>(null);
                if (users.Any(x => x.Username.Equals(txtUsernamee.Text) && _model?.Id != x.Id)){
                    txtUsernamee.Focus();
                    errorProvider.SetError(txtUsernamee, "User already exists!");
                    return;
                }
                else
                {
                    errorProvider.SetError(txtUsernamee, "");
                    errorProvider.Clear();
                }

                if (_model is null)
                {
                    var insert = new UserInsertRequest
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Username = txtUsernamee.Text,
                        Password = txtUserPassword.Text,
                        ConfirmPassword = txtPasswordConfirm.Text,
                        RoleId = roleId,
                        IsActive = cbIsActive.Checked,
                    };

                    var user = await _userService.Post<UserDto>(insert);
                    MessageBox.Show("User added.");
                    this.Close();
                }
                else
                {
                    var update = new UserAdminUpdateRequest
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        RoleId = roleId,
                        IsActive = cbIsActive.Checked,
                    };

                    _model = await _userService.PutAdminUser<UserDto>(_model.Id, update);
                    MessageBox.Show("User edited.");
                    this.Close();
                }
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtFirstName, e, "First name", errorProvider);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtLastName, e, "Last name", errorProvider);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtEmail, e, "Email", errorProvider);
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtPhoneNumber, e, "Phone number", errorProvider);
        }

        private void txtUserPassword_Validating(object sender, CancelEventArgs e)
        {
            if(_model is null)
                ValidationHelper.Validate(txtUserPassword, e, "Phone number", errorProvider);
        }

        private void txtPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (_model is null)
                ValidationHelper.Validate(txtPasswordConfirm, e, "Phone number", errorProvider);
        }

        private void cmbRole_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.ValidateComboBox(cmbRole, e, "Role number", errorProvider);
        }
    }
}
