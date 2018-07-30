using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************
 * Author : Sneha Patel(000783907)
 * Date : 20th July, 2018
 * Purpose: The application will also require simple add/edit 
 *          access for maintaining the suppliers data.
 ***************************************************************/
namespace TravelExpertsLibrary
{
    // Database class for Supplier table in Travel-Experts Database
    public static class SupplierDB
    {
        public static List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>(); //empty list
            Supplier s = null;
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT SupplierId, SupName " +
                                     "FROM Suppliers";
            SqlCommand cmd = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // while there is another record
                {
                    s = new Supplier();
                    s.SupplierId = (int)reader["SupplierId"];
                    s.SupName = reader["SupName"].ToString();
                    suppliers.Add(s);
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
            return suppliers;
        }

        /// <summary>
        /// Adds a new supplier to the Suppliers table in TravelExperts database
        /// </summary>
        /// <param name="s"> supplier object that cotaing data for the new record</param>
        /// <returns>generated SupplierId</returns>
        public static bool AddSupplier(Supplier supplier)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Suppliers (SupplierId, SupName) " +
                                     "VALUES(@SupplierId, @SupName)";
            SqlCommand cmd = new SqlCommand(insertStatement, connection);
            cmd.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
            cmd.Parameters.AddWithValue("@SupName", supplier.SupName);
            try
            {
                connection.Open();
                int count = cmd.ExecuteNonQuery(); // run the insert command 
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int GetNextSupplierID()
        {
            int supplierID;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectQuery = "SELECT MAX(SupplierId)+1 FROM Suppliers";
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

        /// <summary>
        /// Updates existing supplier record
        /// </summary>
        /// <param name="oldS">data before update</param>
        /// <param name="newS">new data for the update</param>
        /// <returns>indicator of success</returns>
        public static bool UpdateSupplier(Supplier oldSup, Supplier newSup)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Suppliers " +
                                     "SET SupName = @NewSupName " +
                                     "WHERE SupplierId = @OldSupplierId " +
                                     "AND SupName = @OldSupName";
            SqlCommand cmd = new SqlCommand(updateStatement, connection);
            cmd.Parameters.AddWithValue("NewSupName", newSup.SupName);

            cmd.Parameters.AddWithValue("@OldSupplierId", newSup.SupplierId);
            cmd.Parameters.AddWithValue("OldSupName", oldSup.SupName);
            try
            {
                connection.Open();
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
                connection.Close();
            }
        }

        /// <summary>
        /// Delete a new supplier to the Suppliers table in TravelExperts database
        /// </summary>
        /// <param name="s"> supplier object that cotaing data for the new record</param>
        /// <returns>generated SupplierId</returns>
        public static bool DeleteSupplier(Supplier sup)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE FROM Suppliers " +
                                     "WHERE SupplierId = @SupplierId " + // to identify the supplier to be  deleted
                                     "AND SupName = @SupName";  // remaining conditions - to ensure optimistic concurrency
            SqlCommand cmd = new SqlCommand(deleteStatement, connection);
            cmd.Parameters.AddWithValue("@SupplierId", sup.SupplierId);
            cmd.Parameters.AddWithValue("@SupName", sup.SupName);
            try
            {
                connection.Open();
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
                connection.Close();
            }
        }
    }
}
