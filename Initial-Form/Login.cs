using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Initial_Form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Required fields");
            }
            else
            {
                if (txtLogin.Text == "davi" && txtPassword.Text == "1122")
                {
                    this.Hide();
                    Main frm = new Main();
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Login not found");
                }
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}