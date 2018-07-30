using System;
using System.Collections.Generic;
using System.Data.SqlClient;

/*
 * Author: Brian Liang
 * Date: July/Aug 2018
 */

namespace TravelExpertsLibrary
{
    public static class PackageDB
    {
        public static List<Package> GetPackage()
        {
            List<Package> packages = new List<Package>();
            Package pack = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT PackageID, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                                     "FROM Packages";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // found a package
                {
                    pack = new Package();
                    pack.PackageId = (int)reader["PackageID"];
                    pack.PkgName = reader["PkgName"].ToString();
                    pack.PkgStartDate = (DateTime)reader["PkgStartDate"];
                    pack.PkgEndDate = (DateTime)reader["PkgEndDate"];
                    pack.PkgDesc = reader["PkgDesc"].ToString();
                    pack.PkgBasePrice = Convert.ToDouble(reader["PkgBasePrice"]);
                    pack.PkgAgencyCommission = Convert.ToDouble(reader["PkgAgencyCommission"]);
                    packages.Add(pack);
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
            return packages;
        }

        public static bool DeletePackage(Package package)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string deleteStatement = "Delete FROM Packages " +
                                     "WHERE PackageId = @PackageId " +
                                     "AND PkgName = @PkgName " +
                                     "AND PkgStartDate = @PkgStartDate " +
                                     "AND PkgEndDate = @PkgEndDate " +
                                     "AND PkgDesc = @PkgDesc " +
                                     "AND PkgBasePrice = @PkgBasePrice " +
                                     "AND PkgAgencyCommission = @PkgAgencyCommission";
            SqlCommand cmd = new SqlCommand(deleteStatement, con);
            cmd.Parameters.AddWithValue("@PackageId", package.PackageId);
            cmd.Parameters.AddWithValue("@PkgName", package.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);
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

        public static int AddPackage(Package package)
        {
            int packageID;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                                        "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@PkgName", package.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                String selectQuery = "SELECT IDENT_CURRENT('Packages')";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                packageID = Convert.ToInt32(selectCmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return packageID;
        }
        public static int GetNextPackageID()
        {
            int supplierID;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectQuery = "SELECT IDENT_CURRENT('Packages') + IDENT_INCR('Packages')";
            SqlCommand selectCmd = new SqlCommand(selectQuery, con);
            try
            {
                con.Open();
                supplierID = Convert.ToInt32(selectCmd.ExecuteScalar());
                return supplierID;
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

        public static bool UpdatePackages(Package oldPackage, Package newPackage)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Packages " +
                                     "SET PkgName = @NewPkgName, " +
                                     "PkgStartDate = @NewPkgStartDate, " +
                                     "PkgEndDate = @NewPkgEndDate, " +
                                     "PkgDesc = @NewPkgDesc, " +
                                     "PkgBasePrice = @NewPkgBasePrice, " +
                                     "PkgAgencyCommission = @NewPkgAgencyCommission " +
                                     "WHERE PackageID = @OldPackageID " +
                                     "AND PkgName = @OldPkgName " +
                                     "AND PkgStartDate = @OldPkgStartDate " +
                                     "AND PkgEndDate = @OldPkgEndDate " +
                                     "AND PkgDesc = @OldPkgDesc " +
                                     "AND PkgBasePrice = @OldPkgBasePrice " +
                                     "AND PkgAgencyCommission = @OldPkgAgencyCommission";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@NewPkgName", newPackage.PkgName);
            cmd.Parameters.AddWithValue("@NewPkgStartDate", newPackage.PkgStartDate);
            cmd.Parameters.AddWithValue("@NewPkgEndDate", newPackage.PkgEndDate);
            cmd.Parameters.AddWithValue("@NewPkgDesc", newPackage.PkgDesc);
            cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPackage.PkgBasePrice);
            cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newPackage.PkgAgencyCommission);
            //start adding values of old package
            cmd.Parameters.AddWithValue("@OldPackageId", oldPackage.PackageId);
            cmd.Parameters.AddWithValue("@OldPkgName", oldPackage.PkgName);
            cmd.Parameters.AddWithValue("@OldPkgStartDate", oldPackage.PkgStartDate);
            cmd.Parameters.AddWithValue("@OldPkgEndDate", oldPackage.PkgEndDate);
            cmd.Parameters.AddWithValue("@OldPkgDesc", oldPackage.PkgDesc);
            cmd.Parameters.AddWithValue("@OldPkgBasePrice", oldPackage.PkgBasePrice);
            cmd.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPackage.PkgAgencyCommission);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
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
    }//end of class       
}//end of namespace
