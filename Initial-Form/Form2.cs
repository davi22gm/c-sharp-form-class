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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string Naame { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string ConEmail { get; set; }
        public string Pass { get; set; }
        public string ConPass { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!this.Naame.Equals(""))
            {
                txtNaame.Text = this.Naame;
            }

            if (!this.Gender.Equals(""))
            {
                txtGender.Text = this.Gender;
            }

            if (!this.Status.Equals(""))
            {
                txtStatus.Text = this.Status;
            }

            if (!this.Phone.Equals(""))
            {
                txtPhone.Text = this.Phone;
            }

            if (!this.Country.Equals(""))
            {
                txtCountry.Text = this.Country;
            }

            if (!this.Email.Equals(""))
            {
                txtEmail.Text = this.Email;
            }

            if (!this.ConEmail.Equals(""))
            {
                txtConEmail.Text = this.ConEmail;
            }
        }
    }
}
