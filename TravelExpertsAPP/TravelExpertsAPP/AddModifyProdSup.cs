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
    public partial class AddModifyProdSup : Form
    {
        public bool addPackageProdSup;
        public Product_Supplier productSupplier;
        public Package package;
        public AddModifyProdSup()
        {
            InitializeComponent();
        }

        private void AddModifyProdSup_Load(object sender, EventArgs e)
        {
            this.LoadComboBox();
            if (addPackageProdSup)
            {
                this.Text = "Add Product Supplier";
                cbProdName.SelectedIndex = -1;
                cbSupName.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Modify Product Supplier";
            }
        }
        private void LoadComboBox()
        {
            List<Product> products = new List<Product>();
            List<Supplier> suppliers = new List<Supplier>();
            try
            {
                products = ProductDB.GetAllProduct();
                cbProdName.DataSource = products;
                cbProdName.DisplayMember = "ProdName";
                cbProdName.ValueMember = "ProductID";

                suppliers = SupplierDB.GetAllSuppliers();
                cbSupName.DataSource = suppliers;
                cbSupName.DisplayMember = "SupName";
                cbSupName.ValueMember = "SupplierId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                if (addPackageProdSup)
                {
                    productSupplier = new Product_Supplier();
                    this.ProductSupplierData(productSupplier);
                    try
                    {
                        productSupplier.ProductSupplierID = Product_SupplierDB.AddProduct_Supplier(productSupplier);
                        Packages_Products_SuppliersDB.Add(productSupplier, package);
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
        }

        private bool ValidData()
        {
            return
                Validator.IsPresent(cbSupName) &&
                Validator.IsPresent(cbProdName);
        }
        private void ProductSupplierData(Product_Supplier productSupplier)
        {
            productSupplier.ProductID = Convert.ToInt32(cbProdName.SelectedValue);
            productSupplier.SupplierID = Convert.ToInt32(cbSupName.SelectedValue);
        }
    }
}
