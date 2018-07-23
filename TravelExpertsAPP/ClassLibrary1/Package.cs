using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Brian Liang
 * Date: July/Aug 2018
 */

namespace TravelExpertsLibrary

{
    public class Package
    {
        public Package() { }                        //Package constructor
        public int PackageId { get; set; }          //getter/setter for PackageID
        public string PkgName { get; set; }         //getter/setter for PkgName
        public DateTime PkgStartDate { get; set; }  //getter/setter for PkgStartDate
        public DateTime PkgEndDate { get; set; }    //getter/setter for PkgEndDate
        public string PkgDesc { get; set; }         //getter/setter for PkgDesc
        public decimal PkgBasePrice { get; set; }   //getter/setter for PkgBasePrice
        public decimal PkgAgencyCommission { get; set; }    //getter/setter for PkgAgencyCommission
    }
}
