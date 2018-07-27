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
    public partial class TravelExpertsForm : Form
    {
        
        List<Supplier> suppliers; //empty list       
        private Supplier supplier;
       
        public TravelExpertsForm()
        {
            InitializeComponent();
        }
      
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
