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
        public static int AddSupplier(Supplier supplier)
        {
            int supplierId;
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Suppliers (SupplierId, SupName) " +
                                     "VALUES(@SupplierId, @SupName)";
            SqlCommand cmd = new SqlCommand(insertStatement, connection);
            cmd.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
            cmd.Parameters.AddWithValue("@SupName", supplier.SupName);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery(); // run the insert command

                // get the generated ID - current identity value for  Suppliers table
                //string selectQuery = "SELECT IDENT_CURRENT('Suppliers')";
                string selectQuery = "SELECT MAX(SupplierId)+1 FROM Suppliers";
                SqlCommand selectCmd = new SqlCommand(selectQuery, connection);
                object result = selectCmd.ExecuteScalar();
                Console.WriteLine("Result: " + result.ToString());
                supplierId = Convert.ToInt32(result); // single value             
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return supplierId;
        }

        /// <summary>
        /// Updates existing supplier record
        /// </summary>
        /// <param name="oldS">data before update</param>
        /// <param name="newS">new data for the update</param>
        /// <returns>indicator of success</returns>
        public static bool UpdateSupplier(Supplier oldS, Supplier newS)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Suppliers " +
                                     "SET SupName = @NewSupName " +
                                     "WHERE SupplierId = @SupplierId " +
                                     "AND SupName = @OldSupName";
            SqlCommand cmd = new SqlCommand(updateStatement, connection);
            cmd.Parameters.AddWithValue("NewSupName", newS.SupName);
            cmd.Parameters.AddWithValue("OldSupName", oldS.SupName);
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
        public static bool DeleteSupplier(Supplier s)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE FROM Suppliers " +
                                     "WHERE SupplierId = @SupplierId " + // to identify the supplier to be  deleted
                                     "AND SupName = @SupName" +
                                     "ORDER BY SupplireId";  // remaining conditions - to ensure optimistic concurrency
            SqlCommand cmd = new SqlCommand(deleteStatement, connection);
            cmd.Parameters.AddWithValue("@SupplierId", s.SupplierId);
            cmd.Parameters.AddWithValue("@SupName", s.SupName);
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
