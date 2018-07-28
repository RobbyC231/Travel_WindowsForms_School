using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsLibrary
{
    public class Product_SupplierDB
    {
        /// <summary>
        /// function to get data from Product_Supplier table
        /// </summary>
        /// <param name="ProdcutSupplierID"></param>
        /// <returns></returns>
        public static List<Product_Supplier> GetProduct_Supplier()
        {
            List<Product_Supplier> productSuppliers = new List<Product_Supplier>();
            Product_Supplier ps;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT ProductSupplierID, ProductID, SupplierID FROM Products_Suppliers";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ps = new Product_Supplier();
                    ps.ProductSupplierID = (int)reader["ProductSupplierID"];
                    ps.ProductID = (int)reader["ProductID"];
                    ps.SupplierID = (int)reader["SupplierID"];
                    productSuppliers.Add(ps);
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
            return productSuppliers;
        }

        /// <summary>
        /// function update the productsupplier table
        /// </summary>
        /// <param name="oldProduct_Supplier"></param>
        /// <param name="newProduct_Supplier"></param>
        /// <returns></returns>
        public static bool UpdateProduct_Supplier(Product_Supplier oldProduct_Supplier, Product_Supplier newProduct_Supplier)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Products_Suppliers " +
                                "SET ProductID = @newProductID, " +
                                "SupplierID = @newSupplierID " +
                                "WHERE ProductSupplierID = @oldProductSupplierID " +
                                "AND ProductID = @oldProductID " +
                                "AND SupplierID = @oldSupplierID ";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@newProductID", newProduct_Supplier.ProductID);
            cmd.Parameters.AddWithValue("@newSupplierID", newProduct_Supplier.SupplierID);

            cmd.Parameters.AddWithValue("@oldProductSupplierID", oldProduct_Supplier.ProductSupplierID);
            cmd.Parameters.AddWithValue("@oldProductID", oldProduct_Supplier.ProductID);
            cmd.Parameters.AddWithValue("@oldSupplierID", oldProduct_Supplier.SupplierID);

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

        /// <summary>
        /// function is used to delete the data from Product_supplier table
        /// </summary>
        /// <param name="PS"></param>
        /// <returns></returns>
        public static bool DeleteProduct_Supplier(Product_Supplier productSupplier)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE FROM Products_Suppliers WHERE ProductSupplierID = @ProductSupplierID " +
                                        "AND ProductID=@ProductID " +
                                        "AND SupplierID=@SupplierID";
            SqlCommand cmd = new SqlCommand(deleteStatement, con);
            cmd.Parameters.AddWithValue("@ProductSupplierID", productSupplier.ProductSupplierID);
            cmd.Parameters.AddWithValue("@ProductID", productSupplier.ProductID);
            cmd.Parameters.AddWithValue("@SupplierID", productSupplier.SupplierID);
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

        /// <summary>
        /// function is used to add data to Product_Supplier table
        /// </summary>
        /// <param name="PS"></param>
        /// <returns></returns>
        public static int AddProduct_Supplier(Product_Supplier productSupplier)
        {
            int productSupplierID;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Products_Suppliers (ProductID, SupplierID) " +
                                        "VALUES (@ProductID, @SupplierID)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@ProductID", productSupplier.ProductID);
            cmd.Parameters.AddWithValue("@SupplierID", productSupplier.SupplierID);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                string selectQuery = "SELECT IDENT_CURRENT ('Products_Suppliers')";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                productSupplierID = Convert.ToInt32(selectCmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return productSupplierID;
        }
    }
}
