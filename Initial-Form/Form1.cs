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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2 register = new Form2(); //Open Register Form
            register.Naame = txtNaame.Text;
            register.Gender = cmbGender.Text;
            register.Status = cmbStatus.Text;
            register.Phone = txtPhone.Text;
            register.Country = txtCountry.Text;
            register.Email = txtEmail.Text;
            register.ConEmail = txtConEmail.Text;

            register.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete all fields on the form?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtNaame.Text = "";
                cmbGender.SelectedItem = null;
                cmbStatus.SelectedItem = null;
                txtPhone.Text = "";
                txtCountry.Text = "";
                txtEmail.Text = "";
                txtConEmail.Text = "";
                txtPass.Text = "";
                txtConPass.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
