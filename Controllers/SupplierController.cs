using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class SupplierController : Controller
    {
        // GET: Supplier
        public ActionResult ViewSupplier()
        {
            Supplier sp1 = new Supplier();
            Supplier sp2 = new Supplier();
            Supplier sp3 = new Supplier();
            Supplier sp4 = new Supplier();
            Supplier sp5 = new Supplier();

            sp1.SupplierId = 12;
            sp1.CompanyName = "Sam Trader";
            sp1.ContactName = "Sam Johnson";
            sp1.ContactTitle = "CEO";
            sp1.Address = "245 Road cr";
            sp1.City = "Minneapolis";
            sp1.Region = "Minnesota";
            sp1.PostalCode = "52002";
            sp1.Country = "USA";
            sp1.Phone = "5202522525";
            sp1.Fax = "452125789";
            sp1.HomePage = "www.samtrade.com";
            sp1.Discontinued = true;

            sp2.SupplierId = 15;
            sp2.CompanyName = "Jack Trader";
            sp2.ContactName = "Jack Johnson";
            sp2.ContactTitle = "Manager";
            sp2.Address = "245 road Road";
            sp2.City = "Chicago";
            sp2.Region = "Ilinoes";
            sp2.PostalCode = "63635";
            sp2.Country = "USA";
            sp2.Phone = "5202252525";
            sp2.Fax = "452125589";
            sp2.HomePage = "www.jackJohn.com";
            sp2.Discontinued = true;

            sp3.SupplierId = 16;
            sp3.CompanyName = "Shrestha supplyer";
            sp3.ContactName = "Shankar Shrestha";
            sp3.ContactTitle = "CEO";
            sp3.Address = "245 Briargate road";
            sp3.City = "Minneapolis";
            sp3.Region = "Minnesota";
            sp3.PostalCode = "52102";
            sp3.Country = "USA";
            sp3.Phone = "5202525825";
            sp3.Fax = "4521250009";
            sp3.HomePage = "www.shankar.com";
            sp3.Discontinued = true;

            sp4.SupplierId = 19;
            sp4.CompanyName = "John Doe Supplyer";
            sp4.ContactName = "John Doe";
            sp4.ContactTitle = "CEO";
            sp4.Address = "585 deadend road";
            sp4.City = "Minneapolis";
            sp4.Region = "Minnesota";
            sp4.PostalCode = "52882";
            sp4.Country = "USA";
            sp4.Phone = "5202522525";
            sp4.Fax = "452125789";
            sp4.HomePage = "www.johndoe.com";
            sp4.Discontinued = true;

            sp5.SupplierId = 25;
            sp5.CompanyName = "Max Supplyes";
            sp5.ContactName = "Max Mark";
            sp5.ContactTitle = "CEO";
            sp5.Address = "245 Road cr";
            sp5.City = "Minneapolis";
            sp5.Region = "Minnesota";
            sp5.PostalCode = "52002";
            sp5.Country = "USA";
            sp5.Phone = "5202522525";
            sp5.Fax = "452125789";
            sp5.HomePage = "www.maxsupplyer.com";

            List<Supplier> ListOfSuppliers = new List<Supplier>();

            ListOfSuppliers.Add(sp1);
            ListOfSuppliers.Add(sp2);
            ListOfSuppliers.Add(sp3);
            ListOfSuppliers.Add(sp4);
            ListOfSuppliers.Add(sp5);

            ViewBag.SupplyerDisplay = ListOfSuppliers;


            return View("DisplaySupplier");
        }
    }
}