namespace Initial_Form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNaame = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConEmail = new System.Windows.Forms.TextBox();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblConEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblConPass = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNaame
            // 
            this.txtNaame.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtNaame.Location = new System.Drawing.Point(20, 50);
            this.txtNaame.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaame.Name = "txtNaame";
            this.txtNaame.Size = new System.Drawing.Size(423, 25);
            this.txtNaame.TabIndex = 0;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Widow"});
            this.cmbStatus.Location = new System.Drawing.Point(241, 114);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(202, 25);
            this.cmbStatus.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtPass.Location = new System.Drawing.Point(20, 320);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(202, 25);
            this.txtPass.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtEmail.Location = new System.Drawing.Point(20, 249);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 25);
            this.txtEmail.TabIndex = 5;
            // 
            // txtConEmail
            // 
            this.txtConEmail.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtConEmail.Location = new System.Drawing.Point(241, 249);
            this.txtConEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtConEmail.Name = "txtConEmail";
            this.txtConEmail.Size = new System.Drawing.Size(202, 25);
            this.txtConEmail.TabIndex = 6;
            // 
            // txtConPass
            // 
            this.txtConPass.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtConPass.Location = new System.Drawing.Point(241, 320);
            this.txtConPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(202, 25);
            this.txtConPass.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblName.Location = new System.Drawing.Point(17, 29);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 17);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Full Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblEmail.Location = new System.Drawing.Point(17, 228);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail";
            // 
            // lblConEmail
            // 
            this.lblConEmail.AutoSize = true;
            this.lblConEmail.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblConEmail.Location = new System.Drawing.Point(238, 228);
            this.lblConEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConEmail.Name = "lblConEmail";
            this.lblConEmail.Size = new System.Drawing.Size(106, 17);
            this.lblConEmail.TabIndex = 11;
            this.lblConEmail.Text = "Confirm E-mail";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblPass.Location = new System.Drawing.Point(17, 299);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(74, 17);
            this.lblPass.TabIndex = 12;
            this.lblPass.Text = "Password";
            // 
            // lblConPass
            // 
            this.lblConPass.AutoSize = true;
            this.lblConPass.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblConPass.Location = new System.Drawing.Point(238, 299);
            this.lblConPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConPass.Name = "lblConPass";
            this.lblConPass.Size = new System.Drawing.Size(130, 17);
            this.lblConPass.TabIndex = 13;
            this.lblConPass.Text = "Confirm Password";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblStatus.Location = new System.Drawing.Point(238, 93);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 17);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Marital Status:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(345, 369);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(223, 369);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtPhone.Location = new System.Drawing.Point(20, 179);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(202, 25);
            this.txtPhone.TabIndex = 16;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtCountry.Location = new System.Drawing.Point(241, 179);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(202, 25);
            this.txtCountry.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label2.Location = new System.Drawing.Point(17, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label1.Location = new System.Drawing.Point(238, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Country";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(20, 369);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 34);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(20, 114);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(202, 25);
            this.cmbGender.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gender:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblConPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblConEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtConPass);
            this.Controls.Add(this.txtConEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtNaame);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaame;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConEmail;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblConEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblConPass;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label3;
    }
}

