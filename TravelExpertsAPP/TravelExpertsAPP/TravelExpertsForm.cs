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
        const int EDIT_BUTTON_INDX = 2;

        List<Supplier> suppliers; //empty list       
        private Supplier supplier;
        int indexrow;

        public TravelExpertsForm()
        {
            InitializeComponent();
        }

        

            // form-load event
        private void TravelExpertsForm_Load(object sender, EventArgs e)
        {           
            DisplaySupplier(); // bind the grid view to the suppliers list
        }

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
      
        /***************************************************************
         * Author : Sneha Patel(000783907)
         * Date : 24th July, 2018
         * Purpose: The application will also require simple add/edit 
         *          access for maintaining the suppliers data.
         ***************************************************************/

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
            
        }

        
    }
}
