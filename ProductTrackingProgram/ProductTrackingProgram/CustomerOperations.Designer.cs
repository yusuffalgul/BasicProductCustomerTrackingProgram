namespace ProductTrackingProgram
{
    partial class CustomerOperations
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
            this.addCustomerGbx = new System.Windows.Forms.GroupBox();
            this.customerAddButton = new System.Windows.Forms.Button();
            this.customerAgeTxt = new System.Windows.Forms.TextBox();
            this.customerSurnameTxt = new System.Windows.Forms.TextBox();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.customerIdTxt = new System.Windows.Forms.TextBox();
            this.ageCustomerLbl = new System.Windows.Forms.Label();
            this.surnameCustomerLbl = new System.Windows.Forms.Label();
            this.customerNameLbl = new System.Windows.Forms.Label();
            this.customerIdLbl = new System.Windows.Forms.Label();
            this.customerGbx = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdentificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productStockDataSet1 = new ProductTrackingProgram.ProductStockDataSet1();
            this.customerTableAdapter = new ProductTrackingProgram.ProductStockDataSet1TableAdapters.CustomerTableAdapter();
            this.customerSelectButton = new System.Windows.Forms.Button();
            this.backButton2 = new System.Windows.Forms.Button();
            this.deleteCustomerGbx = new System.Windows.Forms.GroupBox();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.deleteCustomerIdTxt = new System.Windows.Forms.TextBox();
            this.ıdDeleteCustomerLbl = new System.Windows.Forms.Label();
            this.clearCustomerButton = new System.Windows.Forms.Button();
            this.customerUpdateGbx = new System.Windows.Forms.GroupBox();
            this.updateAgeButton = new System.Windows.Forms.Button();
            this.updateSurnameButton = new System.Windows.Forms.Button();
            this.updateNameButton = new System.Windows.Forms.Button();
            this.updateIdButton = new System.Windows.Forms.Button();
            this.updateCustomerAgeTxt = new System.Windows.Forms.TextBox();
            this.updateCustomerSurnameTxt = new System.Windows.Forms.TextBox();
            this.updateCustomerNameTxt = new System.Windows.Forms.TextBox();
            this.updateCustomerIdenTxt = new System.Windows.Forms.TextBox();
            this.updateCustomerIdTxt = new System.Windows.Forms.TextBox();
            this.updateAgeLbl = new System.Windows.Forms.Label();
            this.updateSurnameLbl = new System.Windows.Forms.Label();
            this.updateNameLbl = new System.Windows.Forms.Label();
            this.updateIdentificationLbl = new System.Windows.Forms.Label();
            this.updateIdLbl = new System.Windows.Forms.Label();
            this.customerTableAdapter1 = new ProductTrackingProgram.ProductStockDataSet1TableAdapters.CustomerTableAdapter();
            this.customerTableAdapter2 = new ProductTrackingProgram.ProductStockDataSet1TableAdapters.CustomerTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameSelectButton = new System.Windows.Forms.Button();
            this.nameSelectTxt = new System.Windows.Forms.TextBox();
            this.nameSelectLbl = new System.Windows.Forms.Label();
            this.addCustomerGbx.SuspendLayout();
            this.customerGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStockDataSet1)).BeginInit();
            this.deleteCustomerGbx.SuspendLayout();
            this.customerUpdateGbx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCustomerGbx
            // 
            this.addCustomerGbx.Controls.Add(this.customerAddButton);
            this.addCustomerGbx.Controls.Add(this.customerAgeTxt);
            this.addCustomerGbx.Controls.Add(this.customerSurnameTxt);
            this.addCustomerGbx.Controls.Add(this.customerNameTxt);
            this.addCustomerGbx.Controls.Add(this.customerIdTxt);
            this.addCustomerGbx.Controls.Add(this.ageCustomerLbl);
            this.addCustomerGbx.Controls.Add(this.surnameCustomerLbl);
            this.addCustomerGbx.Controls.Add(this.customerNameLbl);
            this.addCustomerGbx.Controls.Add(this.customerIdLbl);
            this.addCustomerGbx.Location = new System.Drawing.Point(12, 12);
            this.addCustomerGbx.Name = "addCustomerGbx";
            this.addCustomerGbx.Size = new System.Drawing.Size(412, 229);
            this.addCustomerGbx.TabIndex = 0;
            this.addCustomerGbx.TabStop = false;
            this.addCustomerGbx.Text = "Add Customer";
            // 
            // customerAddButton
            // 
            this.customerAddButton.Location = new System.Drawing.Point(285, 113);
            this.customerAddButton.Name = "customerAddButton";
            this.customerAddButton.Size = new System.Drawing.Size(98, 40);
            this.customerAddButton.TabIndex = 8;
            this.customerAddButton.Text = "Add";
            this.customerAddButton.UseVisualStyleBackColor = true;
            this.customerAddButton.Click += new System.EventHandler(this.customerAddButton_Click);
            // 
            // customerAgeTxt
            // 
            this.customerAgeTxt.Location = new System.Drawing.Point(141, 186);
            this.customerAgeTxt.Name = "customerAgeTxt";
            this.customerAgeTxt.Size = new System.Drawing.Size(100, 22);
            this.customerAgeTxt.TabIndex = 7;
            // 
            // customerSurnameTxt
            // 
            this.customerSurnameTxt.Location = new System.Drawing.Point(141, 137);
            this.customerSurnameTxt.Name = "customerSurnameTxt";
            this.customerSurnameTxt.Size = new System.Drawing.Size(100, 22);
            this.customerSurnameTxt.TabIndex = 6;
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Location = new System.Drawing.Point(141, 95);
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(100, 22);
            this.customerNameTxt.TabIndex = 5;
            // 
            // customerIdTxt
            // 
            this.customerIdTxt.Location = new System.Drawing.Point(141, 47);
            this.customerIdTxt.Name = "customerIdTxt";
            this.customerIdTxt.Size = new System.Drawing.Size(100, 22);
            this.customerIdTxt.TabIndex = 4;
            // 
            // ageCustomerLbl
            // 
            this.ageCustomerLbl.AutoSize = true;
            this.ageCustomerLbl.Location = new System.Drawing.Point(64, 189);
            this.ageCustomerLbl.Name = "ageCustomerLbl";
            this.ageCustomerLbl.Size = new System.Drawing.Size(38, 16);
            this.ageCustomerLbl.TabIndex = 3;
            this.ageCustomerLbl.Text = "Age :";
            // 
            // surnameCustomerLbl
            // 
            this.surnameCustomerLbl.AutoSize = true;
            this.surnameCustomerLbl.Location = new System.Drawing.Point(35, 137);
            this.surnameCustomerLbl.Name = "surnameCustomerLbl";
            this.surnameCustomerLbl.Size = new System.Drawing.Size(67, 16);
            this.surnameCustomerLbl.TabIndex = 2;
            this.surnameCustomerLbl.Text = "Surname :";
            // 
            // customerNameLbl
            // 
            this.customerNameLbl.AutoSize = true;
            this.customerNameLbl.Location = new System.Drawing.Point(52, 95);
            this.customerNameLbl.Name = "customerNameLbl";
            this.customerNameLbl.Size = new System.Drawing.Size(50, 16);
            this.customerNameLbl.TabIndex = 1;
            this.customerNameLbl.Text = "Name :";
            // 
            // customerIdLbl
            // 
            this.customerIdLbl.AutoSize = true;
            this.customerIdLbl.Location = new System.Drawing.Point(15, 47);
            this.customerIdLbl.Name = "customerIdLbl";
            this.customerIdLbl.Size = new System.Drawing.Size(87, 16);
            this.customerIdLbl.TabIndex = 0;
            this.customerIdLbl.Text = "Identification :";
            // 
            // customerGbx
            // 
            this.customerGbx.Controls.Add(this.dataGridView1);
            this.customerGbx.Location = new System.Drawing.Point(12, 294);
            this.customerGbx.Name = "customerGbx";
            this.customerGbx.Size = new System.Drawing.Size(914, 249);
            this.customerGbx.TabIndex = 1;
            this.customerGbx.TabStop = false;
            this.customerGbx.Text = "Customers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.ıdentificationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(908, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıdentificationDataGridViewTextBoxColumn
            // 
            this.ıdentificationDataGridViewTextBoxColumn.DataPropertyName = "Identification";
            this.ıdentificationDataGridViewTextBoxColumn.HeaderText = "Identification";
            this.ıdentificationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdentificationDataGridViewTextBoxColumn.Name = "ıdentificationDataGridViewTextBoxColumn";
            this.ıdentificationDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.productStockDataSet1;
            // 
            // productStockDataSet1
            // 
            this.productStockDataSet1.DataSetName = "ProductStockDataSet1";
            this.productStockDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerSelectButton
            // 
            this.customerSelectButton.Location = new System.Drawing.Point(15, 248);
            this.customerSelectButton.Name = "customerSelectButton";
            this.customerSelectButton.Size = new System.Drawing.Size(118, 40);
            this.customerSelectButton.TabIndex = 2;
            this.customerSelectButton.Text = "All Select";
            this.customerSelectButton.UseVisualStyleBackColor = true;
            this.customerSelectButton.Click += new System.EventHandler(this.customerSelectButton_Click);
            // 
            // backButton2
            // 
            this.backButton2.Location = new System.Drawing.Point(1247, 12);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(75, 37);
            this.backButton2.TabIndex = 3;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // deleteCustomerGbx
            // 
            this.deleteCustomerGbx.Controls.Add(this.deleteCustomerButton);
            this.deleteCustomerGbx.Controls.Add(this.deleteCustomerIdTxt);
            this.deleteCustomerGbx.Controls.Add(this.ıdDeleteCustomerLbl);
            this.deleteCustomerGbx.Location = new System.Drawing.Point(932, 12);
            this.deleteCustomerGbx.Name = "deleteCustomerGbx";
            this.deleteCustomerGbx.Size = new System.Drawing.Size(296, 139);
            this.deleteCustomerGbx.TabIndex = 4;
            this.deleteCustomerGbx.TabStop = false;
            this.deleteCustomerGbx.Text = "Delete Customer";
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(120, 86);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(100, 31);
            this.deleteCustomerButton.TabIndex = 3;
            this.deleteCustomerButton.Text = "Delete";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // deleteCustomerIdTxt
            // 
            this.deleteCustomerIdTxt.Location = new System.Drawing.Point(120, 44);
            this.deleteCustomerIdTxt.Name = "deleteCustomerIdTxt";
            this.deleteCustomerIdTxt.Size = new System.Drawing.Size(100, 22);
            this.deleteCustomerIdTxt.TabIndex = 2;
            // 
            // ıdDeleteCustomerLbl
            // 
            this.ıdDeleteCustomerLbl.AutoSize = true;
            this.ıdDeleteCustomerLbl.Location = new System.Drawing.Point(6, 50);
            this.ıdDeleteCustomerLbl.Name = "ıdDeleteCustomerLbl";
            this.ıdDeleteCustomerLbl.Size = new System.Drawing.Size(87, 16);
            this.ıdDeleteCustomerLbl.TabIndex = 0;
            this.ıdDeleteCustomerLbl.Text = "Identification :";
            // 
            // clearCustomerButton
            // 
            this.clearCustomerButton.Location = new System.Drawing.Point(153, 248);
            this.clearCustomerButton.Name = "clearCustomerButton";
            this.clearCustomerButton.Size = new System.Drawing.Size(118, 40);
            this.clearCustomerButton.TabIndex = 5;
            this.clearCustomerButton.Text = "Clear";
            this.clearCustomerButton.UseVisualStyleBackColor = true;
            // 
            // customerUpdateGbx
            // 
            this.customerUpdateGbx.Controls.Add(this.updateAgeButton);
            this.customerUpdateGbx.Controls.Add(this.updateSurnameButton);
            this.customerUpdateGbx.Controls.Add(this.updateNameButton);
            this.customerUpdateGbx.Controls.Add(this.updateIdButton);
            this.customerUpdateGbx.Controls.Add(this.updateCustomerAgeTxt);
            this.customerUpdateGbx.Controls.Add(this.updateCustomerSurnameTxt);
            this.customerUpdateGbx.Controls.Add(this.updateCustomerNameTxt);
            this.customerUpdateGbx.Controls.Add(this.updateCustomerIdenTxt);
            this.customerUpdateGbx.Controls.Add(this.updateCustomerIdTxt);
            this.customerUpdateGbx.Controls.Add(this.updateAgeLbl);
            this.customerUpdateGbx.Controls.Add(this.updateSurnameLbl);
            this.customerUpdateGbx.Controls.Add(this.updateNameLbl);
            this.customerUpdateGbx.Controls.Add(this.updateIdentificationLbl);
            this.customerUpdateGbx.Controls.Add(this.updateIdLbl);
            this.customerUpdateGbx.Location = new System.Drawing.Point(473, 12);
            this.customerUpdateGbx.Name = "customerUpdateGbx";
            this.customerUpdateGbx.Size = new System.Drawing.Size(425, 229);
            this.customerUpdateGbx.TabIndex = 6;
            this.customerUpdateGbx.TabStop = false;
            this.customerUpdateGbx.Text = "Update Customer";
            // 
            // updateAgeButton
            // 
            this.updateAgeButton.Location = new System.Drawing.Point(243, 165);
            this.updateAgeButton.Name = "updateAgeButton";
            this.updateAgeButton.Size = new System.Drawing.Size(176, 31);
            this.updateAgeButton.TabIndex = 13;
            this.updateAgeButton.Text = "Update Age";
            this.updateAgeButton.UseVisualStyleBackColor = true;
            this.updateAgeButton.Click += new System.EventHandler(this.updateAgeButton_Click);
            // 
            // updateSurnameButton
            // 
            this.updateSurnameButton.Location = new System.Drawing.Point(243, 123);
            this.updateSurnameButton.Name = "updateSurnameButton";
            this.updateSurnameButton.Size = new System.Drawing.Size(176, 33);
            this.updateSurnameButton.TabIndex = 12;
            this.updateSurnameButton.Text = "Update Surname";
            this.updateSurnameButton.UseVisualStyleBackColor = true;
            this.updateSurnameButton.Click += new System.EventHandler(this.updateSurnameButton_Click);
            // 
            // updateNameButton
            // 
            this.updateNameButton.Location = new System.Drawing.Point(243, 86);
            this.updateNameButton.Name = "updateNameButton";
            this.updateNameButton.Size = new System.Drawing.Size(176, 31);
            this.updateNameButton.TabIndex = 11;
            this.updateNameButton.Text = "Update Name";
            this.updateNameButton.UseVisualStyleBackColor = true;
            this.updateNameButton.Click += new System.EventHandler(this.updateNameButton_Click);
            // 
            // updateIdButton
            // 
            this.updateIdButton.Location = new System.Drawing.Point(243, 48);
            this.updateIdButton.Name = "updateIdButton";
            this.updateIdButton.Size = new System.Drawing.Size(176, 33);
            this.updateIdButton.TabIndex = 10;
            this.updateIdButton.Text = "Update Identification";
            this.updateIdButton.UseVisualStyleBackColor = true;
            this.updateIdButton.Click += new System.EventHandler(this.updateIdButton_Click);
            // 
            // updateCustomerAgeTxt
            // 
            this.updateCustomerAgeTxt.Location = new System.Drawing.Point(116, 174);
            this.updateCustomerAgeTxt.Name = "updateCustomerAgeTxt";
            this.updateCustomerAgeTxt.Size = new System.Drawing.Size(100, 22);
            this.updateCustomerAgeTxt.TabIndex = 9;
            // 
            // updateCustomerSurnameTxt
            // 
            this.updateCustomerSurnameTxt.Location = new System.Drawing.Point(116, 134);
            this.updateCustomerSurnameTxt.Name = "updateCustomerSurnameTxt";
            this.updateCustomerSurnameTxt.Size = new System.Drawing.Size(100, 22);
            this.updateCustomerSurnameTxt.TabIndex = 8;
            // 
            // updateCustomerNameTxt
            // 
            this.updateCustomerNameTxt.Location = new System.Drawing.Point(116, 95);
            this.updateCustomerNameTxt.Name = "updateCustomerNameTxt";
            this.updateCustomerNameTxt.Size = new System.Drawing.Size(100, 22);
            this.updateCustomerNameTxt.TabIndex = 7;
            // 
            // updateCustomerIdenTxt
            // 
            this.updateCustomerIdenTxt.Location = new System.Drawing.Point(116, 59);
            this.updateCustomerIdenTxt.Name = "updateCustomerIdenTxt";
            this.updateCustomerIdenTxt.Size = new System.Drawing.Size(100, 22);
            this.updateCustomerIdenTxt.TabIndex = 6;
            // 
            // updateCustomerIdTxt
            // 
            this.updateCustomerIdTxt.Location = new System.Drawing.Point(116, 22);
            this.updateCustomerIdTxt.Name = "updateCustomerIdTxt";
            this.updateCustomerIdTxt.Size = new System.Drawing.Size(100, 22);
            this.updateCustomerIdTxt.TabIndex = 5;
            // 
            // updateAgeLbl
            // 
            this.updateAgeLbl.AutoSize = true;
            this.updateAgeLbl.Location = new System.Drawing.Point(55, 177);
            this.updateAgeLbl.Name = "updateAgeLbl";
            this.updateAgeLbl.Size = new System.Drawing.Size(38, 16);
            this.updateAgeLbl.TabIndex = 4;
            this.updateAgeLbl.Text = "Age :";
            // 
            // updateSurnameLbl
            // 
            this.updateSurnameLbl.AutoSize = true;
            this.updateSurnameLbl.Location = new System.Drawing.Point(26, 134);
            this.updateSurnameLbl.Name = "updateSurnameLbl";
            this.updateSurnameLbl.Size = new System.Drawing.Size(67, 16);
            this.updateSurnameLbl.TabIndex = 3;
            this.updateSurnameLbl.Text = "Surname :";
            // 
            // updateNameLbl
            // 
            this.updateNameLbl.AutoSize = true;
            this.updateNameLbl.Location = new System.Drawing.Point(43, 98);
            this.updateNameLbl.Name = "updateNameLbl";
            this.updateNameLbl.Size = new System.Drawing.Size(50, 16);
            this.updateNameLbl.TabIndex = 2;
            this.updateNameLbl.Text = "Name :";
            // 
            // updateIdentificationLbl
            // 
            this.updateIdentificationLbl.AutoSize = true;
            this.updateIdentificationLbl.Location = new System.Drawing.Point(6, 59);
            this.updateIdentificationLbl.Name = "updateIdentificationLbl";
            this.updateIdentificationLbl.Size = new System.Drawing.Size(87, 16);
            this.updateIdentificationLbl.TabIndex = 1;
            this.updateIdentificationLbl.Text = "Identification :";
            // 
            // updateIdLbl
            // 
            this.updateIdLbl.AutoSize = true;
            this.updateIdLbl.Location = new System.Drawing.Point(69, 22);
            this.updateIdLbl.Name = "updateIdLbl";
            this.updateIdLbl.Size = new System.Drawing.Size(24, 16);
            this.updateIdLbl.TabIndex = 0;
            this.updateIdLbl.Text = "Id :";
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // customerTableAdapter2
            // 
            this.customerTableAdapter2.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameSelectButton);
            this.groupBox1.Controls.Add(this.nameSelectTxt);
            this.groupBox1.Controls.Add(this.nameSelectLbl);
            this.groupBox1.Location = new System.Drawing.Point(932, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Customer";
            // 
            // nameSelectButton
            // 
            this.nameSelectButton.Location = new System.Drawing.Point(120, 82);
            this.nameSelectButton.Name = "nameSelectButton";
            this.nameSelectButton.Size = new System.Drawing.Size(100, 28);
            this.nameSelectButton.TabIndex = 2;
            this.nameSelectButton.Text = "Select";
            this.nameSelectButton.UseVisualStyleBackColor = true;
            this.nameSelectButton.Click += new System.EventHandler(this.nameSelectButton_Click);
            // 
            // nameSelectTxt
            // 
            this.nameSelectTxt.Location = new System.Drawing.Point(120, 38);
            this.nameSelectTxt.Name = "nameSelectTxt";
            this.nameSelectTxt.Size = new System.Drawing.Size(100, 22);
            this.nameSelectTxt.TabIndex = 1;
            // 
            // nameSelectLbl
            // 
            this.nameSelectLbl.AutoSize = true;
            this.nameSelectLbl.Location = new System.Drawing.Point(43, 41);
            this.nameSelectLbl.Name = "nameSelectLbl";
            this.nameSelectLbl.Size = new System.Drawing.Size(50, 16);
            this.nameSelectLbl.TabIndex = 0;
            this.nameSelectLbl.Text = "Name :";
            // 
            // CustomerOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1334, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerUpdateGbx);
            this.Controls.Add(this.clearCustomerButton);
            this.Controls.Add(this.deleteCustomerGbx);
            this.Controls.Add(this.backButton2);
            this.Controls.Add(this.customerSelectButton);
            this.Controls.Add(this.customerGbx);
            this.Controls.Add(this.addCustomerGbx);
            this.Name = "CustomerOperations";
            this.Text = "CustomerOperations";
            this.Load += new System.EventHandler(this.CustomerOperations_Load);
            this.addCustomerGbx.ResumeLayout(false);
            this.addCustomerGbx.PerformLayout();
            this.customerGbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStockDataSet1)).EndInit();
            this.deleteCustomerGbx.ResumeLayout(false);
            this.deleteCustomerGbx.PerformLayout();
            this.customerUpdateGbx.ResumeLayout(false);
            this.customerUpdateGbx.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addCustomerGbx;
        private System.Windows.Forms.Button customerAddButton;
        private System.Windows.Forms.TextBox customerAgeTxt;
        private System.Windows.Forms.TextBox customerSurnameTxt;
        private System.Windows.Forms.TextBox customerNameTxt;
        private System.Windows.Forms.TextBox customerIdTxt;
        private System.Windows.Forms.Label ageCustomerLbl;
        private System.Windows.Forms.Label surnameCustomerLbl;
        private System.Windows.Forms.Label customerNameLbl;
        private System.Windows.Forms.Label customerIdLbl;
        private System.Windows.Forms.GroupBox customerGbx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProductStockDataSet1 productStockDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private ProductStockDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdentificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button customerSelectButton;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.GroupBox deleteCustomerGbx;
        private System.Windows.Forms.Button clearCustomerButton;
        private System.Windows.Forms.Label ıdDeleteCustomerLbl;
        private System.Windows.Forms.TextBox deleteCustomerIdTxt;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.GroupBox customerUpdateGbx;
        private System.Windows.Forms.Label updateIdLbl;
        private System.Windows.Forms.Label updateAgeLbl;
        private System.Windows.Forms.Label updateSurnameLbl;
        private System.Windows.Forms.Label updateNameLbl;
        private System.Windows.Forms.Label updateIdentificationLbl;
        private System.Windows.Forms.TextBox updateCustomerAgeTxt;
        private System.Windows.Forms.TextBox updateCustomerSurnameTxt;
        private System.Windows.Forms.TextBox updateCustomerNameTxt;
        private System.Windows.Forms.TextBox updateCustomerIdenTxt;
        private System.Windows.Forms.TextBox updateCustomerIdTxt;
        private ProductStockDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private ProductStockDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter2;
        private System.Windows.Forms.Button updateAgeButton;
        private System.Windows.Forms.Button updateSurnameButton;
        private System.Windows.Forms.Button updateNameButton;
        private System.Windows.Forms.Button updateIdButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nameSelectButton;
        private System.Windows.Forms.TextBox nameSelectTxt;
        private System.Windows.Forms.Label nameSelectLbl;
    }
}