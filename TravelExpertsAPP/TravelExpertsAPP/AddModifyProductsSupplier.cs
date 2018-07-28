using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsLibrary;

namespace TravelExpertsAPP
{
    public partial class AddModifyProductsSupplier : Form
    {
        public bool addProductSupplier;
        public Product_Supplier productSupplier;
        public AddModifyProductsSupplier()
        {
            InitializeComponent();
        }

        private void AddModifyProductsSupplier_Load(object sender, EventArgs e)
        {
            this.LoadComboBox();
            if (addProductSupplier)
            {
                this.Text = "Add Product Supplier";
                cbProductId.SelectedIndex = -1;
                cbSupplierID.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Modify Product Supplier";
                DisplayProductSuppliers();
            }
        }

        private void DisplayProductSuppliers()
        {
            cbProductId.SelectedValue = productSupplier.ProductID;
            cbSupplierID.SelectedValue = productSupplier.SupplierID;
        }

        private void LoadComboBox()
        {
            List<Product> products = new List<Product>();
            List<Supplier> suppliers = new List<Supplier>();
            try
            {
                products = ProductDB.GetAllProduct();
                cbProductId.DataSource = products;
                cbProductId.DisplayMember = "ProdName";
                cbProductId.ValueMember = "ProductID";

                suppliers = SupplierDB.GetAllSuppliers();
                cbSupplierID.DataSource = suppliers;
                cbSupplierID.DisplayMember = "SupName";
                cbSupplierID.ValueMember = "SupplierId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (addProductSupplier)
            {
                productSupplier = new Product_Supplier();
                this.ProductSupplierData(productSupplier);
                try
                {
                    productSupplier.ProductSupplierID = Product_SupplierDB.AddProduct_Supplier(productSupplier);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                Product_Supplier newProductSupplier = new Product_Supplier();
                newProductSupplier.ProductSupplierID = productSupplier.ProductSupplierID;
                this.ProductSupplierData(newProductSupplier);
                try
                {
                    if (!Product_SupplierDB.UpdateProduct_Supplier(productSupplier, newProductSupplier))
                    {
                        MessageBox.Show("Another user has updated or " +
                                "deleted that customer.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void ProductSupplierData(Product_Supplier productSupplier)
        {
            productSupplier.ProductID = Convert.ToInt32(cbProductId.SelectedValue);
            productSupplier.SupplierID = Convert.ToInt32(cbSupplierID.SelectedValue);
        }
    }
}
