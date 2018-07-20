using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsLibrary
{
    public static class ProductDB
    {
        /// <summary>
        /// Gets list of all products from the database
        /// </summary>
        /// <returns>list of product objects </returns>
        public static List<Product> GetAllProduct()
        {
            //list to hold all of product objects
            List<Product> products = new List<Product>();
            Product prod = null;
            //create connection
            SqlConnection con = TravelExpertsDB.GetConnection();
            //SQL string to make selection
            string selectStatement = "Select ProductID, ProdName " +
                "FROM Products";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            try
            {
                //open connection
                con.Open();
                // create SQL reader 
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read()) // if values are found
                {
                    prod = new Product();
                    prod.ProductID = (int)reader["ProductID"];
                    prod.ProdName = reader["ProdName"].ToString();
                    products.Add(prod);
                }
                else
                {
                    return null; //
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
            //return list of products
            return products;
        }
    }

}
