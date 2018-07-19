using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsLibrary
{
    public static class Package_Product_SupplierDB
    {
        public static List<Package_Product_Supplier> GetPPS()
        {
            List<Package_Product_Supplier> ppsList = new List<Package_Product_Supplier>(); 

            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT PackageID, ProductSupplierID FROM Package_Product_Supplier ORDER BY PackageID";
            SqlCommand cmd = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Package_Product_Supplier pps;
                while (reader.Read()) 
                {
                    pps = new Package_Product_Supplier();
                    pps.PackageID = (int)reader["PackageID"];
                    pps.ProductSupplierID = (int)reader["StateName"];
                    ppsList.Add(pps);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return ppsList;
        }
    }
}
