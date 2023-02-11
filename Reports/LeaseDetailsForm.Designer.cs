
namespace E_Appartments.Reports
{
    partial class LeaseDetailsForm
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
            this.reportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnprint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer3
            // 
            this.reportViewer3.ActiveViewIndex = -1;
            this.reportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer3.Location = new System.Drawing.Point(38, 76);
            this.reportViewer3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(1023, 424);
            this.reportViewer3.TabIndex = 3;
            this.reportViewer3.ToolPanelWidth = 150;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.Lime;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(38, 39);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(138, 32);
            this.btnprint.TabIndex = 2;
            this.btnprint.Text = "Generate Report";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1013, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 50);
            this.label2.TabIndex = 126;
            this.label2.Text = "<";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LeaseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.btnprint);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LeaseDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaseDetailsForm";
            this.Load += new System.EventHandler(this.LeaseDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer3;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label label2;
    }
}