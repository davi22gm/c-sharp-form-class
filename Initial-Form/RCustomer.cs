using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Initial_Form
{
    public partial class RCustomer : Form
    {
        static String path = AppDomain.CurrentDomain.BaseDirectory + "data";
        static String file = path + "/Customer.txt";
        int valid = 0;

        public RCustomer()
        {
            InitializeComponent();
        }

        private void Customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                dgvRCustomer.Rows.Clear();
                using (StreamReader sr = new StreamReader(file))
                {
                    int line = 0;
                    string ln;

                    while ((ln = sr.ReadLine()) != null)
                    {
                        string[] fields = ln.Split('|');

                        dgvRCustomer.Rows.Add(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5], fields[6], fields[7]);

                        line++;
                    }
                    sr.Close();
                    MessageBox.Show(line + " Lines Found.", "Notification");
                }
            }
            else
            {
                MessageBox.Show("No File Found", "Notification");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete ALL fields?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                valid = 0;
                txtName.Text = null;
                txtLName.Text = null;
                cmbGender.Text = null;
                cmbStatus.Text = null;
                txtEmail.Text = null;
                txtConEmail.Text = null;
                mktPhone.Text = null;
                mktPostal.Text = null;
                txtPass.Text = null;
                txtConPass.Text = null;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //NAME
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                erpRCustomer.SetError(txtName, "Name is required");

                txtName.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRCustomer.SetError(txtName, "");

                txtName.BackColor = Color.FromName("Window");
                valid++;
            }

            //LAST NAME
            if (String.IsNullOrWhiteSpace(txtLName.Text))
            {
                erpRCustomer.SetError(txtLName, "Last Name is required");

                txtLName.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRCustomer.SetError(txtLName, "");

                txtLName.BackColor = Color.FromName("Window");
                valid++;
            }

            //GENDER
            if (String.IsNullOrWhiteSpace(cmbGender.Text))
            {
                erpRCustomer.SetError(cmbGender, "Gender is required");

                cmbGender.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRCustomer.SetError(cmbGender, "");

                cmbGender.BackColor = Color.FromName("Window");
                valid++;
            }

            //MARITAL STATUS
            if (String.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                erpRCustomer.SetError(cmbStatus, "Marital Status is required");

                cmbStatus.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRCustomer.SetError(cmbStatus, "");

                cmbStatus.BackColor = Color.FromName("Window");
                valid++;
            }

            //EMAIL
            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                erpRCustomer.SetError(txtEmail, "E-mail is required");

                txtEmail.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRCustomer.SetError(txtEmail, "");

                txtEmail.BackColor = Color.FromName("Window");
                valid++;
            }

            //CONFIRM EMAIL
            if (String.IsNullOrWhiteSpace(txtConEmail.Text))
            {
                erpRCustomer.SetError(txtConEmail, "Confirm E-mail is required");

                txtConEmail.BackColor = Color.FromArgb(250, 128, 114);
            }
            else if (txtEmail.Text != txtConEmail.Text)
            {
                erpRCustomer.SetError(txtConEmail, "E-mails does not match");

                txtConEmail.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRCustomer.SetError(txtConEmail, "");

                txtConEmail.BackColor = Color.FromName("Window");
                valid++;
            }

            //PHONE
            if (mktPhone.Text == "(  )      -")
            {
                erpRCustomer.SetError(mktPhone, "Phone is required");

                mktPhone.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRCustomer.SetError(mktPhone, "");

                mktPhone.BackColor = Color.FromName("Window");
                valid++;
            }

            //POSTAL CODE
            if (mktPostal.Text == "     -")
            {
                erpRCustomer.SetError(mktPostal, "Postal Code is required");

                mktPostal.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRCustomer.SetError(mktPostal, "");

                mktPostal.BackColor = Color.FromName("Window");
                valid++;
            }

            //PASSWORD
            if (String.IsNullOrWhiteSpace(txtPass.Text))
            {
                erpRCustomer.SetError(txtPass, "Password is required");

                txtPass.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRCustomer.SetError(txtPass, "");

                txtPass.BackColor = Color.FromName("Window");
                valid++;
            }

            //CONFIRM PASSWORD
            if (String.IsNullOrWhiteSpace(txtConPass.Text))
            {
                erpRCustomer.SetError(txtConPass, "Confirm Password is required");

                txtConPass.BackColor = Color.FromArgb(250, 128, 114);
            }
            else if (txtPass.Text != txtConPass.Text)
            {
                erpRCustomer.SetError(txtConPass, "Passwords does not match");

                txtConPass.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRCustomer.SetError(txtConPass, "");

                txtConPass.BackColor = Color.FromName("Window");
                valid++;
            }

            if(valid == 10)
            {
                bool checkDirExist = Directory.Exists(path);
                if (!checkDirExist)
                Directory.CreateDirectory(path);

                String line = txtName.Text + "|" + txtLName.Text + "|" + cmbGender.Text + "|" + cmbStatus.Text + "|" + txtEmail.Text + "|" + mktPhone.Text + "|" + mktPostal.Text + "|" + txtPass.Text;

                bool checkFileExist = File.Exists(file);

                if (!checkFileExist)
                {
                    using (StreamWriter sw = File.CreateText(file))
                    {
                        sw.WriteLine(line);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(file))
                    {
                        sw.WriteLine(line);
                    }
                }
                MessageBox.Show("Data Saved Successfully!");
            }
            else
            {
                MessageBox.Show("Couldn't Save! Incomplete Data! Complete All the Fields Correctly!");
            }
        }
    }
}
