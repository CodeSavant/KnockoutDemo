using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace CustomerSite.Controllers
{
    public class CustomerController : Controller
    {
        // Insert a new Customer into the database.
        public ActionResult Index()
        {
            return View();
        }


        // Show the contents of the database.
        public ActionResult Show()
        {
            CustomerInfoAPIController Data = new CustomerInfoAPIController();

            return View(Data.GetCustomers());
        }


        // homepage of the customer application.
        public ActionResult Home()
        {
            return View();
        }


        // after a customer was put in the database you get redirected to this view.
        public ActionResult Done()
        { 
            return View();
        }


        
        
    }
        
}
