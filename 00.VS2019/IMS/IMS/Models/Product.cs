using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UPC { get; set; }
        public int SafetyStockLevel { get; set; }
        public int ReorderPoint { get; set; }
        public float StandardPrice { get; set; }
        public float ListPrice { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}