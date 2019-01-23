// Created By: Shankar Shrestha
// Create Date: 1/19/2019
// Description: This is Supplier Model with public property

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Supplier
    {
        private long    supplierId = 0;
        private string  companyName = "n/a";
        private string  contactName = "n/a";
        private string  contactTitle = "n/a";
        private string  address = "n/a";
        private string  city = "n/a";
        private string  region = "n/a";
        private string  postalCode = "n/a";
        private string  country = "n/a";
        private string  phone = "n/a";
        private string  fax = "n/a";
        private string  homePage = "n/a";
        private bool    discontinued = false;



        public long SupplierId
        {
            get
            {
                return this.supplierId;
            }
            set
            {
                if(value > 0) {
                    this.supplierId = value;
                }                
            }
        }
        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                if(value.Length >= 1 && value.Length <= 40) {
                    this.companyName = value;
                }
                
            }
        }
        public string ContactName
        {
            get
            {
                return this.contactName;
            }
            set
            {
                if (value.Length >= 1 && value.Length <= 30) {
                    this.contactName = value;
                }
            }
        }
        public string ContactTitle
        {
            get
            {
                return this.contactTitle;
            }
            set
            {
                if (value.Length >= 1 && value.Length <= 30)
                {
                    this.contactTitle = value;
                }
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (value.Length >= 1 && value.Length <= 60)
                {
                    this.address = value;
                }
            }
        }
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                if (value.Length >= 1 && value.Length <= 15)
                {
                    this.city = value;
                }
            }
        }
        public string Region
        {
            get
            {
                return this.region;
            }
            set
            {
                if (value.Length >= 1 && value.Length <= 15)
                {
                    this.region = value;
                }
            }
        }
        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }
            set
            {
                if (value.Length >= 1 && value.Length <= 10)
                {
                    this.postalCode = value;
                }
            }
        }
        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                if (value.Length >= 1 && value.Length <= 15)
                {
                    this.country = value;
                }
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                if (value.Length >= 1 && value.Length <= 24)
                {
                    this.phone = value;
                }
            }
        }
        public string Fax
        {
            get
            {
                return this.fax;
            }
            set
            {
                if (value.Length >= 1 && value.Length <= 24)
                {
                    this.fax = value;
                }
            }
        }
        public string HomePage
        {
            get
            {
                return this.homePage;
            }
            set
            {
                this.homePage = value;
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

        public override string ToString()
        {
            string output = "";

            output += "Supplier Id: " + this.SupplierId + "<br />";
            output += "company Name: " + this.CompanyName + "<br />";
            output += "Contact Name: " + this.ContactName + "<br />";
            output += "Contact Title: " + this.ContactTitle + "<br />";
            output += "Address: " + this.Address + "<br />";
            output += "City: " + this.City + "<br />";
            output += "Region: " + this.Region + "<br />";
            output += "Postal Code: " + this.PostalCode + "<br />";
            output += "Country: " + this.Country + "<br />";
            output += "Phone: " + this.Phone + "<br />";
            output += "Fax: " + this.Fax + "<br />";
            output += "Home Page: " + this.HomePage + "<br />";
            output += "Discountinued: " + this.Discontinued + "<br />";



            return output;

        }

        public string FullAddress
        {
            get
            {
                string fullAddress = this.ContactTitle + " " + this.ContactName + " " + this.CompanyName + " " + this.Address + " " + this.City + " " + this.Region + " " + this.PostalCode + " " + this.Country;
                return fullAddress;
            }
            
        }


    }
}