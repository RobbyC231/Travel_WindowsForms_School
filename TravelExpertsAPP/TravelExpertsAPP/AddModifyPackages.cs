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
    public partial class AddModifyPackages : Form
    {
        public bool addPackage;
        public Package package;
        public List<Product_Supplier> productsSuppliers; 
        public AddModifyPackages()
        {
            InitializeComponent();
        }

        private void AddModifyPackages_Load(object sender, EventArgs e)
        {
            if (addPackage) //if addProduct is true then add button was picked
            {
                this.Text = "Add Package";//changed form title
                txtPackageId.Text = PackageDB.GetNextPackageID().ToString();
            }
            else //if modify button was picked
            {
                this.Text = "Modify Package";
                this.DisplayPackage();
            }
        }

        private void DisplayPackage()
        {
            txtPackageId.Text = package.PackageId.ToString();
            txtPkgName.Text = package.PkgName;
            txtPkgAgencyCommission.Text = package.PkgAgencyCommission.ToString();
            txtBasePrice.Text = package.PkgBasePrice.ToString();
            txtPkgDescription.Text = package.PkgDesc;
            dtpPkgEndDate.Text = package.PkgEndDate.ToShortDateString();
            dtpPkgStartDate.Text = package.PkgStartDate.ToShortDateString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidDate())
            {

                if (addPackage)
                {
                    package = new Package();
                    this.PackageData(package);
                    try
                    {
                        package.PackageId = PackageDB.AddPackage(package);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    Package newPackage = new Package();
                    newPackage.PackageId = package.PackageId;
                    this.PackageData(newPackage);
                    try
                    {
                        if (!PackageDB.UpdatePackages(package, newPackage))
                        {
                            MessageBox.Show("Another user has updated or deleted " +
                                   package.PkgName, "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
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

        private bool ValidDate()
        {
            return
                Validator.IsPresent(txtPkgAgencyCommission) &&
                Validator.IsPresent(txtBasePrice) &&
                Validator.IsPresent(txtPkgDescription) &&
                Validator.IsPresent(txtPkgName) &&
                Validator.EndAfterStart(dtpPkgStartDate, dtpPkgEndDate) &&
                Validator.IsDecimal(txtBasePrice) &&
                Validator.IsDecimal(txtPkgAgencyCommission) &&
                Validator.AgentCommissionLessBasePrice(txtBasePrice, txtPkgAgencyCommission);
        }

        private void PackageData(Package package)
        {
            package.PkgName = txtPkgName.Text;
            package.PkgStartDate = Convert.ToDateTime(dtpPkgStartDate.Text);
            package.PkgEndDate = Convert.ToDateTime(dtpPkgEndDate.Text);
            package.PkgDesc = txtPkgDescription.Text;
            package.PkgBasePrice = Convert.ToDouble(txtBasePrice.Text);
            package.PkgAgencyCommission = Convert.ToDouble(txtPkgAgencyCommission.Text);

        }

    }
}
