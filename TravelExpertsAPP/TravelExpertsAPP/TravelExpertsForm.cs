using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TravelExpertsLibrary;
/***************************************************************
* Author : Robert Clements
* Date : 23th July, 2018
* Purpose: main for which is the first form user sees
***************************************************************/
namespace TravelExpertsAPP
{
    public partial class TravelExpertsForm : Form
    {
        List<Product> products; //empty list
        private Product product; //product class

        List<Product_Supplier> productSuppliers; //empty list
        private Product_Supplier productSupplier; //product supplier class
        
        List<Supplier> suppliers; //empty list       
        private Supplier supplier; //supplier class

        List<Package> packages; //empty list
        public Package package; //package class

        List<Packages_Products_Suppliers> packProdSups; //empty list
        private Packages_Products_Suppliers packProdSup; //packages products suppliers object
       
        public TravelExpertsForm()
        {
            InitializeComponent();
        }

        private void TravelExpertsForm_Load(object sender, EventArgs e)
        {
            DisplayProducts(); //calling method for displaying products
            DisplaySupplier(); //calling method for displaying supplier
            DisplayProductSupplier(); //calling method for displaying product supplier
            DisplayPackages(); //calling method for displaying packages
            DisplayPackageProdSup(); //calling method for displaying packages products suppliers

        }
        //display packages
        private void DisplayPackages()
        {
            packages = PackageDB.GetPackage();
            packageDataGridView.DataSource = packages;

        }
        //display product supplier
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
                this.DisplayPackageProdSup();
            }
        }

        /// <summary>
        /// Author: Robert Clements
        /// Purpose: When user clicks delete button it will delete selected item in the data grid view
        /// </summary>
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            //message box asking to confrim deletion
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SelectedRowProduct();
            //if user picks yes from message box
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (!ProductDB.DeleteProduct(product)) //product delete method returns false
                    {
                        //inform user someone else has changed the database
                        MessageBox.Show("Another user has updated or deleted product" + product.ProdName, "Datebase Error");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            this.DisplayProducts();
            this.DisplayPackages();
            this.DisplayPackageProdSup();
        }
        //get the selected row by user in product
        private void SelectedRowProduct()
        {
            product = new Product();
            int index = productDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = productDataGridView.Rows[index];
            product.ProductID = Convert.ToInt32(selectedRow.Cells[0].Value);
            product.ProdName = selectedRow.Cells[1].Value.ToString();
        }
        //user clicks the modify button in the product tab 
        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            SelectedRowProduct();// get the row selected
            AddModifyProduct modifyProduct = new AddModifyProduct(); //call for the new form
            modifyProduct.addProdcut = false; //set add product to false indicating its modify button not add button pressed
            modifyProduct.product = product;
            DialogResult result = modifyProduct.ShowDialog(); //show new form
            this.DisplayProducts();
            this.DisplayPackages();
            this.DisplayPackageProdSup();
        }
      
        /**************************************************************************************************************
        * Author : Sneha Patel(000783907)
        * Date : 27th July, 2018
        * Purpose: Add, Modify and Delete Buttons Events
        **************************************************************************************************************/
        //display supplier table
        private void DisplaySupplier()
        {
            suppliers = SupplierDB.GetAllSuppliers();
            supplierDataGridView.DataSource = suppliers;         
        }
        //get user selected row for supplier table
        private void SelectedRowSupplier()
        {
            supplier = new Supplier();
            int index = supplierDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = supplierDataGridView.Rows[index];
            supplier.SupplierId = Convert.ToInt32(selectedRow.Cells[0].Value);
            supplier.SupName = selectedRow.Cells[1].Value.ToString();
        }
         
        // Supplier's Add Button in supplier tab
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            // call for new form
            frmSupplierAddModify addSupplierForm = new frmSupplierAddModify();
            addSupplierForm.addSupplier = true; //tells form the add button was pressed
            DialogResult result = addSupplierForm.ShowDialog(); // show form
            if (result == DialogResult.OK)//if user selects ok from add form
            {
                supplier = addSupplierForm.supplier;
                this.DisplaySupplier();
                this.DisplayPackages();
                this.DisplayPackageProdSup();
            }
        }

        // Supplier's Modify Button
        private void btnModifySupplier_Click(object sender, EventArgs e)
        {
            SelectedRowSupplier(); // gets info for user selected row
            //creates new form object
            frmSupplierAddModify modifySupplierForm = new frmSupplierAddModify();
            modifySupplierForm.addSupplier = false; //tells form the modift button was pressed
            modifySupplierForm.supplier = supplier; //passes values over to the supplier object in the form
            DialogResult result = modifySupplierForm.ShowDialog();
            this.DisplaySupplier();
            this.DisplayPackages();
            this.DisplayPackageProdSup();
        }

        // Supplier's Delete Button
        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO you really want to delete this Supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SelectedRowSupplier();//get user selected row values

            if(result == DialogResult.Yes) //if user clicks accept delete 
            {
                try
                {
                    if (!SupplierDB.DeleteSupplier(supplier)) //delete does not happen in database
                    {
                        MessageBox.Show("Another user has updated or deleted product" + supplier.SupName, "Datebase Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                this.DisplaySupplier();
                this.DisplayPackages();
                this.DisplayPackageProdSup();
            }
        }
        //end of Sneha code
        //add button clicked in prodcuts supplier tab
        private void btnAddProductSupplier_Click(object sender, EventArgs e)
        {
            AddModifyProductsSupplier addProductsSupplier = new AddModifyProductsSupplier();
            addProductsSupplier.addProductSupplier = true;
            DialogResult result = addProductsSupplier.ShowDialog();
            if (result == DialogResult.OK)
            {
                productSupplier = addProductsSupplier.productSupplier;
                this.DisplayProductSupplier();
                this.DisplayPackages();
                this.DisplayPackageProdSup();
            }
        }
        //delete button pressed for product supplier tab
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
            this.DisplayProductSupplier();
            this.DisplayPackages();
            this.DisplayPackageProdSup();
        }
        //get selected rows for products suppliers table
        private void SelectRowProducts_Suppliers()
        {
            productSupplier = new Product_Supplier();
            int index = product_SupplierDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = product_SupplierDataGridView.Rows[index];
            productSupplier.ProductSupplierID = Convert.ToInt32(selectedRow.Cells[0].Value);
            productSupplier.ProductID = Convert.ToInt32(selectedRow.Cells[1].Value);
            productSupplier.SupplierID = Convert.ToInt32(selectedRow.Cells[2].Value);
        }
        //modify button pressed in products supplier tab
        private void btnModifyProductSupplier_Click(object sender, EventArgs e)
        {
            SelectRowProducts_Suppliers();
            AddModifyProductsSupplier modifyProductsSupplier = new AddModifyProductsSupplier();
            modifyProductsSupplier.addProductSupplier = false;
            modifyProductsSupplier.productSupplier = productSupplier;
            DialogResult result = modifyProductsSupplier.ShowDialog();
            this.DisplayProductSupplier();
            this.DisplayPackages();
            this.DisplayPackageProdSup();
        }
        //add button pressed in package tab
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            AddModifyPackages addModifyPackage = new AddModifyPackages();
            addModifyPackage.addPackage = true;
            DialogResult result = addModifyPackage.ShowDialog();
            if (result == DialogResult.OK)
            {
                package = addModifyPackage.package;
                this.DisplayPackages();
                this.DisplayPackageProdSup();
            }
        }
        //delete button pressed in package tab
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
                this.DisplayPackages();
                this.DisplayPackageProdSup();
            }

        }
        //get values for user selected row
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
        //modify button pressed in package tab
        private void btnModifyPackage_Click(object sender, EventArgs e)
        {
            SelectedRowPackage();
            AddModifyPackages modifyPackages = new AddModifyPackages();
            modifyPackages.addPackage = false;
            modifyPackages.package = package;
            DialogResult result = modifyPackages.ShowDialog();
            this.DisplayPackages();
            this.DisplayPackageProdSup();
        }
        //when user clicks row in table showing package details
        private void packageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DisplayPackageProdSup(); //dispaly corresponding product and supplier info for selected package
        }
        //dispaly prodcut supplier info for certain package
        private void DisplayPackageProdSup()
        {
            SelectedRowPackage();
            packProdSups = Packages_Products_SuppliersDB.GetAllPackagesProductsSuppliers(package);
            packages_Products_SuppliersDataGridView.DataSource = packProdSups;
        }
        //add button pressed for package product supplier table on the pakcage tab
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
                this.DisplayPackageProdSup();
            }
        }

        private void btnModifyPackProdSup_Click(object sender, EventArgs e)
        {
            Packages_Products_Suppliers packProdSup = packProdSups[packages_Products_SuppliersDataGridView.CurrentCell.RowIndex];
            SelectedRowPackage();
            AddModifyProdSup addModifyProdSup = new AddModifyProdSup();
            addModifyProdSup.addPackageProdSup = false;
            addModifyProdSup.package = package;
            addModifyProdSup.packProdSup = packProdSup;
            DialogResult result = addModifyProdSup.ShowDialog();
            this.DisplayPackages();
            this.DisplayPackageProdSup();
        }

        private void btnDeletePackProdSup_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            SelectedRowPackage();
            SelectedRowProdSupPackages();
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (!Packages_Products_SuppliersDB.Delete(packProdSup, package))
                    {
                        MessageBox.Show("Another user has updated or deleted Product " + product.ProdName + " and " + supplier.SupName, "Datebase Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                this.DisplayPackages();
                this.DisplayPackageProdSup();
            }
        }

        private void SelectedRowProdSupPackages()
        {
            packProdSup = new Packages_Products_Suppliers();
            int index = packages_Products_SuppliersDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = packages_Products_SuppliersDataGridView.Rows[index];
            packProdSup.ProductSupplerID = (int)selectedRow.Cells[0].Value;
            packProdSup.ProdName = selectedRow.Cells[1].Value.ToString();
            packProdSup.SupName = selectedRow.Cells[2].Value.ToString();
        }
    }//end of class
}//end of namespace
