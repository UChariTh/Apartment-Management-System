
namespace E_Appartments.Reports
{
    partial class OccupantDetailsForm
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
            this.reportViewer4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnprint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer4
            // 
            this.reportViewer4.ActiveViewIndex = -1;
            this.reportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer4.Location = new System.Drawing.Point(38, 76);
            this.reportViewer4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(1023, 424);
            this.reportViewer4.TabIndex = 5;
            this.reportViewer4.ToolPanelWidth = 150;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(38, 39);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(155, 32);
            this.btnprint.TabIndex = 4;
            this.btnprint.Text = "Generate Report";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1013, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 50);
            this.label2.TabIndex = 126;
            this.label2.Text = "<";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OccupantDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.btnprint);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OccupantDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OccupantDetailsForm";
            this.Load += new System.EventHandler(this.OccupantDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer4;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label label2;
    }
}