using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************************
 * Author : Sneha Patel(000783907)
 * Date : 19th July, 2018
 * Purpose: The application will also require simple add/edit 
 *          access for maintaining the suppliers data.
 ***************************************************************/
namespace TravelExpertsLibrary
{
    // Business(Entity) Class for Supplier - Middle layer
    public class Supplier
    {
        public Supplier() { }

        public int SupplierId { get; set; }

        public string SupName { get; set; }

    }
}
