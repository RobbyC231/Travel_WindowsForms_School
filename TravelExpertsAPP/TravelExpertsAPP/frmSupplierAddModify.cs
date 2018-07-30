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
/***************************************************************
 * Author : Sneha Patel(000783907)
 * Date : 24th July, 2018
 * Purpose: The application will also require simple add/edit 
 *          access for maintaining the suppliers data.
 ***************************************************************/
namespace TravelExpertsAPP
{
    public partial class frmSupplierAddModify : Form
    {
        public bool addSupplier;
        public Supplier supplier; // current supplier
        
        public frmSupplierAddModify()
        {
            InitializeComponent();
        }

        private void frmSupplierAddModify_Load(object sender, EventArgs e)
        {
            if (addSupplier)
            {
                this.Text = "Add Supplier";
                txtSupplierId.Text = SupplierDB.GetNextSupplierID().ToString();
            }
            else
            {
                this.Text = "Modify Supplier";
                this.DisplaySupplier();
            }
        }

        private void DisplaySupplier()
        {
            txtSupplierId.Text = supplier.SupplierId.ToString();
            txtSupName.Text = supplier.SupName;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                if (addSupplier)
                {
                    supplier = new Supplier();
                    this.PutSupplierData(supplier);
                    try
                    {
                        if (SupplierDB.AddSupplier(supplier))
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    Supplier newSupplier = new Supplier();
                    newSupplier.SupplierId = supplier.SupplierId;
                    this.PutSupplierData(newSupplier);
                    try
                    {
                        if (!SupplierDB.UpdateSupplier(supplier, newSupplier))
                        {
                            MessageBox.Show("Another user has updated or " +
                               "deleted that customer.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            //supplier = newSupplier;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                } 
            }
        }

        private bool ValidData()
        {
            return
                Validator.IsPresent(txtSupName);
        }

        private void PutSupplierData(Supplier supplier)
        {
            supplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
            supplier.SupName = txtSupName.Text;
        }
    }
}
