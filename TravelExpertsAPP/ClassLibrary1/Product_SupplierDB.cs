using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsLibrary
{
    class Product_SupplierDB
    {
        /// <summary>
        /// function to get data from Product_Supplier table
        /// </summary>
        /// <param name="ProdcutSupplierID"></param>
        /// <returns></returns>
        public static Product_Supplier GetProduct_Supplier(int ProdcutSupplierID)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "select * from Product_Suppliers " +
                                        "where ProductSupplierID = @ProductSupplierID";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@ProductSupplierID", ProdcutSupplierID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    Product_Supplier ps = new Product_Supplier();
                    ps.ProductSupplierID = (int)reader["ProductSupplierID"];
                    ps.ProductID = (int)reader["ProductID"];
                    ps.SupplierID = (int)reader["SupplierID"];

                    return ps;
                }
                else
                {
                    return null;
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
        /// function update the productsupplier table
        /// </summary>
        /// <param name="oldProduct_Supplier"></param>
        /// <param name="newProduct_Supplier"></param>
        /// <returns></returns>
        public static bool updateProduct_Supplier(Product_Supplier oldProduct_Supplier, Product_Supplier newProduct_Supplier)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "update Product_Suppliers " +
                                "set ProductID = @newProductID " +
                                "SupplierID = @newSupplierID " +
                                "where ProductSupplierID = @oldProductSupplierID " +
                                "and ProductID = @oldProductID " +
                                "and SupplierID = @oldSupplierID ";
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
        public static bool deleteProduct_Supplier(Product_Supplier PS)
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

        /// <summary>
        /// function is used to add data to Product_Supplier table
        /// </summary>
        /// <param name="PS"></param>
        /// <returns></returns>
        public static int AddProduct_Supplier(Product_Supplier PS)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "insert into Product_Suppliers (ProductSuppleirID, ProductID, SupplierID) " +
                                        "values(@ProductSupplierID, @ProductID, @SupplierID)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@ProductSupplierID", PS.ProductSupplierID);
            cmd.Parameters.AddWithValue("@ProductID", PS.ProductID);
            cmd.Parameters.AddWithValue("@SupplierID", PS.SupplierID);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                String selectQuery = "select ident_current('Product_Suppliers') from Product_Suppliers";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                int ProductSupplierID = Convert.ToInt32(selectCmd.ExecuteScalar());
                return ProductSupplierID;
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
