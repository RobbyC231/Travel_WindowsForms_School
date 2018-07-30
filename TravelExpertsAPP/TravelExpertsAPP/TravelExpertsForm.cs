using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TravelExpertsLibrary;

namespace TravelExpertsAPP
{
    public partial class TravelExpertsForm : Form
    {
        List<Product> products; //holds list of returned products from database 
        private Product product;

        List<Product_Supplier> productSuppliers;
        private Product_Supplier productSupplier;
        
        List<Supplier> suppliers; //empty list       
        private Supplier supplier;

        List<Package> packages;
        public Package package;

        List<Packages_Products_Suppliers> packProdSups;
        private Packages_Products_Suppliers packProdSup;
       
        public TravelExpertsForm()
        {
            InitializeComponent();
        }

        private void TravelExpertsForm_Load(object sender, EventArgs e)
        {
            DisplayProducts(); //calling method for displaying products
            DisplaySupplier();
            DisplayProductSupplier();
            DisplayPackages();
            DisplayPackageProdSup();

        }

        private void DisplayPackages()
        {
            packages = PackageDB.GetPackage();
            packageDataGridView.DataSource = packages;

        }

        private void DisplayProductSupplier()
        {
            productSuppliers = Product_SupplierDB.GetProduct_Supplier();
            product_SupplierDataGridView.DataSource = productSuppliers;
        }

        /// <summary>
        /// Author: Robert Clements
        /// Purpose: displays all of the products from database in data grid view
        /// </summary>
        private void DisplayProducts()
        {
            products = ProductDB.GetAllProduct();
            productDataGridView.DataSource = products;
            
        }

        /// <summary>
        /// Author: Robert Clements
        /// Purpose: adds product to database when user clicks button 
        ///             then returns to the main form and reloads product data grid view
        /// </summary>
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddModifyProduct addModifyProducts = new AddModifyProduct(); // make new form
            addModifyProducts.addProdcut = true; //setting value to true to show add button was clicked
            DialogResult result = addModifyProducts.ShowDialog();
            if (result == DialogResult.OK) //if accept button was clicked
            {
                product = addModifyProducts.product; // TODO: might not need this code
                this.DisplayProducts();
                this.DisplayPackages();
            }
        }

        /// <summary>
        /// Author: Robert Clements
        /// Purpose: When user clicks delete button it will delete selected item in the data grid view
        /// </summary>
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SelectedRowProduct();

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (!ProductDB.DeleteProduct(product))
                    {
                        MessageBox.Show("Another user has updated or deleted product" + product.ProdName, "Datebase Error");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            DisplayProducts();
            DisplayPackages();
        }

        private void SelectedRowProduct()
        {
            product = new Product();
            int index = productDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = productDataGridView.Rows[index];
            product.ProductID = Convert.ToInt32(selectedRow.Cells[0].Value);
            product.ProdName = selectedRow.Cells[1].Value.ToString();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            SelectedRowProduct();
            AddModifyProduct modifyProduct = new AddModifyProduct();
            modifyProduct.addProdcut = false;
            modifyProduct.product = product;
            DialogResult result = modifyProduct.ShowDialog();
            DisplayProducts();
            DisplayPackages();
        }
      
        /**************************************************************************************************************
        * Author : Sneha Patel(000783907)
        * Date : 27th July, 2018
        * Purpose: Add, Modify and Delete Buttons Events
        **************************************************************************************************************/

        private void DisplaySupplier()
        {
            suppliers = SupplierDB.GetAllSuppliers();
            supplierDataGridView.DataSource = suppliers;         
        }

        private void SelectedRowSupplier()
        {
            supplier = new Supplier();
            int index = supplierDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = supplierDataGridView.Rows[index];
            supplier.SupplierId = Convert.ToInt32(selectedRow.Cells[0].Value);
            supplier.SupName = selectedRow.Cells[1].Value.ToString();
        }
         
