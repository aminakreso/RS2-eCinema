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

namespace eCinema.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _userService = new APIService("User");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                try
                {
                    var searchObject = new UserSearchObject
                    {
                        Username = APIService.Username,
                        IncludeRoles = true
                    };
                    var user = await _userService.Get<List<UserDto>>(searchObject);
                    if (user[0].Role.Name == "Admin")
                    {
                        mdiMain frm = new mdiMain();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
                    }
                }
                catch
                {
                    MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
                }

            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtUsername, e, "Korisničko ime", err);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validate(txtPassword, e, "Lozinka", err);
        }
    }
}
