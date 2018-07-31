namespace TravelExpertsAPP
{
    partial class TravelExpertsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Packages = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.packageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.btnModifyPackage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.packages_Products_SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeletePackProdSup = new System.Windows.Forms.Button();
            this.btnModifyPackProdSup = new System.Windows.Forms.Button();
            this.btnAddPackProdSup = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.TabPage();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.Suppliers = new System.Windows.Forms.TabPage();
            this.supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnModifySupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.Product_Suppliers = new System.Windows.Forms.TabPage();
            this.product_SupplierDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteProductSupplier = new System.Windows.Forms.Button();
            this.btnModifyProductSupplier = new System.Windows.Forms.Button();
            this.btnAddProductSupplier = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.packages_Products_SuppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Packages.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersBindingSource)).BeginInit();
            this.Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.Product_Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_SupplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Packages);
            this.tabControl1.Controls.Add(this.Products);
            this.tabControl1.Controls.Add(this.Suppliers);
            this.tabControl1.Controls.Add(this.Product_Suppliers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1152, 676);
            this.tabControl1.TabIndex = 0;
            // 
            // Packages
            // 
            this.Packages.AutoScroll = true;
            this.Packages.Controls.Add(this.groupBox2);
            this.Packages.Controls.Add(this.groupBox1);
            this.Packages.Location = new System.Drawing.Point(4, 33);
            this.Packages.Name = "Packages";
            this.Packages.Padding = new System.Windows.Forms.Padding(3);
            this.Packages.Size = new System.Drawing.Size(1144, 639);
            this.Packages.TabIndex = 1;
            this.Packages.Text = "Packages";
            this.Packages.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.packageDataGridView);
            this.groupBox2.Controls.Add(this.btnAddPackage);
            this.groupBox2.Controls.Add(this.btnDeletePackage);
            this.groupBox2.Controls.Add(this.btnModifyPackage);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 300);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Package Information";
            // 
            // packageDataGridView
            // 
            this.packageDataGridView.AllowUserToAddRows = false;
            this.packageDataGridView.AllowUserToDeleteRows = false;
            this.packageDataGridView.AllowUserToOrderColumns = true;
            this.packageDataGridView.AutoGenerateColumns = false;
            this.packageDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.packageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.packageDataGridView.DataSource = this.packageBindingSource;
            this.packageDataGridView.Location = new System.Drawing.Point(20, 38);
            this.packageDataGridView.Name = "packageDataGridView";
            this.packageDataGridView.ReadOnly = true;
            this.packageDataGridView.ShowEditingIcon = false;
            this.packageDataGridView.Size = new System.Drawing.Size(1013, 199);
            this.packageDataGridView.TabIndex = 6;
            this.packageDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.packageDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PackageId";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 51;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PkgName";
            this.dataGridViewTextBoxColumn9.HeaderText = "Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 76;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PkgStartDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "Start Date";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PkgEndDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "End Date";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PkgDesc";
            this.dataGridViewTextBoxColumn12.HeaderText = "Description";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 114;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn13.HeaderText = "Base Price";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 101;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn14.HeaderText = "Agency Commission";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(TravelExpertsLibrary.Package);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(656, 243);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(113, 40);
            this.btnAddPackage.TabIndex = 4;
            this.btnAddPackage.Text = "&Add";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.Location = new System.Drawing.Point(920, 243);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(113, 40);
            this.btnDeletePackage.TabIndex = 6;
            this.btnDeletePackage.Text = "&Delete";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // btnModifyPackage
            // 
            this.btnModifyPackage.Location = new System.Drawing.Point(789, 243);
            this.btnModifyPackage.Name = "btnModifyPackage";
            this.btnModifyPackage.Size = new System.Drawing.Size(113, 40);
            this.btnModifyPackage.TabIndex = 5;
            this.btnModifyPackage.Text = "&Modify";
            this.btnModifyPackage.UseVisualStyleBackColor = true;
            this.btnModifyPackage.Click += new System.EventHandler(this.btnModifyPackage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.packages_Products_SuppliersDataGridView);
            this.groupBox1.Controls.Add(this.btnDeletePackProdSup);
            this.groupBox1.Controls.Add(this.btnModifyPackProdSup);
            this.groupBox1.Controls.Add(this.btnAddPackProdSup);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 343);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Product && Suppliers ";
            // 
            // packages_Products_SuppliersBindingSource
            // 
            this.packages_Products_SuppliersBindingSource.DataSource = typeof(TravelExpertsLibrary.Packages_Products_Suppliers);
            // 
            // btnDeletePackProdSup
            // 
            this.btnDeletePackProdSup.Location = new System.Drawing.Point(367, 210);
            this.btnDeletePackProdSup.Name = "btnDeletePackProdSup";
            this.btnDeletePackProdSup.Size = new System.Drawing.Size(113, 40);
            this.btnDeletePackProdSup.TabIndex = 8;
            this.btnDeletePackProdSup.Text = "&Delete";
            this.btnDeletePackProdSup.UseVisualStyleBackColor = true;
            this.btnDeletePackProdSup.Click += new System.EventHandler(this.btnDeletePackProdSup_Click);
            // 
            // btnModifyPackProdSup
            // 
            this.btnModifyPackProdSup.Location = new System.Drawing.Point(236, 210);
            this.btnModifyPackProdSup.Name = "btnModifyPackProdSup";
            this.btnModifyPackProdSup.Size = new System.Drawing.Size(113, 40);
            this.btnModifyPackProdSup.TabIndex = 8;
            this.btnModifyPackProdSup.Text = "&Modify";
            this.btnModifyPackProdSup.UseVisualStyleBackColor = true;
            this.btnModifyPackProdSup.Click += new System.EventHandler(this.btnModifyPackProdSup_Click);
            // 
            // btnAddPackProdSup
            // 
            this.btnAddPackProdSup.Location = new System.Drawing.Point(105, 210);
            this.btnAddPackProdSup.Name = "btnAddPackProdSup";
            this.btnAddPackProdSup.Size = new System.Drawing.Size(113, 40);
            this.btnAddPackProdSup.TabIndex = 8;
            this.btnAddPackProdSup.Text = "&Add";
            this.btnAddPackProdSup.UseVisualStyleBackColor = true;
            this.btnAddPackProdSup.Click += new System.EventHandler(this.btnAddPackProdSup_Click);
            // 
            // Products
            // 
            this.Products.AutoScroll = true;
            this.Products.Controls.Add(this.productDataGridView);
            this.Products.Controls.Add(this.btnDeleteProduct);
            this.Products.Controls.Add(this.btnModifyProduct);
            this.Products.Controls.Add(this.btnAddProduct);
            this.Products.Location = new System.Drawing.Point(4, 33);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(1144, 639);
            this.Products.TabIndex = 0;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToOrderColumns = true;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(28, 26);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.Size = new System.Drawing.Size(446, 311);
            this.productDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 122;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TravelExpertsLibrary.Product);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(379, 571);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(113, 40);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(194, 571);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(113, 40);
            this.btnModifyProduct.TabIndex = 1;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(30, 571);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(113, 40);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // Suppliers
            // 
            this.Suppliers.AutoScroll = true;
            this.Suppliers.Controls.Add(this.supplierDataGridView);
            this.Suppliers.Controls.Add(this.btnDeleteSupplier);
            this.Suppliers.Controls.Add(this.btnModifySupplier);
            this.Suppliers.Controls.Add(this.btnAddSupplier);
            this.Suppliers.Location = new System.Drawing.Point(4, 33);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(1144, 639);
            this.Suppliers.TabIndex = 2;
            this.Suppliers.Text = "Suppliers";
            this.Suppliers.UseVisualStyleBackColor = true;
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.AllowUserToAddRows = false;
            this.supplierDataGridView.AllowUserToDeleteRows = false;
            this.supplierDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.supplierDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.supplierDataGridView.AutoGenerateColumns = false;
            this.supplierDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.supplierDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.supplierDataGridView.DataSource = this.supplierBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.supplierDataGridView.Location = new System.Drawing.Point(28, 26);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.ReadOnly = true;
            this.supplierDataGridView.Size = new System.Drawing.Size(541, 311);
            this.supplierDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn3.HeaderText = "Supplier ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 127;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(TravelExpertsLibrary.Supplier);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(361, 388);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(113, 40);
            this.btnDeleteSupplier.TabIndex = 6;
            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnModifySupplier
            // 
            this.btnModifySupplier.Location = new System.Drawing.Point(193, 388);
            this.btnModifySupplier.Name = "btnModifySupplier";
            this.btnModifySupplier.Size = new System.Drawing.Size(113, 40);
            this.btnModifySupplier.TabIndex = 5;
            this.btnModifySupplier.Text = "Modify";
            this.btnModifySupplier.UseVisualStyleBackColor = true;
            this.btnModifySupplier.Click += new System.EventHandler(this.btnModifySupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(28, 388);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(113, 40);
            this.btnAddSupplier.TabIndex = 4;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // Product_Suppliers
            // 
            this.Product_Suppliers.AutoScroll = true;
            this.Product_Suppliers.Controls.Add(this.product_SupplierDataGridView);
            this.Product_Suppliers.Controls.Add(this.btnDeleteProductSupplier);
            this.Product_Suppliers.Controls.Add(this.btnModifyProductSupplier);
            this.Product_Suppliers.Controls.Add(this.btnAddProductSupplier);
            this.Product_Suppliers.Location = new System.Drawing.Point(4, 33);
            this.Product_Suppliers.Name = "Product_Suppliers";
            this.Product_Suppliers.Size = new System.Drawing.Size(1144, 639);
            this.Product_Suppliers.TabIndex = 3;
            this.Product_Suppliers.Text = "Product_Suppliers";
            this.Product_Suppliers.UseVisualStyleBackColor = true;
            // 
            // product_SupplierDataGridView
            // 
            this.product_SupplierDataGridView.AutoGenerateColumns = false;
            this.product_SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_SupplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.product_SupplierDataGridView.DataSource = this.product_SupplierBindingSource;
            this.product_SupplierDataGridView.Location = new System.Drawing.Point(36, 33);
            this.product_SupplierDataGridView.Name = "product_SupplierDataGridView";
            this.product_SupplierDataGridView.Size = new System.Drawing.Size(544, 313);
            this.product_SupplierDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ProductSupplierID";
            this.dataGridViewTextBoxColumn17.HeaderText = "ProductSupplierID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 187;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn20.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 126;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn21.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn21.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // product_SupplierBindingSource
            // 
            this.product_SupplierBindingSource.DataSource = typeof(TravelExpertsLibrary.Product_Supplier);
            // 
            // btnDeleteProductSupplier
            // 
            this.btnDeleteProductSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteProductSupplier.Location = new System.Drawing.Point(372, 485);
            this.btnDeleteProductSupplier.Name = "btnDeleteProductSupplier";
            this.btnDeleteProductSupplier.Size = new System.Drawing.Size(113, 40);
            this.btnDeleteProductSupplier.TabIndex = 6;
            this.btnDeleteProductSupplier.Text = "Delete";
            this.btnDeleteProductSupplier.UseVisualStyleBackColor = false;
            this.btnDeleteProductSupplier.Click += new System.EventHandler(this.btnDeleteProductSupplier_Click);
            // 
            // btnModifyProductSupplier
            // 
            this.btnModifyProductSupplier.Location = new System.Drawing.Point(218, 450);
            this.btnModifyProductSupplier.Name = "btnModifyProductSupplier";
            this.btnModifyProductSupplier.Size = new System.Drawing.Size(113, 40);
            this.btnModifyProductSupplier.TabIndex = 5;
            this.btnModifyProductSupplier.Text = "Modify";
            this.btnModifyProductSupplier.UseVisualStyleBackColor = true;
            this.btnModifyProductSupplier.Click += new System.EventHandler(this.btnModifyProductSupplier_Click);
            // 
            // btnAddProductSupplier
            // 
            this.btnAddProductSupplier.Location = new System.Drawing.Point(90, 435);
            this.btnAddProductSupplier.Name = "btnAddProductSupplier";
            this.btnAddProductSupplier.Size = new System.Drawing.Size(113, 40);
            this.btnAddProductSupplier.TabIndex = 4;
            this.btnAddProductSupplier.Text = "Add";
            this.btnAddProductSupplier.UseVisualStyleBackColor = true;
            this.btnAddProductSupplier.Click += new System.EventHandler(this.btnAddProductSupplier_Click);
            // 
            // packages_Products_SuppliersDataGridView
            // 
            this.packages_Products_SuppliersDataGridView.AutoGenerateColumns = false;
            this.packages_Products_SuppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packages_Products_SuppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.packages_Products_SuppliersDataGridView.DataSource = this.packages_Products_SuppliersBindingSource;
            this.packages_Products_SuppliersDataGridView.Location = new System.Drawing.Point(20, 30);
            this.packages_Products_SuppliersDataGridView.Name = "packages_Products_SuppliersDataGridView";
            this.packages_Products_SuppliersDataGridView.Size = new System.Drawing.Size(624, 145);
            this.packages_Products_SuppliersDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductSupplerID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ProductSupplerID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn15.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn16.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // TravelExpertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1152, 676);
            this.Controls.Add(this.tabControl1);
            this.Name = "TravelExpertsForm";
            this.Text = "Travel Experts";
            this.Load += new System.EventHandler(this.TravelExpertsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Packages.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersBindingSource)).EndInit();
            this.Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.Suppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.Product_Suppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.product_SupplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabPage Packages;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.Button btnModifyPackage;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.TabPage Suppliers;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnModifySupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.TabPage Product_Suppliers;
        private System.Windows.Forms.Button btnDeleteProductSupplier;
        private System.Windows.Forms.Button btnModifyProductSupplier;
        private System.Windows.Forms.Button btnAddProductSupplier;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView supplierDataGridView;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource product_SupplierBindingSource;
        private System.Windows.Forms.DataGridView packageDataGridView;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.BindingSource packages_Products_SuppliersBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeletePackProdSup;
        private System.Windows.Forms.Button btnModifyPackProdSup;
        private System.Windows.Forms.Button btnAddPackProdSup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView product_SupplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridView packages_Products_SuppliersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}