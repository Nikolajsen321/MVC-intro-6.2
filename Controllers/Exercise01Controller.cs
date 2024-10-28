    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Microsoft.AspNetCore.Mvc;

    namespace Lesson02_Startup.Controllers
    {
        public class Exercise01Controller : Controller
        {
        

            public ActionResult Index()
            {
                // create a new product object with instance name glass
                Product glass = new Product("Wine glass", 160.50,"Alkoholikeren ");
                Product knife = new Product("Knife", 20000.00,"KnifeParty");
                Product bin = new Product("Bin", 500.00,"SkraldeManden");


                glass.ImageUrl = "grandcru.jpg";
                knife.ImageUrl = "st_knife.jpg";
                bin.ImageUrl = "bin_35l.jpg";



                ViewBag.Glass = glass;
                ViewBag.Knife = knife;
                ViewBag.Bin = bin;
			
                return View();
            }

        }
    }
