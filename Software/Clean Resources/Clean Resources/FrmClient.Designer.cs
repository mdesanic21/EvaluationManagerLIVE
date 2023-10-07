namespace Clean_Resources {
    partial class FrmClients {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClients));
            this.dgvSingletons = new System.Windows.Forms.DataGridView();
            this.lblSingletons = new System.Windows.Forms.Label();
            this.dgvOrganization = new System.Windows.Forms.DataGridView();
            this.lblOrganizations = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnResetFrmClient = new System.Windows.Forms.Button();
            this.txtSearchOrganizations = new System.Windows.Forms.TextBox();
            this.txtSearchSingleton = new System.Windows.Forms.TextBox();
            this.lblSearchSingleton = new System.Windows.Forms.Label();
            this.lblSearchOrganization = new System.Windows.Forms.Label();
            this.lblSignOut = new System.Windows.Forms.Label();
            this.btnEditClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingletons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSingletons
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSingletons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSingletons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSingletons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSingletons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.dgvSingletons.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.dgvSingletons.Location = new System.Drawing.Point(12, 94);
            this.dgvSingletons.Name = "dgvSingletons";
            this.dgvSingletons.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvSingletons.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSingletons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSingletons.Size = new System.Drawing.Size(1040, 220);
            this.dgvSingletons.TabIndex = 0;
            this.dgvSingletons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSingletons_CellContentClick);
            // 
            // lblSingletons
            // 
            this.lblSingletons.AutoEllipsis = true;
            this.lblSingletons.AutoSize = true;
            this.lblSingletons.BackColor = System.Drawing.Color.Transparent;
            this.lblSingletons.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingletons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblSingletons.Location = new System.Drawing.Point(5, 53);
            this.lblSingletons.Name = "lblSingletons";
            this.lblSingletons.Size = new System.Drawing.Size(137, 38);
            this.lblSingletons.TabIndex = 1;
            this.lblSingletons.Text = "Pojedinci:";
            // 
            // dgvOrganization
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrganization.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrganization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrganization.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.dgvOrganization.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.dgvOrganization.Location = new System.Drawing.Point(12, 358);
            this.dgvOrganization.Name = "dgvOrganization";
            this.dgvOrganization.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvOrganization.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrganization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganization.Size = new System.Drawing.Size(1040, 220);
            this.dgvOrganization.TabIndex = 2;
            // 
            // lblOrganizations
            // 
            this.lblOrganizations.AutoEllipsis = true;
            this.lblOrganizations.AutoSize = true;
            this.lblOrganizations.BackColor = System.Drawing.Color.Transparent;
            this.lblOrganizations.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblOrganizations.Location = new System.Drawing.Point(5, 317);
            this.lblOrganizations.Name = "lblOrganizations";
            this.lblOrganizations.Size = new System.Drawing.Size(112, 38);
            this.lblOrganizations.TabIndex = 3;
            this.lblOrganizations.Text = "Tvrtke:";
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(190)))), ((int)(((byte)(209)))));
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Location = new System.Drawing.Point(901, 624);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(151, 34);
            this.btnAddClient.TabIndex = 4;
            this.btnAddClient.Text = "Dodaj klijenta";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnResetFrmClient
            // 
            this.btnResetFrmClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(190)))), ((int)(((byte)(209)))));
            this.btnResetFrmClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFrmClient.Location = new System.Drawing.Point(12, 584);
            this.btnResetFrmClient.Name = "btnResetFrmClient";
            this.btnResetFrmClient.Size = new System.Drawing.Size(151, 34);
            this.btnResetFrmClient.TabIndex = 5;
            this.btnResetFrmClient.Text = "Resetiraj";
            this.btnResetFrmClient.UseVisualStyleBackColor = false;
            this.btnResetFrmClient.Click += new System.EventHandler(this.btnResetFrmClient_Click);
            // 
            // txtSearchOrganizations
            // 
            this.txtSearchOrganizations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.txtSearchOrganizations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchOrganizations.ForeColor = System.Drawing.Color.Black;
            this.txtSearchOrganizations.Location = new System.Drawing.Point(771, 326);
            this.txtSearchOrganizations.Name = "txtSearchOrganizations";
            this.txtSearchOrganizations.Size = new System.Drawing.Size(281, 26);
            this.txtSearchOrganizations.TabIndex = 6;
            this.txtSearchOrganizations.TextChanged += new System.EventHandler(this.txtSearchOrganizations_TextChanged);
            // 
            // txtSearchSingleton
            // 
            this.txtSearchSingleton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.txtSearchSingleton.Location = new System.Drawing.Point(771, 62);
            this.txtSearchSingleton.Name = "txtSearchSingleton";
            this.txtSearchSingleton.Size = new System.Drawing.Size(281, 26);
            this.txtSearchSingleton.TabIndex = 7;
            this.txtSearchSingleton.TextChanged += new System.EventHandler(this.txtSearchSingleton_TextChanged);
            // 
            // lblSearchSingleton
            // 
            this.lblSearchSingleton.AutoSize = true;
            this.lblSearchSingleton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchSingleton.ForeColor = System.Drawing.Color.Black;
            this.lblSearchSingleton.Location = new System.Drawing.Point(700, 64);
            this.lblSearchSingleton.Name = "lblSearchSingleton";
            this.lblSearchSingleton.Size = new System.Drawing.Size(65, 19);
            this.lblSearchSingleton.TabIndex = 8;
            this.lblSearchSingleton.Text = "Pretraži:";
            // 
            // lblSearchOrganization
            // 
            this.lblSearchOrganization.AutoSize = true;
            this.lblSearchOrganization.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOrganization.ForeColor = System.Drawing.Color.Black;
            this.lblSearchOrganization.Location = new System.Drawing.Point(700, 327);
            this.lblSearchOrganization.Name = "lblSearchOrganization";
            this.lblSearchOrganization.Size = new System.Drawing.Size(65, 19);
            this.lblSearchOrganization.TabIndex = 9;
            this.lblSearchOrganization.Text = "Pretraži:";
            // 
            // lblSignOut
            // 
            this.lblSignOut.AutoSize = true;
            this.lblSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignOut.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblSignOut.Location = new System.Drawing.Point(1001, 9);
            this.lblSignOut.Name = "lblSignOut";
            this.lblSignOut.Size = new System.Drawing.Size(51, 18);
            this.lblSignOut.TabIndex = 10;
            this.lblSignOut.Text = "Odjava";
            this.lblSignOut.Click += new System.EventHandler(this.lblSignOut_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Location = new System.Drawing.Point(901, 584);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(151, 34);
            this.btnEditClient.TabIndex = 11;
            this.btnEditClient.Text = "Uredi klijenta";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // FrmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1066, 666);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.lblSignOut);
            this.Controls.Add(this.lblSearchOrganization);
            this.Controls.Add(this.lblSearchSingleton);
            this.Controls.Add(this.txtSearchSingleton);
            this.Controls.Add(this.txtSearchOrganizations);
            this.Controls.Add(this.btnResetFrmClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lblOrganizations);
            this.Controls.Add(this.dgvOrganization);
            this.Controls.Add(this.lblSingletons);
            this.Controls.Add(this.dgvSingletons);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klijenti";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingletons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSingletons;
        private System.Windows.Forms.Label lblSingletons;
        private System.Windows.Forms.DataGridView dgvOrganization;
        private System.Windows.Forms.Label lblOrganizations;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnResetFrmClient;
        private System.Windows.Forms.TextBox txtSearchOrganizations;
        private System.Windows.Forms.TextBox txtSearchSingleton;
        private System.Windows.Forms.Label lblSearchSingleton;
        private System.Windows.Forms.Label lblSearchOrganization;
        private System.Windows.Forms.Label lblSignOut;
        private System.Windows.Forms.Button btnEditClient;
    }
}