namespace Clean_Resources {
    partial class FrmAddClient {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddClient));
            this.lblType = new System.Windows.Forms.Label();
            this.btnOrganization = new System.Windows.Forms.Button();
            this.btnSingleton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblType.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblType.Location = new System.Drawing.Point(60, 29);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(208, 45);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Tip klijenta?";
            // 
            // btnOrganization
            // 
            this.btnOrganization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(190)))), ((int)(((byte)(209)))));
            this.btnOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganization.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganization.Location = new System.Drawing.Point(40, 107);
            this.btnOrganization.Name = "btnOrganization";
            this.btnOrganization.Size = new System.Drawing.Size(97, 41);
            this.btnOrganization.TabIndex = 1;
            this.btnOrganization.Text = "Tvrtka";
            this.btnOrganization.UseVisualStyleBackColor = false;
            this.btnOrganization.Click += new System.EventHandler(this.btnOrganization_Click);
            // 
            // btnSingleton
            // 
            this.btnSingleton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(190)))), ((int)(((byte)(209)))));
            this.btnSingleton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleton.Location = new System.Drawing.Point(194, 107);
            this.btnSingleton.Name = "btnSingleton";
            this.btnSingleton.Size = new System.Drawing.Size(97, 41);
            this.btnSingleton.TabIndex = 2;
            this.btnSingleton.Text = "Pojedinac";
            this.btnSingleton.UseVisualStyleBackColor = false;
            this.btnSingleton.Click += new System.EventHandler(this.btnSingleton_Click);
            // 
            // FrmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(329, 177);
            this.Controls.Add(this.btnSingleton);
            this.Controls.Add(this.btnOrganization);
            this.Controls.Add(this.lblType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje klijenta";
            this.Load += new System.EventHandler(this.FrmAddClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnOrganization;
        private System.Windows.Forms.Button btnSingleton;
    }
}