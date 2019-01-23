
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Category
    {
        private long categoryId = 0;
        private string categoryName = "n/a";
        private string description = "n/a";
        private bool active = false;

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

        public string CategoryName
        {
            get
            {
                return this.categoryName;
            }
            set
            {
                if (value.Length >= 1 && value.Length <= 15)
                {
                    this.categoryName = value;
                }

            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
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

            output += "Category Id: " + this.CategoryId + "<br />";
            output += "Category Name: " + this.categoryName + "<br />";
            output += "Description: " + this.Description + "<br />";
            output += "Active: " + this.Active + "<br />";

            return output;
        }

    }


}