        // Supplier's Add Button
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmSupplierAddModify addSupplierForm = new frmSupplierAddModify();
            addSupplierForm.addSupplier = true;
            DialogResult result = addSupplierForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                supplier = addSupplierForm.supplier;
                DisplaySupplier();
                DisplayPackages();
            }
        }

        // Supplier's Modify Button
        private void btnModifySupplier_Click(object sender, EventArgs e)
        {
            SelectedRowSupplier();
            frmSupplierAddModify modifySupplierForm = new frmSupplierAddModify();
            modifySupplierForm.addSupplier = false;
            modifySupplierForm.supplier = supplier;
            DialogResult result = modifySupplierForm.ShowDialog();
            DisplaySupplier();
            DisplayPackages();
        }

        // Supplier's Delete Button
        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO you really want to delete this Supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SelectedRowSupplier();

            if(result == DialogResult.Yes)
            {
                try
                {
                    if (!SupplierDB.DeleteSupplier(supplier))
                    {
                        MessageBox.Show("Another user has updated or deleted product" + supplier.SupName, "Datebase Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                DisplaySupplier();
                DisplayPackages();
            }
        }

        //end of Sneha code

        private void btnAddProductSupplier_Click(object sender, EventArgs e)
        {
            AddModifyProductsSupplier addProductsSupplier = new AddModifyProductsSupplier();
            addProductsSupplier.addProductSupplier = true;
            DialogResult result = addProductsSupplier.ShowDialog();
            if (result == DialogResult.OK)
            {
                productSupplier = addProductsSupplier.productSupplier;
                DisplayProductSupplier();
                DisplayPackages();
            }
        }

        private void btnDeleteProductSupplier_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SelectRowProducts_Suppliers();
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (!Product_SupplierDB.DeleteProduct_Supplier(productSupplier))
                    {
                        MessageBox.Show("Another user has updated or deleted this product supplier information", "Datebase Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            DisplayProductSupplier();
            DisplayPackages();
        }

        private void SelectRowProducts_Suppliers()
        {
            productSupplier = new Product_Supplier();
            int index = product_SupplierDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = product_SupplierDataGridView.Rows[index];
            productSupplier.ProductSupplierID = Convert.ToInt32(selectedRow.Cells[0].Value);
            productSupplier.ProductID = Convert.ToInt32(selectedRow.Cells[1].Value);
            productSupplier.SupplierID = Convert.ToInt32(selectedRow.Cells[2].Value);
        }

        private void btnModifyProductSupplier_Click(object sender, EventArgs e)
        {
            SelectRowProducts_Suppliers();
            AddModifyProductsSupplier modifyProductsSupplier = new AddModifyProductsSupplier();
            modifyProductsSupplier.addProductSupplier = false;
            modifyProductsSupplier.productSupplier = productSupplier;
            DialogResult result = modifyProductsSupplier.ShowDialog();
            DisplayProductSupplier();
            DisplayPackages();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            AddModifyPackages addModifyPackage = new AddModifyPackages();
            addModifyPackage.addPackage = true;
            DialogResult result = addModifyPackage.ShowDialog();
            if (result == DialogResult.OK)
            {
                package = addModifyPackage.package;
                this.DisplayPackages();
            }
        }

        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            SelectedRowPackage();
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (!PackageDB.DeletePackage(package))
                    {
                        MessageBox.Show("Another user has updated or deleted package" + package.PkgName, "Datebase Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                DisplayPackages();
            }

        }
        private void SelectedRowPackage()
        {
            package = new Package();
            int index = packageDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = packageDataGridView.Rows[index];
            package.PackageId = Convert.ToInt32(selectedRow.Cells[0].Value);
            package.PkgName = selectedRow.Cells[1].Value.ToString();
            package.PkgStartDate = Convert.ToDateTime(selectedRow.Cells[2].Value);
            package.PkgEndDate = Convert.ToDateTime(selectedRow.Cells[3].Value);
            package.PkgDesc = selectedRow.Cells[4].Value.ToString();
            package.PkgBasePrice = Convert.ToDouble(selectedRow.Cells[5].Value);
            package.PkgAgencyCommission = Convert.ToDouble(selectedRow.Cells[6].Value);
        }

        private void btnModifyPackage_Click(object sender, EventArgs e)
        {
            SelectedRowPackage();
            AddModifyPackages modifyPackages = new AddModifyPackages();
            modifyPackages.addPackage = false;
            modifyPackages.package = package;
            DialogResult result = modifyPackages.ShowDialog();
            DisplayPackages();
        }

        private void packageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayPackageProdSup();
        }

        private void DisplayPackageProdSup()
        {
            SelectedRowPackage();
            packProdSups = Packages_Products_SuppliersDB.GetAllPackagesProductsSuppliers(package);
            packages_Products_SuppliersDataGridView.DataSource = packProdSups;
        }

        private void btnAddPackProdSup_Click(object sender, EventArgs e)
        {
            SelectedRowPackage();
            AddModifyProdSup addModifyProdSup = new AddModifyProdSup();
            addModifyProdSup.addPackageProdSup = true;
            addModifyProdSup.package = package;
            DialogResult result = addModifyProdSup.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.DisplayPackages();
                this.DisplayProductSupplier();
            }
        }
    }//end of class
}//end of namespace
