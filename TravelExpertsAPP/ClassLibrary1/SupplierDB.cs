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
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>(); //empty list

            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT SupplierId, SupName FROM Suppliers ORDER BY SupplierId";
            SqlCommand cmd = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Supplier s;
                while(reader.Read()) // while there is another record
                {
                    s = new Supplier();
                    s.SupplierId = (int)reader["SupplierId"];
                    s.SupName = reader["SupName"].ToString();
                    suppliers.Add(s);
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return suppliers;
        }
    }
}
