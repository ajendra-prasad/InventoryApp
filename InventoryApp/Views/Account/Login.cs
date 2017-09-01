using InventoryApp.Models;
using InventoryApp.Services;
using InventoryApp.Views.Category;
using log4net;
using System;
using System.Windows.Forms;

namespace InventoryApp.Views.Account
{
    public partial class Login : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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
            ResetErrorControls();

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider.SetError(txtUserName, "Please enter username.");
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Please enter password.");
            }

            try
            {
                User user = new User() { UserName = txtUserName.Text, Password = txtPassword.Text };

                bool isValidLogin = _authenticationService.AuthorizeUser(user);

                if (isValidLogin)
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();

                    Log.Error($"Login success.");
                }
                else
                {
                    Log.Error($"Login failed.");
                    MessageBox.Show("Invalid email or password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Internal Server Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Error($"Login request failed.", ex);
            }
        }

        private void ResetErrorControls()
        {
            errorProvider.SetError(txtUserName, "");
            errorProvider.SetError(txtPassword, "");
        }
    }
}
