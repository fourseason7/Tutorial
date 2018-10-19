namespace fileOpen
{
    partial class Form1
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
            this.btnGoogleSearch = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUPSTracking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoogleSearch
            // 
            this.btnGoogleSearch.Location = new System.Drawing.Point(46, 202);
            this.btnGoogleSearch.Name = "btnGoogleSearch";
            this.btnGoogleSearch.Size = new System.Drawing.Size(159, 56);
            this.btnGoogleSearch.TabIndex = 0;
            this.btnGoogleSearch.Text = "Google Search";
            this.btnGoogleSearch.UseVisualStyleBackColor = true;
            this.btnGoogleSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(46, 166);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(455, 20);
            this.txtString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Google Search String or UPS Tracking#.:";
            // 
            // btnUPSTracking
            // 
            this.btnUPSTracking.Location = new System.Drawing.Point(211, 202);
            this.btnUPSTracking.Name = "btnUPSTracking";
            this.btnUPSTracking.Size = new System.Drawing.Size(159, 56);
            this.btnUPSTracking.TabIndex = 3;
            this.btnUPSTracking.Text = "UPS Tracking";
            this.btnUPSTracking.UseVisualStyleBackColor = true;
            this.btnUPSTracking.Click += new System.EventHandler(this.btnUPSTracking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 399);
            this.Controls.Add(this.btnUPSTracking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnGoogleSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoogleSearch;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUPSTracking;
    }
}

