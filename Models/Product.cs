using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Product
    {
        private long productId = 0;
        private string productName = "n/a";
        private long supplierId = 0;
        private long categoryId = 0;
        private string quantityPerUnit = "n/a";
        private decimal unitPrice = 1000000m;
        private long unitsInStock = 0;
        private int unitsOnOrder = 0;
        private int reorderLevel = -1;
        private bool discontinued = false;
        private bool active = false;



        public long ProductId
        {
            get
            {
                return this.productId;
            }

            set
            {
                if(value > 0)
                {
                    this.productId = value;
                }                
            }
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                if(value.Length >= 1 && value.Length <= 40)
                {
                    this.productName = value;
                }                
            }
        }
        public long SupplierId
        {
            get
            {
                return this.supplierId;
            }

            set
            {
                if (value > 0)
                {
                    this.supplierId = value;
                }
            }
        }
        public long CategoryId
        {
            get
            {
                return this.categoryId;
            }

            set
            {
                if (value > 0)
                {
                    this.categoryId = value;
                }
            }
        }
        public string QuantityPerUnit
        {
            get
            {
                return this.quantityPerUnit;
            }

            set
            {
                if (value.Length >= 1 && value.Length <= 20)
                {
                    this.quantityPerUnit = value;
                }
            }
        }
        public decimal UnitPrice
        {
            get
            {
                return this.unitPrice;
            }

            set
            {
                if (value > 0)
                {
                    this.unitPrice = value;
                }
            }
        }
        public long UnitsInStock
        {
            get
            {
                return this.unitsInStock;
            }

            set
            {
                if (value > 0)
                {
                    this.unitsInStock = value;
                }
            }
        }
        public int UnitsOnOrder
        {
            get
            {
                return this.unitsOnOrder;
            }

            set
            {
                if (value > 0)
                {
                    this.unitsOnOrder = value;
                }
            }
        }
        public int ReorderLevel
        {
            get
            {
                return this.reorderLevel;
            }

            set
            {
                if (value > 0)
                {
                    this.reorderLevel = value;
                }
            }
        }
        public bool Discontinued
        {
            get
            {
                return this.discontinued;
            }

            set
            {
                this.discontinued = value;
            }
        }
        public bool Active
        {
            get
            {
                return this.active;
            }

            set
            {
                this.active = value;
            }
        }


        public override string ToString()
        {
            string output = "";

            output += "Product Id: " + this.ProductId + "<br />";
            output += "Product Name: " + this.ProductName + "<br />";
            output += "Supplier Id: " + this.SupplierId + "<br />";
            output += "Category Id: " + this.CategoryId + "<br />";
            output += "Quantity per Unit: " + this.QuantityPerUnit + "<br />";
            output += "Unit Price: " + this.UnitPrice + "<br />";
            output += "Units in Stock: " + this.UnitsInStock + "<br />";
            output += "Units on Order: " + this.UnitsOnOrder + "<br />";
            output += "Reorderred Level: " + this.ReorderLevel + "<br />";
            output += "Discontinued: " + this.Discontinued + "<br />";
            output += "Active: " + this.Active + "<br />";

            return output;
        }


    }
}