namespace SalesApp
{
    partial class SalesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.peopleComboBox = new System.Windows.Forms.ComboBox();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.salesRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refreshSalesButton = new System.Windows.Forms.Button();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTargetButton = new System.Windows.Forms.Button();
            this.newAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.newDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newPersonComboBox = new System.Windows.Forms.ComboBox();
            this.newRegionComboBox = new System.Windows.Forms.ComboBox();
            this.newSaleButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.salesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.regionLabel = new System.Windows.Forms.Label();
            this.newSaleLabel = new System.Windows.Forms.Label();
            this.newAmountLabel = new System.Windows.Forms.Label();
            this.newDateLabel = new System.Windows.Forms.Label();
            this.newPersonLabel = new System.Windows.Forms.Label();
            this.newRegionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleComboBox
            // 
            this.peopleComboBox.DataSource = this.salesPersonBindingSource;
            this.peopleComboBox.DisplayMember = "FullName";
            this.peopleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.peopleComboBox.FormattingEnabled = true;
            this.peopleComboBox.Location = new System.Drawing.Point(251, 13);
            this.peopleComboBox.Name = "peopleComboBox";
            this.peopleComboBox.Size = new System.Drawing.Size(200, 21);
            this.peopleComboBox.TabIndex = 2;
            this.salesToolTip.SetToolTip(this.peopleComboBox, "Filter by Sales Person.");
            this.peopleComboBox.ValueMember = "Id";
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataSource = typeof(SalesApp.Models.SalesPerson);
            // 
            // regionComboBox
            // 
            this.regionComboBox.DataSource = this.salesRegionBindingSource;
            this.regionComboBox.DisplayMember = "Name";
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(251, 39);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(200, 21);
            this.regionComboBox.TabIndex = 5;
            this.salesToolTip.SetToolTip(this.regionComboBox, "Filter by Sales Region.");
            this.regionComboBox.ValueMember = "Id";
            // 
            // salesRegionBindingSource
            // 
            this.salesRegionBindingSource.DataSource = typeof(SalesApp.Models.SalesRegion);
            // 
            // refreshSalesButton
            // 
            this.refreshSalesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshSalesButton.Location = new System.Drawing.Point(457, 39);
            this.refreshSalesButton.Name = "refreshSalesButton";
            this.refreshSalesButton.Size = new System.Drawing.Size(75, 21);
            this.refreshSalesButton.TabIndex = 6;
            this.refreshSalesButton.Text = "Refresh";
            this.salesToolTip.SetToolTip(this.refreshSalesButton, "Refresh the Sales List");
            this.refreshSalesButton.UseVisualStyleBackColor = true;
            this.refreshSalesButton.Click += new System.EventHandler(this.refreshSalesButton_Click);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AllowUserToAddRows = false;
            this.salesDataGridView.AutoGenerateColumns = false;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
            this.salesDataGridView.DataSource = this.saleBindingSource;
            this.salesDataGridView.Location = new System.Drawing.Point(12, 76);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.Size = new System.Drawing.Size(520, 200);
            this.salesDataGridView.TabIndex = 7;
            this.salesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGridView_CellEndEdit);
            this.salesDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.salesDataGridView_UserDeletingRow);
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(SalesApp.Models.Sale);
            // 
            // salesTargetButton
            // 
            this.salesTargetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesTargetButton.Location = new System.Drawing.Point(457, 12);
            this.salesTargetButton.Name = "salesTargetButton";
            this.salesTargetButton.Size = new System.Drawing.Size(75, 21);
            this.salesTargetButton.TabIndex = 3;
            this.salesTargetButton.Text = "Target";
            this.salesToolTip.SetToolTip(this.salesTargetButton, "Get Sales Persons Sales Target.");
            this.salesTargetButton.UseVisualStyleBackColor = true;
            this.salesTargetButton.Click += new System.EventHandler(this.salesTargetButton_Click);
            // 
            // newAmountNumericUpDown
            // 
            this.newAmountNumericUpDown.DecimalPlaces = 2;
            this.newAmountNumericUpDown.Location = new System.Drawing.Point(102, 322);
            this.newAmountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.newAmountNumericUpDown.Name = "newAmountNumericUpDown";
            this.newAmountNumericUpDown.Size = new System.Drawing.Size(100, 21);
            this.newAmountNumericUpDown.TabIndex = 10;
            // 
            // newDateDateTimePicker
            // 
            this.newDateDateTimePicker.Location = new System.Drawing.Point(102, 349);
            this.newDateDateTimePicker.Name = "newDateDateTimePicker";
            this.newDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.newDateDateTimePicker.TabIndex = 12;
            // 
            // newPersonComboBox
            // 
            this.newPersonComboBox.DataSource = this.salesPersonBindingSource;
            this.newPersonComboBox.DisplayMember = "FullName";
            this.newPersonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newPersonComboBox.FormattingEnabled = true;
            this.newPersonComboBox.Location = new System.Drawing.Point(102, 376);
            this.newPersonComboBox.Name = "newPersonComboBox";
            this.newPersonComboBox.Size = new System.Drawing.Size(200, 21);
            this.newPersonComboBox.TabIndex = 14;
            this.newPersonComboBox.ValueMember = "Id";
            // 
            // newRegionComboBox
            // 
            this.newRegionComboBox.DataSource = this.salesRegionBindingSource;
            this.newRegionComboBox.DisplayMember = "Name";
            this.newRegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newRegionComboBox.FormattingEnabled = true;
            this.newRegionComboBox.Location = new System.Drawing.Point(102, 403);
            this.newRegionComboBox.Name = "newRegionComboBox";
            this.newRegionComboBox.Size = new System.Drawing.Size(200, 21);
            this.newRegionComboBox.TabIndex = 16;
            this.newRegionComboBox.ValueMember = "Id";
            // 
            // newSaleButton
            // 
            this.newSaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newSaleButton.Location = new System.Drawing.Point(308, 403);
            this.newSaleButton.Name = "newSaleButton";
            this.newSaleButton.Size = new System.Drawing.Size(75, 21);
            this.newSaleButton.TabIndex = 17;
            this.newSaleButton.Text = "New Sale";
            this.newSaleButton.UseVisualStyleBackColor = true;
            this.newSaleButton.Click += new System.EventHandler(this.newSaleButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(60, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Sales";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            this.updatedByDataGridViewTextBoxColumn.HeaderText = "Updated By";
            this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            this.updatedByDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedByDataGridViewTextBoxColumn.Width = 150;
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Location = new System.Drawing.Point(173, 16);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(72, 13);
            this.peopleLabel.TabIndex = 1;
            this.peopleLabel.Text = "Sales &Person:";
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(173, 43);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(72, 13);
            this.regionLabel.TabIndex = 4;
            this.regionLabel.Text = "Sales &Region:";
            // 
            // newSaleLabel
            // 
            this.newSaleLabel.AutoSize = true;
            this.newSaleLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSaleLabel.Location = new System.Drawing.Point(12, 289);
            this.newSaleLabel.Name = "newSaleLabel";
            this.newSaleLabel.Size = new System.Drawing.Size(99, 25);
            this.newSaleLabel.TabIndex = 8;
            this.newSaleLabel.Text = "New Sale";
            // 
            // newAmountLabel
            // 
            this.newAmountLabel.AutoSize = true;
            this.newAmountLabel.Location = new System.Drawing.Point(14, 324);
            this.newAmountLabel.Name = "newAmountLabel";
            this.newAmountLabel.Size = new System.Drawing.Size(48, 13);
            this.newAmountLabel.TabIndex = 9;
            this.newAmountLabel.Text = "Amount:";
            // 
            // newDateLabel
            // 
            this.newDateLabel.AutoSize = true;
            this.newDateLabel.Location = new System.Drawing.Point(14, 349);
            this.newDateLabel.Name = "newDateLabel";
            this.newDateLabel.Size = new System.Drawing.Size(34, 13);
            this.newDateLabel.TabIndex = 11;
            this.newDateLabel.Text = "Date:";
            // 
            // newPersonLabel
            // 
            this.newPersonLabel.AutoSize = true;
            this.newPersonLabel.Location = new System.Drawing.Point(14, 379);
            this.newPersonLabel.Name = "newPersonLabel";
            this.newPersonLabel.Size = new System.Drawing.Size(72, 13);
            this.newPersonLabel.TabIndex = 13;
            this.newPersonLabel.Text = "Sales Person:";
            // 
            // newRegionLabel
            // 
            this.newRegionLabel.AutoSize = true;
            this.newRegionLabel.Location = new System.Drawing.Point(14, 406);
            this.newRegionLabel.Name = "newRegionLabel";
            this.newRegionLabel.Size = new System.Drawing.Size(72, 13);
            this.newRegionLabel.TabIndex = 15;
            this.newRegionLabel.Text = "Sales Region:";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 442);
            this.Controls.Add(this.newRegionLabel);
            this.Controls.Add(this.newPersonLabel);
            this.Controls.Add(this.newDateLabel);
            this.Controls.Add(this.newAmountLabel);
            this.Controls.Add(this.newSaleLabel);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.peopleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.newSaleButton);
            this.Controls.Add(this.newRegionComboBox);
            this.Controls.Add(this.newPersonComboBox);
            this.Controls.Add(this.newDateDateTimePicker);
            this.Controls.Add(this.newAmountNumericUpDown);
            this.Controls.Add(this.salesTargetButton);
            this.Controls.Add(this.salesDataGridView);
            this.Controls.Add(this.refreshSalesButton);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.peopleComboBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales App";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox peopleComboBox;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.BindingSource salesRegionBindingSource;
        private System.Windows.Forms.Button refreshSalesButton;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private System.Windows.Forms.Button salesTargetButton;
        private System.Windows.Forms.NumericUpDown newAmountNumericUpDown;
        private System.Windows.Forms.DateTimePicker newDateDateTimePicker;
        private System.Windows.Forms.ComboBox newPersonComboBox;
        private System.Windows.Forms.ComboBox newRegionComboBox;
        private System.Windows.Forms.Button newSaleButton;
        private System.Windows.Forms.ToolTip salesToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Label newSaleLabel;
        private System.Windows.Forms.Label newAmountLabel;
        private System.Windows.Forms.Label newDateLabel;
        private System.Windows.Forms.Label newPersonLabel;
        private System.Windows.Forms.Label newRegionLabel;
    }
}

