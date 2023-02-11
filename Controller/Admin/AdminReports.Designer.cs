namespace E_Appartments.Controller.Admin
{
    partial class AdminReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lb_dashboard = new System.Windows.Forms.Label();
            this.lbTenants = new System.Windows.Forms.Label();
            this.lbApartments = new System.Windows.Forms.Label();
            this.lbLease = new System.Windows.Forms.Label();
            this.lbReports = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(483, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 51);
            this.button1.TabIndex = 63;
            this.button1.Text = "Apartment Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(483, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 51);
            this.button2.TabIndex = 64;
            this.button2.Text = "Chief Occupants Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(483, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 51);
            this.button3.TabIndex = 65;
            this.button3.Text = "Customer Details";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(483, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 51);
            this.button4.TabIndex = 66;
            this.button4.Text = "Lease Details";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lb_dashboard
            // 
            this.lb_dashboard.AutoSize = true;
            this.lb_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dashboard.ForeColor = System.Drawing.Color.White;
            this.lb_dashboard.Location = new System.Drawing.Point(68, 204);
            this.lb_dashboard.Name = "lb_dashboard";
            this.lb_dashboard.Size = new System.Drawing.Size(88, 20);
            this.lb_dashboard.TabIndex = 58;
            this.lb_dashboard.Text = "Dashboard";
            this.lb_dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTenants
            // 
            this.lbTenants.AutoSize = true;
            this.lbTenants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenants.ForeColor = System.Drawing.Color.White;
            this.lbTenants.Location = new System.Drawing.Point(68, 248);
            this.lbTenants.Name = "lbTenants";
            this.lbTenants.Size = new System.Drawing.Size(67, 20);
            this.lbTenants.TabIndex = 64;
            this.lbTenants.Text = "Tenants";
            this.lbTenants.Click += new System.EventHandler(this.lbTenants_Click);
            // 
            // lbApartments
            // 
            this.lbApartments.AutoSize = true;
            this.lbApartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApartments.ForeColor = System.Drawing.Color.White;
            this.lbApartments.Location = new System.Drawing.Point(68, 290);
            this.lbApartments.Name = "lbApartments";
            this.lbApartments.Size = new System.Drawing.Size(92, 20);
            this.lbApartments.TabIndex = 65;
            this.lbApartments.Text = "Apartments";
            this.lbApartments.Click += new System.EventHandler(this.lbApartments_Click);
            // 
            // lbLease
            // 
            this.lbLease.AutoSize = true;
            this.lbLease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLease.ForeColor = System.Drawing.Color.White;
            this.lbLease.Location = new System.Drawing.Point(68, 338);
            this.lbLease.Name = "lbLease";
            this.lbLease.Size = new System.Drawing.Size(53, 20);
            this.lbLease.TabIndex = 66;
            this.lbLease.Text = "Lease";
            this.lbLease.Click += new System.EventHandler(this.lbLease_Click);
            // 
            // lbReports
            // 
            this.lbReports.AutoSize = true;
            this.lbReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReports.ForeColor = System.Drawing.Color.Black;
            this.lbReports.Location = new System.Drawing.Point(68, 383);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(73, 20);
            this.lbReports.TabIndex = 68;
            this.lbReports.Text = "Reports";
            this.lbReports.Click += new System.EventHandler(this.lbReports_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbReports);
            this.panel2.Controls.Add(this.lbApartments);
            this.panel2.Controls.Add(this.lbLease);
            this.panel2.Controls.Add(this.lb_dashboard);
            this.panel2.Controls.Add(this.lbTenants);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 608);
            this.panel2.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::E_Appartments.Properties.Resources.Screenshot_2023_01_17_233127;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 163);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // AdminReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1004, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdminReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminReports";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lb_dashboard;
        private System.Windows.Forms.Label lbTenants;
        private System.Windows.Forms.Label lbApartments;
        private System.Windows.Forms.Label lbLease;
        private System.Windows.Forms.Label lbReports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}