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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Packages = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeletePackProdSup = new System.Windows.Forms.Button();
            this.btnModifyPackProdSup = new System.Windows.Forms.Button();
            this.btnAddPackProdSup = new System.Windows.Forms.Button();
            this.packages_Products_SuppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packages_Products_SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.btnModifyPackage = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
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
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteProductSupplier = new System.Windows.Forms.Button();
            this.btnModifyProductSupplier = new System.Windows.Forms.Button();
            this.btnAddProductSupplier = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.Packages.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.Product_Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_SupplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_SupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Packages);
            this.tabControl1.Controls.Add(this.Products);
            this.tabControl1.Controls.Add(this.Suppliers);
            this.tabControl1.Controls.Add(this.Product_Suppliers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1126, 594);
            this.tabControl1.TabIndex = 0;
            // 
            // Packages
            // 
            this.Packages.AutoScroll = true;
            this.Packages.Controls.Add(this.groupBox1);
            this.Packages.Controls.Add(this.packageDataGridView);
            this.Packages.Controls.Add(this.btnDeletePackage);
            this.Packages.Controls.Add(this.btnModifyPackage);
            this.Packages.Controls.Add(this.btnAddPackage);
            this.Packages.Location = new System.Drawing.Point(4, 22);
            this.Packages.Name = "Packages";
            this.Packages.Padding = new System.Windows.Forms.Padding(3);
            this.Packages.Size = new System.Drawing.Size(1118, 568);
            this.Packages.TabIndex = 1;
            this.Packages.Text = "Packages";
            this.Packages.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeletePackProdSup);
            this.groupBox1.Controls.Add(this.btnModifyPackProdSup);
            this.groupBox1.Controls.Add(this.btnAddPackProdSup);
            this.groupBox1.Controls.Add(this.packages_Products_SuppliersDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(463, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 238);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Product && Suppliers ";
            // 
            // btnDeletePackProdSup
            // 
            this.btnDeletePackProdSup.Location = new System.Drawing.Point(214, 191);
            this.btnDeletePackProdSup.Name = "btnDeletePackProdSup";
            this.btnDeletePackProdSup.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePackProdSup.TabIndex = 8;
            this.btnDeletePackProdSup.Text = "&Delete";
            this.btnDeletePackProdSup.UseVisualStyleBackColor = true;
            // 
            // btnModifyPackProdSup
            // 
            this.btnModifyPackProdSup.Location = new System.Drawing.Point(119, 191);
            this.btnModifyPackProdSup.Name = "btnModifyPackProdSup";
            this.btnModifyPackProdSup.Size = new System.Drawing.Size(75, 23);
            this.btnModifyPackProdSup.TabIndex = 8;
            this.btnModifyPackProdSup.Text = "&Modify";
            this.btnModifyPackProdSup.UseVisualStyleBackColor = true;
            // 
            // btnAddPackProdSup
            // 
            this.btnAddPackProdSup.Location = new System.Drawing.Point(21, 191);
            this.btnAddPackProdSup.Name = "btnAddPackProdSup";
            this.btnAddPackProdSup.Size = new System.Drawing.Size(75, 23);
            this.btnAddPackProdSup.TabIndex = 8;
            this.btnAddPackProdSup.Text = "&Add";
            this.btnAddPackProdSup.UseVisualStyleBackColor = true;
            this.btnAddPackProdSup.Click += new System.EventHandler(this.btnAddPackProdSup_Click);
            // 
            // packages_Products_SuppliersDataGridView
            // 
            this.packages_Products_SuppliersDataGridView.AutoGenerateColumns = false;
            this.packages_Products_SuppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packages_Products_SuppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.packages_Products_SuppliersDataGridView.DataSource = this.packages_Products_SuppliersBindingSource;
            this.packages_Products_SuppliersDataGridView.Location = new System.Drawing.Point(21, 31);
            this.packages_Products_SuppliersDataGridView.Name = "packages_Products_SuppliersDataGridView";
            this.packages_Products_SuppliersDataGridView.Size = new System.Drawing.Size(268, 129);
            this.packages_Products_SuppliersDataGridView.TabIndex = 6;
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
            // packages_Products_SuppliersBindingSource
            // 
            this.packages_Products_SuppliersBindingSource.DataSource = typeof(TravelExpertsLibrary.Packages_Products_Suppliers);
            // 
            // packageDataGridView
            // 
            this.packageDataGridView.AutoGenerateColumns = false;
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
            this.packageDataGridView.Location = new System.Drawing.Point(8, 21);
            this.packageDataGridView.Name = "packageDataGridView";
            this.packageDataGridView.Size = new System.Drawing.Size(771, 214);
            this.packageDataGridView.TabIndex = 6;
            this.packageDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.packageDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PackageId";
            this.dataGridViewTextBoxColumn8.HeaderText = "PackageId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PkgName";
            this.dataGridViewTextBoxColumn9.HeaderText = "PkgName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PkgStartDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "PkgStartDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PkgEndDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "PkgEndDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PkgDesc";
            this.dataGridViewTextBoxColumn12.HeaderText = "PkgDesc";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PkgBasePrice";
            this.dataGridViewTextBoxColumn13.HeaderText = "PkgBasePrice";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PkgAgencyCommission";
            this.dataGridViewTextBoxColumn14.HeaderText = "PkgAgencyCommission";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(TravelExpertsLibrary.Package);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.Location = new System.Drawing.Point(248, 262);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePackage.TabIndex = 6;
            this.btnDeletePackage.Text = "&Delete";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // btnModifyPackage
            // 
            this.btnModifyPackage.Location = new System.Drawing.Point(148, 262);
            this.btnModifyPackage.Name = "btnModifyPackage";
            this.btnModifyPackage.Size = new System.Drawing.Size(75, 23);
            this.btnModifyPackage.TabIndex = 5;
            this.btnModifyPackage.Text = "&Modify";
            this.btnModifyPackage.UseVisualStyleBackColor = true;
            this.btnModifyPackage.Click += new System.EventHandler(this.btnModifyPackage_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(30, 262);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(75, 23);
            this.btnAddPackage.TabIndex = 4;
            this.btnAddPackage.Text = "&Add";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // Products
            // 
            this.Products.AutoScroll = true;
            this.Products.Controls.Add(this.productDataGridView);
            this.Products.Controls.Add(this.btnDeleteProduct);
            this.Products.Controls.Add(this.btnModifyProduct);
            this.Products.Controls.Add(this.btnAddProduct);
            this.Products.Location = new System.Drawing.Point(4, 22);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(1118, 568);
            this.Products.TabIndex = 0;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(51, 42);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(300, 220);
            this.productDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TravelExpertsLibrary.Product);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(276, 286);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(163, 286);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(75, 23);
            this.btnModifyProduct.TabIndex = 1;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(51, 286);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
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
            this.Suppliers.Location = new System.Drawing.Point(4, 22);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(1118, 568);
            this.Suppliers.TabIndex = 2;
            this.Suppliers.Text = "Suppliers";
            this.Suppliers.UseVisualStyleBackColor = true;
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.AutoGenerateColumns = false;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.supplierDataGridView.DataSource = this.supplierBindingSource;
            this.supplierDataGridView.Location = new System.Drawing.Point(8, 21);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.ReadOnly = true;
            this.supplierDataGridView.Size = new System.Drawing.Size(338, 292);
            this.supplierDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn3.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 79;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn4.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 79;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(TravelExpertsLibrary.Supplier);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(489, 344);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSupplier.TabIndex = 6;
            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnModifySupplier
            // 
            this.btnModifySupplier.Location = new System.Drawing.Point(345, 344);
            this.btnModifySupplier.Name = "btnModifySupplier";
            this.btnModifySupplier.Size = new System.Drawing.Size(75, 23);
            this.btnModifySupplier.TabIndex = 5;
            this.btnModifySupplier.Text = "Modify";
            this.btnModifySupplier.UseVisualStyleBackColor = true;
            this.btnModifySupplier.Click += new System.EventHandler(this.btnModifySupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(208, 344);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(75, 23);
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
            this.Product_Suppliers.Location = new System.Drawing.Point(4, 22);
            this.Product_Suppliers.Name = "Product_Suppliers";
            this.Product_Suppliers.Size = new System.Drawing.Size(1118, 568);
            this.Product_Suppliers.TabIndex = 3;
            this.Product_Suppliers.Text = "Product_Suppliers";
            this.Product_Suppliers.UseVisualStyleBackColor = true;
            // 
            // product_SupplierDataGridView
            // 
            this.product_SupplierDataGridView.AutoGenerateColumns = false;
            this.product_SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_SupplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.product_SupplierDataGridView.DataSource = this.product_SupplierBindingSource;
            this.product_SupplierDataGridView.Location = new System.Drawing.Point(59, 25);
            this.product_SupplierDataGridView.Name = "product_SupplierDataGridView";
            this.product_SupplierDataGridView.Size = new System.Drawing.Size(351, 214);
            this.product_SupplierDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductSupplierID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ProductSupplierID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn7.HeaderText = "SupplierID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // product_SupplierBindingSource
            // 
            this.product_SupplierBindingSource.DataSource = typeof(TravelExpertsLibrary.Product_Supplier);
            // 
            // btnDeleteProductSupplier
            // 
            this.btnDeleteProductSupplier.Location = new System.Drawing.Point(335, 283);
            this.btnDeleteProductSupplier.Name = "btnDeleteProductSupplier";
            this.btnDeleteProductSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProductSupplier.TabIndex = 6;
            this.btnDeleteProductSupplier.Text = "Delete";
            this.btnDeleteProductSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteProductSupplier.Click += new System.EventHandler(this.btnDeleteProductSupplier_Click);
            // 
            // btnModifyProductSupplier
            // 
            this.btnModifyProductSupplier.Location = new System.Drawing.Point(186, 283);
            this.btnModifyProductSupplier.Name = "btnModifyProductSupplier";
            this.btnModifyProductSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnModifyProductSupplier.TabIndex = 5;
            this.btnModifyProductSupplier.Text = "Modify";
            this.btnModifyProductSupplier.UseVisualStyleBackColor = true;
            this.btnModifyProductSupplier.Click += new System.EventHandler(this.btnModifyProductSupplier_Click);
            // 
            // btnAddProductSupplier
            // 
            this.btnAddProductSupplier.Location = new System.Drawing.Point(74, 283);
            this.btnAddProductSupplier.Name = "btnAddProductSupplier";
            this.btnAddProductSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddProductSupplier.TabIndex = 4;
            this.btnAddProductSupplier.Text = "Add";
            this.btnAddProductSupplier.UseVisualStyleBackColor = true;
            this.btnAddProductSupplier.Click += new System.EventHandler(this.btnAddProductSupplier_Click);
            // 
            // TravelExpertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1126, 594);
            this.Controls.Add(this.tabControl1);
            this.Name = "TravelExpertsForm";
            this.Text = "TravelExpertsForm";
            this.Load += new System.EventHandler(this.TravelExpertsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Packages.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.Suppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.Product_Suppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.product_SupplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_SupplierBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView product_SupplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource product_SupplierBindingSource;
        private System.Windows.Forms.DataGridView packageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.DataGridView packages_Products_SuppliersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.BindingSource packages_Products_SuppliersBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeletePackProdSup;
        private System.Windows.Forms.Button btnModifyPackProdSup;
        private System.Windows.Forms.Button btnAddPackProdSup;
    }
}