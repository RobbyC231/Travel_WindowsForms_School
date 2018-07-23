using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Brian Liang
 * Date: July/Aug 2018
 */

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

        public static bool deletePackage(Package pkg)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string deleteStatement = "delete from Packages where PackageId = @PackageId ";

            SqlCommand cmd = new SqlCommand(deleteStatement, con);
            cmd.Parameters.AddWithValue("@PackageId", pkg.PackageId);
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

        public static int AddPackage(Package pkg)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "insert into Packages (PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission ) " +
                                        "values(@PackageId, @PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission )";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@PackageId", pkg.PackageId);
            cmd.Parameters.AddWithValue("@PkgName", pkg.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", pkg.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", pkg.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", pkg.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", pkg.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", pkg.PkgAgencyCommission);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                String selectQuery = "select ident_current('Packages') from Packages";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                int PackageId = Convert.ToInt32(selectCmd.ExecuteScalar());
                return PackageId;
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
