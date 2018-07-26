using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Robert Clements
 * Date: July 22, 2018
 */
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
                while(reader.Read()) // keep reading while values in table
                {
                    prod = new Product();
                    prod.ProductID = (int)reader["ProductID"];
                    prod.ProdName = reader["ProdName"].ToString();
                    products.Add(prod);
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

        public static int AddProduct(Product product)
        {
            int productID; //hold productID value (might not need this)
            SqlConnection con = TravelExpertsDB.GetConnection(); //connect to database
            //SQL string to insert new product, dont need ProductID as it is Auto increment
            string insertStatement = "INSERT INTO Products (ProdName) " +
                "VALUES (@ProdName)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@ProdName", product.ProdName); //add value to parameter in sql string
            try
            {
                con.Open();
                cmd.ExecuteNonQuery(); //execute the insert sql string
                string selectQuery = "SELECT IDENT_CURRENT ('Products')"; //might not need this code below as i might not need to return Prodcut ID
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                productID = Convert.ToInt32(selectCmd.ExecuteScalar());
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return productID;
        }

        public static bool DeleteProduct(Product product)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE FROM Products " +
                                     "WHERE ProductID = @ProductID " +
                                     "AND ProdName = @ProdName";
            SqlCommand cmd = new SqlCommand(deleteStatement, con);
            cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
            cmd.Parameters.AddWithValue("@ProdName", product.ProdName);
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
        public static bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Products " +
                                     "SET ProdName = @NewProdName " +
                                     "WHERE ProductID = @OldProductID " +
                                     "AND ProdName = @OldProdName";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@NewProdName", newProduct.ProdName);
            //start adding vlaues of old product
            cmd.Parameters.AddWithValue("@OldProductID", oldProduct.ProductID);
            cmd.Parameters.AddWithValue("@OldProdName", oldProduct.ProdName);
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
    }

}
