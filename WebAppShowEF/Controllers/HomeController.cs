using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppShowEF.Models;

namespace WebAppShowEF.Controllers
{
    public class HomeController : Controller
    {

        MyDb db = new MyDb();

        // GET: Home
        public ActionResult Index()
        {
            //db.Cars.Add(new Car { Brand = "Volvo", Model = "740", Year = 1988 });
            //db.SaveChanges();

            return View(db.Cars.Include("FameDrivers").ToList());
        }
        [HttpPost]
        public ActionResult Index(string sort)
        {
            if (string.IsNullOrWhiteSpace(sort))
            {
                return View(db.Cars.Include("FameDrivers").ToList());
            }
            List<Car> cars = db.Cars.Include("FameDrivers").Where
                (c => c.Model.ToLower().Contains(sort.ToLower()) ).ToList();

            return View(cars);
        }
    }
}