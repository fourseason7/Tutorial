namespace PackingLabel
{
    partial class frmPackingLabel
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtItem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tblPackingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtQuantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPONo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtStatus = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpPackingDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPrint = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNew = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkSaveAndPrint = new MaterialSkin.Controls.MaterialCheckBox();
            this.itemNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pONoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTSolutionsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lTSolutionsDataSet = new PackingLabel.LTSolutionsDataSet();
            this.tblPackingTableAdapter = new PackingLabel.LTSolutionsDataSetTableAdapters.tblPackingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblPackingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTSolutionsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTSolutionsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(155, 190);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(86, 36);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Item.:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(100, 249);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(141, 36);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Quantity.:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(113, 315);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(128, 36);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "P/O No.:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(63, 375);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(178, 36);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Item Status.:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(36, 442);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(207, 36);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Packing Date.:";
            // 
            // txtItem
            // 
            this.txtItem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPackingBindingSource, "ItemNo", true));
            this.txtItem.Depth = 0;
            this.txtItem.Hint = "";
            this.txtItem.Location = new System.Drawing.Point(263, 190);
            this.txtItem.MaxLength = 32767;
            this.txtItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItem.Name = "txtItem";
            this.txtItem.PasswordChar = '\0';
            this.txtItem.SelectedText = "";
            this.txtItem.SelectionLength = 0;
            this.txtItem.SelectionStart = 0;
            this.txtItem.Size = new System.Drawing.Size(508, 41);
            this.txtItem.TabIndex = 0;
            this.txtItem.TabStop = false;
            this.txtItem.UseSystemPasswordChar = false;
            // 
            // tblPackingBindingSource
            // 
            this.tblPackingBindingSource.DataMember = "tblPacking";
            this.tblPackingBindingSource.DataSource = this.lTSolutionsDataSetBindingSource;
            // 
            // txtQuantity
            // 
            this.txtQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPackingBindingSource, "Quantity", true));
            this.txtQuantity.Depth = 0;
            this.txtQuantity.Hint = "";
            this.txtQuantity.Location = new System.Drawing.Point(263, 249);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.Size = new System.Drawing.Size(508, 41);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.TabStop = false;
            this.txtQuantity.UseSystemPasswordChar = false;
            // 
            // txtPONo
            // 
            this.txtPONo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPackingBindingSource, "PONo", true));
            this.txtPONo.Depth = 0;
            this.txtPONo.Hint = "";
            this.txtPONo.Location = new System.Drawing.Point(263, 315);
            this.txtPONo.MaxLength = 32767;
            this.txtPONo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.PasswordChar = '\0';
            this.txtPONo.SelectedText = "";
            this.txtPONo.SelectionLength = 0;
            this.txtPONo.SelectionStart = 0;
            this.txtPONo.Size = new System.Drawing.Size(508, 41);
            this.txtPONo.TabIndex = 2;
            this.txtPONo.TabStop = false;
            this.txtPONo.UseSystemPasswordChar = false;
            // 
            // txtStatus
            // 
            this.txtStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPackingBindingSource, "Status", true));
            this.txtStatus.Depth = 0;
            this.txtStatus.Hint = "";
            this.txtStatus.Location = new System.Drawing.Point(263, 375);
            this.txtStatus.MaxLength = 32767;
            this.txtStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.SelectedText = "";
            this.txtStatus.SelectionLength = 0;
            this.txtStatus.SelectionStart = 0;
            this.txtStatus.Size = new System.Drawing.Size(1325, 41);
            this.txtStatus.TabIndex = 3;
            this.txtStatus.TabStop = false;
            this.txtStatus.UseSystemPasswordChar = false;
            // 
            // dtpPackingDate
            // 
            this.dtpPackingDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPackingBindingSource, "PackingDate", true));
            this.dtpPackingDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPackingBindingSource, "PackingDate", true));
            this.dtpPackingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPackingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPackingDate.Location = new System.Drawing.Point(263, 442);
            this.dtpPackingDate.Name = "dtpPackingDate";
            this.dtpPackingDate.Size = new System.Drawing.Size(208, 38);
            this.dtpPackingDate.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNoDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.pONoDataGridViewTextBoxColumn,
            this.packingDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPackingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 559);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1576, 567);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(1370, 1149);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(94, 36);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.Depth = 0;
            this.btnPrint.Icon = null;
            this.btnPrint.Location = new System.Drawing.Point(1472, 1149);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Primary = false;
            this.btnPrint.Size = new System.Drawing.Size(104, 36);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Depth = 0;
            this.btnNew.Icon = null;
            this.btnNew.Location = new System.Drawing.Point(1049, 1149);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNew.Name = "btnNew";
            this.btnNew.Primary = false;
            this.btnNew.Size = new System.Drawing.Size(85, 36);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Depth = 0;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(1142, 1149);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = false;
            this.btnEdit.Size = new System.Drawing.Size(83, 36);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(1233, 1149);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(129, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(116, 500);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(125, 36);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Search.:";
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(263, 500);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(1325, 41);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TabStop = false;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // chkSaveAndPrint
            // 
            this.chkSaveAndPrint.AutoSize = true;
            this.chkSaveAndPrint.Depth = 0;
            this.chkSaveAndPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkSaveAndPrint.Location = new System.Drawing.Point(950, 190);
            this.chkSaveAndPrint.Margin = new System.Windows.Forms.Padding(0);
            this.chkSaveAndPrint.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSaveAndPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSaveAndPrint.Name = "chkSaveAndPrint";
            this.chkSaveAndPrint.Ripple = true;
            this.chkSaveAndPrint.Size = new System.Drawing.Size(184, 30);
            this.chkSaveAndPrint.TabIndex = 11;
            this.chkSaveAndPrint.Text = "Save & Print";
            this.chkSaveAndPrint.UseVisualStyleBackColor = true;
            // 
            // itemNoDataGridViewTextBoxColumn
            // 
            this.itemNoDataGridViewTextBoxColumn.DataPropertyName = "ItemNo";
            this.itemNoDataGridViewTextBoxColumn.HeaderText = "Item No";
            this.itemNoDataGridViewTextBoxColumn.Name = "itemNoDataGridViewTextBoxColumn";
            this.itemNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNoDataGridViewTextBoxColumn.Width = 300;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pONoDataGridViewTextBoxColumn
            // 
            this.pONoDataGridViewTextBoxColumn.DataPropertyName = "PONo";
            this.pONoDataGridViewTextBoxColumn.HeaderText = "PO No";
            this.pONoDataGridViewTextBoxColumn.Name = "pONoDataGridViewTextBoxColumn";
            this.pONoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pONoDataGridViewTextBoxColumn.Width = 300;
            // 
            // packingDateDataGridViewTextBoxColumn
            // 
            this.packingDateDataGridViewTextBoxColumn.DataPropertyName = "PackingDate";
            this.packingDateDataGridViewTextBoxColumn.HeaderText = "Packing Date";
            this.packingDateDataGridViewTextBoxColumn.Name = "packingDateDataGridViewTextBoxColumn";
            this.packingDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.packingDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 750;
            // 
            // lTSolutionsDataSetBindingSource
            // 
            this.lTSolutionsDataSetBindingSource.DataSource = this.lTSolutionsDataSet;
            this.lTSolutionsDataSetBindingSource.Position = 0;
            // 
            // lTSolutionsDataSet
            // 
            this.lTSolutionsDataSet.DataSetName = "LTSolutionsDataSet";
            this.lTSolutionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPackingTableAdapter
            // 
            this.tblPackingTableAdapter.ClearBeforeFill = true;
            // 
            // frmPackingLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 1200);
            this.Controls.Add(this.chkSaveAndPrint);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpPackingDate);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPONo);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmPackingLabel";
            this.Text = "Packing Label";
            this.Load += new System.EventHandler(this.frmPackingLabel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPackingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTSolutionsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTSolutionsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtQuantity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPONo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStatus;
        private System.Windows.Forms.DateTimePicker dtpPackingDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private MaterialSkin.Controls.MaterialFlatButton btnPrint;
        private MaterialSkin.Controls.MaterialFlatButton btnNew;
        private MaterialSkin.Controls.MaterialFlatButton btnEdit;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialCheckBox chkSaveAndPrint;
        private System.Windows.Forms.BindingSource lTSolutionsDataSetBindingSource;
        private LTSolutionsDataSet lTSolutionsDataSet;
        private System.Windows.Forms.BindingSource tblPackingBindingSource;
        private LTSolutionsDataSetTableAdapters.tblPackingTableAdapter tblPackingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}

