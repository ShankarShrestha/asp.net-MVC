using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product/ViewProduct
        public ActionResult ViewProduct()
        {
            Product p1 = new Product();
            Product p2 = new Product();
            Product p3 = new Product();
            Product p4 = new Product();
            Product p5 = new Product();


            p1.ProductId = 123;
            p1.ProductName = "Mobile";
            p1.SupplierId = 246;
            p1.CategoryId = 123;
            p1.QuantityPerUnit = "100";
            p1.UnitPrice = 400m;
            p1.UnitsInStock = 4;
            p1.UnitsOnOrder = 30;
            p1.ReorderLevel = 2;
            p1.Discontinued = true;
            p1.Active = true;

            p2.ProductId = 124;
            p2.ProductName = "Book";
            p2.SupplierId = 246;
            p2.CategoryId = 133;
            p2.QuantityPerUnit = "100";
            p2.UnitPrice = 400m;
            p2.UnitsInStock = 4;
            p2.UnitsOnOrder = 30;
            p2.ReorderLevel = 2;
            p2.Discontinued = true;
            p2.Active = true;

            p3.ProductId = 133;
            p3.ProductName = "Pencil";
            p3.SupplierId = 246;
            p3.CategoryId = 123;
            p3.QuantityPerUnit = "100";
            p3.UnitPrice = 400m;
            p3.UnitsInStock = 4;
            p3.UnitsOnOrder = 30;
            p3.ReorderLevel = 2;
            p3.Discontinued = true;
            p3.Active = true;

            p4.ProductId = 123;
            p4.ProductName = "Computer";
            p4.SupplierId = 246;
            p4.CategoryId = 123;
            p4.QuantityPerUnit = "100";
            p4.UnitPrice = 400m;
            p4.UnitsInStock = 4;
            p4.UnitsOnOrder = 30;
            p4.ReorderLevel = 2;
            p4.Discontinued = true;
            p4.Active = true;

            p5.ProductId = 123;
            p5.ProductName = "Desktop";
            p5.SupplierId = 246;
            p5.CategoryId = 123;
            p5.QuantityPerUnit = "100";
            p5.UnitPrice = 400m;
            p5.UnitsInStock = 4;
            p5.UnitsOnOrder = 30;
            p5.ReorderLevel = 2;
            p5.Discontinued = true;
            p5.Active = true;

         
            List<Product> ListOfProducts = new List<Product>();
            ListOfProducts.Add(p1);
            ListOfProducts.Add(p2);
            ListOfProducts.Add(p3);
            ListOfProducts.Add(p4);
            ListOfProducts.Add(p5);

            ViewBag.display = ListOfProducts;






            return View("DisplayProduct");
        }
    }
}