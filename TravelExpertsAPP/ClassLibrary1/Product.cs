using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Robert Clements
 * Date: July 24, 2018
 */ 
namespace TravelExpertsLibrary
{
    /// <summary>
    /// class to create product object after accessing database
    /// </summary>
    public class Product
    {
        public Product() { }
        public int ProductID { get; set; }
        public string ProdName { get; set; }
        //making copy of product to hold when updating database in case user cancels
        public Product CopyProduct()
        {
            Product copy = new Product();
            copy.ProductID = this.ProductID;
            copy.ProdName = this.ProdName;
            return copy;
        }
    }
}
