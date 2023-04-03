using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        String username= "admin", password = "admin123";

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void logIn_Conditions()
        {
            if (String.IsNullOrEmpty(txtUsername.Text) && String.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("Username and Password are required!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (String.IsNullOrEmpty(txtUsername.Text))
                MessageBox.Show("Username is required.", "Blank username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (String.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("Password is required.", "Blank password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                if (txtUsername.Text != username || txtPassword.Text != password)
                    MessageBox.Show("Login Failed. The username or password you entered is incorrect.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmReg regForm = new frmReg();
                    regForm.Show();
                }
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            logIn_Conditions();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logIn_Conditions();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logIn_Conditions();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
