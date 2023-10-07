namespace Clean_Resources {
    partial class FrmAddOrganization {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrganization));
            this.lblEmailOrganization = new System.Windows.Forms.Label();
            this.lblNumberOrganization = new System.Windows.Forms.Label();
            this.txtEmailOrganization = new System.Windows.Forms.TextBox();
            this.txtNumberOrganization = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.lblAddOrganization = new System.Windows.Forms.Label();
            this.btnAddOrganization = new System.Windows.Forms.Button();
            this.txtID_Organization = new System.Windows.Forms.TextBox();
            this.lblID_Organization = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmailOrganization
            // 
            this.lblEmailOrganization.AutoSize = true;
            this.lblEmailOrganization.Location = new System.Drawing.Point(16, 96);
            this.lblEmailOrganization.Name = "lblEmailOrganization";
            this.lblEmailOrganization.Size = new System.Drawing.Size(44, 18);
            this.lblEmailOrganization.TabIndex = 0;
            this.lblEmailOrganization.Text = "Email:";
            // 
            // lblNumberOrganization
            // 
            this.lblNumberOrganization.AutoSize = true;
            this.lblNumberOrganization.Location = new System.Drawing.Point(22, 128);
            this.lblNumberOrganization.Name = "lblNumberOrganization";
            this.lblNumberOrganization.Size = new System.Drawing.Size(38, 18);
            this.lblNumberOrganization.TabIndex = 1;
            this.lblNumberOrganization.Text = "Broj:";
            // 
            // txtEmailOrganization
            // 
            this.txtEmailOrganization.Location = new System.Drawing.Point(66, 93);
            this.txtEmailOrganization.Name = "txtEmailOrganization";
            this.txtEmailOrganization.Size = new System.Drawing.Size(371, 26);
            this.txtEmailOrganization.TabIndex = 2;
            this.txtEmailOrganization.TextChanged += new System.EventHandler(this.txtEmailOrganization_TextChanged);
            // 
            // txtNumberOrganization
            // 
            this.txtNumberOrganization.Location = new System.Drawing.Point(66, 125);
            this.txtNumberOrganization.Name = "txtNumberOrganization";
            this.txtNumberOrganization.Size = new System.Drawing.Size(371, 26);
            this.txtNumberOrganization.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 157);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(371, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(66, 187);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(371, 26);
            this.txtIBAN.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 160);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 18);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Naziv:";
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(14, 190);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(46, 18);
            this.lblIBAN.TabIndex = 7;
            this.lblIBAN.Text = "IBAN:";
            // 
            // lblAddOrganization
            // 
            this.lblAddOrganization.AutoSize = true;
            this.lblAddOrganization.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOrganization.Location = new System.Drawing.Point(108, 20);
            this.lblAddOrganization.Name = "lblAddOrganization";
            this.lblAddOrganization.Size = new System.Drawing.Size(238, 29);
            this.lblAddOrganization.TabIndex = 8;
            this.lblAddOrganization.Text = "Dodavanje organizacije";
            // 
            // btnAddOrganization
            // 
            this.btnAddOrganization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(190)))), ((int)(((byte)(209)))));
            this.btnAddOrganization.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrganization.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrganization.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddOrganization.Location = new System.Drawing.Point(0, 272);
            this.btnAddOrganization.Name = "btnAddOrganization";
            this.btnAddOrganization.Size = new System.Drawing.Size(464, 51);
            this.btnAddOrganization.TabIndex = 9;
            this.btnAddOrganization.Text = "Dodaj organizaciju";
            this.btnAddOrganization.UseVisualStyleBackColor = false;
            this.btnAddOrganization.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID_Organization
            // 
            this.txtID_Organization.Location = new System.Drawing.Point(66, 61);
            this.txtID_Organization.Name = "txtID_Organization";
            this.txtID_Organization.Size = new System.Drawing.Size(370, 26);
            this.txtID_Organization.TabIndex = 10;
            this.txtID_Organization.TextChanged += new System.EventHandler(this.txtID_Organization_TextChanged);
            // 
            // lblID_Organization
            // 
            this.lblID_Organization.AutoSize = true;
            this.lblID_Organization.Location = new System.Drawing.Point(32, 64);
            this.lblID_Organization.Name = "lblID_Organization";
            this.lblID_Organization.Size = new System.Drawing.Size(28, 18);
            this.lblID_Organization.TabIndex = 11;
            this.lblID_Organization.Text = "ID:";
            // 
            // FrmAddOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(464, 323);
            this.Controls.Add(this.lblID_Organization);
            this.Controls.Add(this.txtID_Organization);
            this.Controls.Add(this.btnAddOrganization);
            this.Controls.Add(this.lblAddOrganization);
            this.Controls.Add(this.lblIBAN);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtIBAN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumberOrganization);
            this.Controls.Add(this.txtEmailOrganization);
            this.Controls.Add(this.lblNumberOrganization);
            this.Controls.Add(this.lblEmailOrganization);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddOrganization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje organizacije";
            this.Load += new System.EventHandler(this.FrmAddOrganization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailOrganization;
        private System.Windows.Forms.Label lblNumberOrganization;
        private System.Windows.Forms.TextBox txtEmailOrganization;
        private System.Windows.Forms.TextBox txtNumberOrganization;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Label lblAddOrganization;
        private System.Windows.Forms.Button btnAddOrganization;
        private System.Windows.Forms.TextBox txtID_Organization;
        private System.Windows.Forms.Label lblID_Organization;
    }
}