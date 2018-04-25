namespace LocalDB
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
            this.components = new System.ComponentModel.Container();
            this.btnCreateLocalDB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnInsertData = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chkDeleteDB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateLocalDB
            // 
            this.btnCreateLocalDB.Location = new System.Drawing.Point(38, 12);
            this.btnCreateLocalDB.Name = "btnCreateLocalDB";
            this.btnCreateLocalDB.Size = new System.Drawing.Size(167, 147);
            this.btnCreateLocalDB.TabIndex = 0;
            this.btnCreateLocalDB.Text = "create new local database";
            this.btnCreateLocalDB.UseVisualStyleBackColor = true;
            this.btnCreateLocalDB.Click += new System.EventHandler(this.btnCreateLocalDB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1660, 1054);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(530, 12);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(454, 147);
            this.btnRetrieve.TabIndex = 2;
            this.btnRetrieve.Text = "Retrieve Data";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // btnInsertData
            // 
            this.btnInsertData.Location = new System.Drawing.Point(1000, 12);
            this.btnInsertData.Name = "btnInsertData";
            this.btnInsertData.Size = new System.Drawing.Size(454, 147);
            this.btnInsertData.TabIndex = 3;
            this.btnInsertData.Text = "Insert Data";
            this.btnInsertData.UseVisualStyleBackColor = true;
            this.btnInsertData.Click += new System.EventHandler(this.btnInsertData_Click);
            // 
            // chkDeleteDB
            // 
            this.chkDeleteDB.AutoSize = true;
            this.chkDeleteDB.Location = new System.Drawing.Point(211, 72);
            this.chkDeleteDB.Name = "chkDeleteDB";
            this.chkDeleteDB.Size = new System.Drawing.Size(141, 29);
            this.chkDeleteDB.TabIndex = 4;
            this.chkDeleteDB.Text = "Delete DB";
            this.chkDeleteDB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 1272);
            this.Controls.Add(this.chkDeleteDB);
            this.Controls.Add(this.btnInsertData);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCreateLocalDB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateLocalDB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnInsertData;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.CheckBox chkDeleteDB;
    }
}

