namespace SalesApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleComboBox = new System.Windows.Forms.ComboBox();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.salesRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refreshSalesButton = new System.Windows.Forms.Button();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTargetButton = new System.Windows.Forms.Button();
            this.newAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.newDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newPersonComboBox = new System.Windows.Forms.ComboBox();
            this.newRegionComboBox = new System.Windows.Forms.ComboBox();
            this.newSaleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataSource = typeof(SalesApp.Models.SalesPerson);
            // 
            // peopleComboBox
            // 
            this.peopleComboBox.DataSource = this.salesPersonBindingSource;
            this.peopleComboBox.DisplayMember = "FullName";
            this.peopleComboBox.FormattingEnabled = true;
            this.peopleComboBox.Location = new System.Drawing.Point(250, 12);
            this.peopleComboBox.Name = "peopleComboBox";
            this.peopleComboBox.Size = new System.Drawing.Size(121, 21);
            this.peopleComboBox.TabIndex = 0;
            this.peopleComboBox.ValueMember = "Id";
            this.peopleComboBox.SelectedIndexChanged += new System.EventHandler(this.peopleComboBox_SelectedIndexChanged);
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.salesPersonBindingSource;
            // 
            // regionComboBox
            // 
            this.regionComboBox.DataSource = this.salesRegionBindingSource;
            this.regionComboBox.DisplayMember = "Name";
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(377, 12);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(121, 21);
            this.regionComboBox.TabIndex = 1;
            this.regionComboBox.ValueMember = "Id";
            this.regionComboBox.SelectedIndexChanged += new System.EventHandler(this.regionComboBox_SelectedIndexChanged);
            // 
            // salesRegionBindingSource
            // 
            this.salesRegionBindingSource.DataSource = typeof(SalesApp.Models.SalesRegion);
            // 
            // refreshSalesButton
            // 
            this.refreshSalesButton.Location = new System.Drawing.Point(509, 12);
            this.refreshSalesButton.Name = "refreshSalesButton";
            this.refreshSalesButton.Size = new System.Drawing.Size(75, 23);
            this.refreshSalesButton.TabIndex = 2;
            this.refreshSalesButton.Text = "Refresh";
            this.refreshSalesButton.UseVisualStyleBackColor = true;
            this.refreshSalesButton.Click += new System.EventHandler(this.refreshSalesButton_Click);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AutoGenerateColumns = false;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
            this.salesDataGridView.DataSource = this.saleBindingSource;
            this.salesDataGridView.Location = new System.Drawing.Point(12, 80);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.Size = new System.Drawing.Size(572, 150);
            this.salesDataGridView.TabIndex = 3;
            this.salesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGridView_CellContentClick);
            this.salesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGridView_CellEndEdit);
            this.salesDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.salesDataGridView_UserDeletingRow);
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
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            this.updatedByDataGridViewTextBoxColumn.HeaderText = "Updated By";
            this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            this.updatedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(SalesApp.Models.Sale);
            // 
            // salesTargetButton
            // 
            this.salesTargetButton.Location = new System.Drawing.Point(169, 12);
            this.salesTargetButton.Name = "salesTargetButton";
            this.salesTargetButton.Size = new System.Drawing.Size(75, 23);
            this.salesTargetButton.TabIndex = 4;
            this.salesTargetButton.Text = "Target";
            this.salesTargetButton.UseVisualStyleBackColor = false;
            this.salesTargetButton.Click += new System.EventHandler(this.salesTargetButton_Click);
            // 
            // newAmountNumericUpDown
            // 
            this.newAmountNumericUpDown.DecimalPlaces = 2;
            this.newAmountNumericUpDown.Location = new System.Drawing.Point(51, 282);
            this.newAmountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.newAmountNumericUpDown.Name = "newAmountNumericUpDown";
            this.newAmountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.newAmountNumericUpDown.TabIndex = 5;
            this.newAmountNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // newDateDateTimePicker
            // 
            this.newDateDateTimePicker.Location = new System.Drawing.Point(51, 309);
            this.newDateDateTimePicker.Name = "newDateDateTimePicker";
            this.newDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.newDateDateTimePicker.TabIndex = 6;
            // 
            // newPersonComboBox
            // 
            this.newPersonComboBox.DataSource = this.salesPersonBindingSource;
            this.newPersonComboBox.DisplayMember = "FullName";
            this.newPersonComboBox.FormattingEnabled = true;
            this.newPersonComboBox.Location = new System.Drawing.Point(50, 335);
            this.newPersonComboBox.Name = "newPersonComboBox";
            this.newPersonComboBox.Size = new System.Drawing.Size(121, 21);
            this.newPersonComboBox.TabIndex = 7;
            this.newPersonComboBox.ValueMember = "Id";
            // 
            // newRegionComboBox
            // 
            this.newRegionComboBox.DataSource = this.salesRegionBindingSource;
            this.newRegionComboBox.DisplayMember = "Name";
            this.newRegionComboBox.FormattingEnabled = true;
            this.newRegionComboBox.Location = new System.Drawing.Point(50, 362);
            this.newRegionComboBox.Name = "newRegionComboBox";
            this.newRegionComboBox.Size = new System.Drawing.Size(121, 21);
            this.newRegionComboBox.TabIndex = 8;
            this.newRegionComboBox.ValueMember = "Id";
            // 
            // newSaleButton
            // 
            this.newSaleButton.Location = new System.Drawing.Point(175, 359);
            this.newSaleButton.Name = "newSaleButton";
            this.newSaleButton.Size = new System.Drawing.Size(75, 23);
            this.newSaleButton.TabIndex = 9;
            this.newSaleButton.Text = "New Sale";
            this.newSaleButton.UseVisualStyleBackColor = true;
            this.newSaleButton.Click += new System.EventHandler(this.newSaleButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private System.Windows.Forms.ComboBox peopleComboBox;
        private System.Windows.Forms.BindingSource salesBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
    }
}

