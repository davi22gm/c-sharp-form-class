namespace Initial_Form
{
    partial class RCustomer
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RCustomer));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.mktPostal = new System.Windows.Forms.MaskedTextBox();
            this.mktPhone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRCustomer = new System.Windows.Forms.DataGridView();
            this.erpRCustomer = new System.Windows.Forms.ErrorProvider(this.components);
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 220);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.txtConPass);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.cmbStatus);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cmbGender);
            this.tabPage1.Controls.Add(this.mktPostal);
            this.tabPage1.Controls.Add(this.mktPhone);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtPass);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtConEmail);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtLName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(478, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 31);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(592, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 31);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Windowed"});
            this.cmbStatus.Location = new System.Drawing.Point(575, 31);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(105, 24);
            this.cmbStatus.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(572, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Marital Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(418, 31);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(128, 24);
            this.cmbGender.TabIndex = 3;
            // 
            // mktPostal
            // 
            this.mktPostal.Location = new System.Drawing.Point(575, 88);
            this.mktPostal.Mask = "00000-999";
            this.mktPostal.Name = "mktPostal";
            this.mktPostal.Size = new System.Drawing.Size(105, 23);
            this.mktPostal.TabIndex = 8;
            // 
            // mktPhone
            // 
            this.mktPhone.Location = new System.Drawing.Point(418, 88);
            this.mktPhone.Mask = "(99) 00000-0000";
            this.mktPhone.Name = "mktPhone";
            this.mktPhone.Size = new System.Drawing.Size(128, 23);
            this.mktPhone.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Postal Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Phone";
            // 
            // txtConPass
            // 
            this.txtConPass.Location = new System.Drawing.Point(211, 146);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(177, 23);
            this.txtConPass.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirm Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 146);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(177, 23);
            this.txtPass.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // txtConEmail
            // 
            this.txtConEmail.Location = new System.Drawing.Point(211, 88);
            this.txtConEmail.Name = "txtConEmail";
            this.txtConEmail.Size = new System.Drawing.Size(177, 23);
            this.txtConEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(211, 31);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(177, 23);
            this.txtLName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 23);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRCustomer);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRCustomer
            // 
            this.dgvRCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnName,
            this.clnLName,
            this.clnGender,
            this.clnStatus,
            this.clnEmail,
            this.clnPhone,
            this.clnPostal,
            this.clnPass});
            this.dgvRCustomer.Location = new System.Drawing.Point(3, 6);
            this.dgvRCustomer.Name = "dgvRCustomer";
            this.dgvRCustomer.Size = new System.Drawing.Size(677, 179);
            this.dgvRCustomer.TabIndex = 0;
            // 
            // erpRCustomer
            // 
            this.erpRCustomer.ContainerControl = this;
            // 
            // clnName
            // 
            this.clnName.HeaderText = "Name";
            this.clnName.Name = "clnName";
            this.clnName.Width = 80;
            // 
            // clnLName
            // 
            this.clnLName.HeaderText = "Last Name";
            this.clnLName.Name = "clnLName";
            // 
            // clnGender
            // 
            this.clnGender.HeaderText = "Gender";
            this.clnGender.Name = "clnGender";
            this.clnGender.Width = 65;
            // 
            // clnStatus
            // 
            this.clnStatus.HeaderText = "Marital Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.Width = 75;
            // 
            // clnEmail
            // 
            this.clnEmail.HeaderText = "E-mail";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.Width = 130;
            // 
            // clnPhone
            // 
            this.clnPhone.HeaderText = "Phone";
            this.clnPhone.Name = "clnPhone";
            // 
            // clnPostal
            // 
            this.clnPostal.HeaderText = "Postal Code";
            this.clnPostal.Name = "clnPostal";
            // 
            // clnPass
            // 
            this.clnPass.HeaderText = "Password";
            this.clnPass.Name = "clnPass";
            // 
            // RCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 243);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Customer_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.MaskedTextBox mktPostal;
        private System.Windows.Forms.MaskedTextBox mktPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvRCustomer;
        private System.Windows.Forms.ErrorProvider erpRCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPass;
    }
}

