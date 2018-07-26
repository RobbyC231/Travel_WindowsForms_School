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
