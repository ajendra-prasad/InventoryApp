using InventoryApp.Models;
using InventoryApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp.Views.Account
{
    public partial class Login : Form
    {
        private readonly AuthenticationService _authenticationService;

        public Login()
        {
            _authenticationService = new AuthenticationService();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User() { UserName = txtUserName.Text, Password = txtPassword.Text };

                bool isValidLogin = _authenticationService.AuthorizeUser(user);

                if (isValidLogin)
                {
                    //Session["AdminLogin"] = true; ;
                    //return RedirectToAction("List", "Driver");
                }
                else
                {
                    //ModelState.AddModelError("", "Invalid email or password.");
                    MessageBox.Show("Invalid email or password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Internal Server Error.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Log.Error($"Admin login request failed. {Environment.NewLine} {JsonConvert.SerializeObject(model)}", ex);
                //ModelState.AddModelError("", ex.Message);
            }
        }
    }
}
