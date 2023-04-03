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
    public partial class frmReg : Form
    {
        public frmReg()
        {
            InitializeComponent();
        }

        private void frmReg_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("First Name, Last Name, and Age are Required!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else 
            {
                if (Double.Parse(txtAge.Text) <= 15)
                    MessageBox.Show("You are too young to apply for this program.", "Too Young", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else if (Double.Parse(txtAge.Text) >= 60)
                    MessageBox.Show("You are already at the age of retirement.", "Too Old", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                    MessageBox.Show("Registration Successful. You may now proceed to the next step.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtCourse.Clear();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogIn loginForm = new frmLogIn();
            loginForm.Show();
            this.Close();
        }
    }
}
