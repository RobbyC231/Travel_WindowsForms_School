using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TravelExpertsLibrary;

namespace TravelExpertsAPP
{
    public partial class TravelExpertsForm : Form
    {
        List<Product> products;
        private Product product;
        
        List<Supplier> suppliers; //empty list       
        private Supplier supplier;
       
        public TravelExpertsForm()
        {
            InitializeComponent();
        }

        private void TravelExpertsForm_Load(object sender, EventArgs e)
        {
            DisplayProducts(); //calling method for displaying products
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
                product = addModifyProducts.product;
                DisplayProducts();
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
                    DisplayProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
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
            
        }
    } //end class travel experts form
} //end namespace
      
        // form-load event
        private void TravelExpertsForm_Load(object sender, EventArgs e)
        {           
            DisplaySupplier(); // bind the grid view to the suppliers list
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
                    DisplaySupplier();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
        /**********************************************Supplier's Session End*********************************************/
    }
}
