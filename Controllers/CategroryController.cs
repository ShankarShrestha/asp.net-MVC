using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category/ViewCategory
        public ActionResult ViewCategory()
        {
            Category cg1 = new Category();
            Category cg2 = new Category();
            Category cg3 = new Category();
            Category cg4 = new Category();
            Category cg5 = new Category();

            cg1.CategoryId = 123;
            cg1.CategoryName = "Phone";
            cg1.Description = "List of all phone";

            cg2.CategoryId = 133;
            cg2.CategoryName = "Laptop";
            cg2.Description = "List of All Laptops";
            cg2.Active = true;

            cg3.CategoryId = 143;
            cg3.CategoryName = "Phone Case";
            cg3.Description = "List of All Phone case";
            cg3.Active = true;

            cg4.CategoryId = 153;
            cg4.CategoryName = "Monitor";
            cg4.Description = "List of All Monitor";
            cg4.Active = true;

            cg5.CategoryId = 155;
            cg5.CategoryName = "Key Board";
            cg5.Description = "List of All KeyBoard";
            cg5.Active = true;


            List<Category> ListOfCategory = new List<Category>();
            ListOfCategory.Add(cg1);
            ListOfCategory.Add(cg2);
            ListOfCategory.Add(cg3);
            ListOfCategory.Add(cg4);
            ListOfCategory.Add(cg5);


            ViewBag.myCategory = ListOfCategory;



            return View("DisplayCategory");
        }
    }
}