namespace Clean_Resources {
    partial class FrmAddSingleton {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddSingleton));
            this.lblAddSingleton = new System.Windows.Forms.Label();
            this.lblID_Singleton = new System.Windows.Forms.Label();
            this.lblEmailSingleton = new System.Windows.Forms.Label();
            this.lblNumberSingleton = new System.Windows.Forms.Label();
            this.txtID_Singleton = new System.Windows.Forms.TextBox();
            this.txtEmailSingleton = new System.Windows.Forms.TextBox();
            this.txtNumberSingleton = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnAddSingleton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddSingleton
            // 
            this.lblAddSingleton.AutoSize = true;
            this.lblAddSingleton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSingleton.Location = new System.Drawing.Point(123, 20);
            this.lblAddSingleton.Name = "lblAddSingleton";
            this.lblAddSingleton.Size = new System.Drawing.Size(213, 29);
            this.lblAddSingleton.TabIndex = 9;
            this.lblAddSingleton.Text = "Dodavanje pojedinca";
            // 
            // lblID_Singleton
            // 
            this.lblID_Singleton.AutoSize = true;
            this.lblID_Singleton.Location = new System.Drawing.Point(32, 64);
            this.lblID_Singleton.Name = "lblID_Singleton";
            this.lblID_Singleton.Size = new System.Drawing.Size(28, 18);
            this.lblID_Singleton.TabIndex = 12;
            this.lblID_Singleton.Text = "ID:";
            // 
            // lblEmailSingleton
            // 
            this.lblEmailSingleton.AutoSize = true;
            this.lblEmailSingleton.Location = new System.Drawing.Point(16, 96);
            this.lblEmailSingleton.Name = "lblEmailSingleton";
            this.lblEmailSingleton.Size = new System.Drawing.Size(44, 18);
            this.lblEmailSingleton.TabIndex = 13;
            this.lblEmailSingleton.Text = "Email:";
            //this.lblEmailSingleton.Click += new System.EventHandler(this.lblEmailSingleton_Click);
            // 
            // lblNumberSingleton
            // 
            this.lblNumberSingleton.AutoSize = true;
            this.lblNumberSingleton.Location = new System.Drawing.Point(22, 128);
            this.lblNumberSingleton.Name = "lblNumberSingleton";
            this.lblNumberSingleton.Size = new System.Drawing.Size(38, 18);
            this.lblNumberSingleton.TabIndex = 14;
            this.lblNumberSingleton.Text = "Broj:";
            // 
            // txtID_Singleton
            // 
            this.txtID_Singleton.Location = new System.Drawing.Point(66, 61);
            this.txtID_Singleton.Name = "txtID_Singleton";
            this.txtID_Singleton.Size = new System.Drawing.Size(370, 26);
            this.txtID_Singleton.TabIndex = 15;
            //this.txtID_Singleton.TextChanged += new System.EventHandler(this.txtID_Singleton_TextChanged);
            // 
            // txtEmailSingleton
            // 
            this.txtEmailSingleton.Location = new System.Drawing.Point(66, 93);
            this.txtEmailSingleton.Name = "txtEmailSingleton";
            this.txtEmailSingleton.Size = new System.Drawing.Size(371, 26);
            this.txtEmailSingleton.TabIndex = 12;
            // 
            // txtNumberSingleton
            // 
            this.txtNumberSingleton.Location = new System.Drawing.Point(66, 125);
            this.txtNumberSingleton.Name = "txtNumberSingleton";
            this.txtNumberSingleton.Size = new System.Drawing.Size(371, 26);
            this.txtNumberSingleton.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(66, 157);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(371, 26);
            this.txtFirstName.TabIndex = 16;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(66, 189);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(371, 26);
            this.txtLastName.TabIndex = 17;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(25, 160);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 18);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "Ime:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(1, 192);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 18);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Prezime:";
            // 
            // btnAddSingleton
            // 
            this.btnAddSingleton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(190)))), ((int)(((byte)(209)))));
            this.btnAddSingleton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddSingleton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSingleton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSingleton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddSingleton.Location = new System.Drawing.Point(0, 270);
            this.btnAddSingleton.Name = "btnAddSingleton";
            this.btnAddSingleton.Size = new System.Drawing.Size(464, 51);
            this.btnAddSingleton.TabIndex = 20;
            this.btnAddSingleton.Text = "Dodaj pojedinca";
            this.btnAddSingleton.UseVisualStyleBackColor = false;
            this.btnAddSingleton.Click += new System.EventHandler(this.btnAddSingleton_Click);
            // 
            // FrmAddSingleton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.btnAddSingleton);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtNumberSingleton);
            this.Controls.Add(this.txtEmailSingleton);
            this.Controls.Add(this.txtID_Singleton);
            this.Controls.Add(this.lblNumberSingleton);
            this.Controls.Add(this.lblEmailSingleton);
            this.Controls.Add(this.lblID_Singleton);
            this.Controls.Add(this.lblAddSingleton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAddSingleton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje pojedinca";
            this.Load += new System.EventHandler(this.FrmAddSingleton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddSingleton;
        private System.Windows.Forms.Label lblID_Singleton;
        private System.Windows.Forms.Label lblEmailSingleton;
        private System.Windows.Forms.Label lblNumberSingleton;
        private System.Windows.Forms.TextBox txtID_Singleton;
        private System.Windows.Forms.TextBox txtEmailSingleton;
        private System.Windows.Forms.TextBox txtNumberSingleton;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnAddSingleton;
    }
}