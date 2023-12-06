using Repositories.Models;
using Service;

namespace GameCard_SE172956
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            MemberAccountService se = new MemberAccountService();

            MemberAccount account = se.CheckLogin(email, password);
            if (account == null)
            {
                MessageBox.Show("Login failed. Please check your credentials",
                                 "Wrong credentials", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            if (account.Role != 2 && account.Role != 3)
            {
                MessageBox.Show("You have no permission to access this function!",
                                "Access denied", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                if (account.Role == 2)
                {
                    StaffForm staffForm = new StaffForm();
                    staffForm.Show();
                    this.Hide();
                }
                else if (account.Role == 3)
                {
                    GameCardManagerForm sunglassesManagerFrom = new GameCardManagerForm();
                    sunglassesManagerFrom.Show();
                    this.Hide();
                }
                return;
            }
        }

    }
}