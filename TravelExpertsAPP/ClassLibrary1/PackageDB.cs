using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsLibrary
{
    public static class PackageDB
    {
        public static Package GetPackage(int packageID)
        {
            Package pack = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                                     "FROM Packages " +
                                     "WHERE PackageID = @PackageID";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@PackageID", packageID); // value comes from the method's argument
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read()) // found a package
                {
                    pack = new Package();
                    pack.PkgName = reader["PkgName"].ToString();
                    pack.PkgStartDate = (DateTime)reader["PkgStartDate"];
                    pack.PkgEndDate = (DateTime)reader["PkgEndDate"];
                    pack.PkgDesc = reader["PkgDesc"].ToString();
                    pack.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    pack.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
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
            return pack;
        }

        public static bool deletePackage(Package PS)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string deleteStatement = "delete from Product_Suppliers where ProductSupplierID = @ProductSupplierID " +
                                        "and ProductID= @ProductID " +
                                        "and SupplierID=@SupplierID";
            SqlCommand cmd = new SqlCommand(deleteStatement, con);
            cmd.Parameters.AddWithValue("@ProductSupplierID", PS.ProductSupplierID);
            cmd.Parameters.AddWithValue("@ProductID", PS.ProductID);
            cmd.Parameters.AddWithValue("@SupplierID", PS.SupplierID);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
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
        }
    }
        
}
