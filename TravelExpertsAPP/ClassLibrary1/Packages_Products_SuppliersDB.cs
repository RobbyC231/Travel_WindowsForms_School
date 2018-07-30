using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsLibrary
{
    public class Packages_Products_SuppliersDB
    {
        public static List<Packages_Products_Suppliers> GetAllPackagesProductsSuppliers(Package package)
        {
            List<Packages_Products_Suppliers> packProdSups = new List<Packages_Products_Suppliers>();
            Packages_Products_Suppliers packProdSup = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT p.ProdName, s.SupName " +
                                     "FROM Packages_Products_Suppliers pps " +
                                     "INNER JOIN Products_Suppliers ps ON pps.ProductSupplierID = ps.ProductSupplierID " +
                                     "INNER JOIN Products p ON ps.ProductID = p.ProductID " +
                                     "INNER JOIN Suppliers s ON ps.SupplierID = s.SupplierID " +
                                     "WHERE PackageID = @PackageID";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@PackageID", package.PackageId);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    packProdSup = new Packages_Products_Suppliers();
                    packProdSup.ProdName = reader["ProdName"].ToString();
                    packProdSup.SupName = reader["SupName"].ToString();
                    packProdSups.Add(packProdSup);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return packProdSups;
        }

        public static void Add(Product_Supplier productSupplier, Package package)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Packages_Products_Suppliers (PackageID, ProductSupplierID) " +
                                        "VALUES (@PackageID, @ProductSupplierID)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@PackageID", package.PackageId);
            cmd.Parameters.AddWithValue("@ProductSupplierID", productSupplier.ProductSupplierID);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
