using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using U18OCT09X1.Models;

namespace U18OCT09X1.Controllers
{
    public class CarRentalController : Controller
    {
        //fejkad data (ska kolla upp)
        private List<Car> cars;
        private List<UserRecord> customers;

        public CarRentalController()
        {
            cars = new List<Car>();
            cars.Add(new Models.Car() { Registration = "abc123", Brand = "Volvo", Model = "Big boi" });
            cars.Add(new Models.Car() { Registration = "abc123", Brand = "Volvo", Model = "Big boi" });
            cars.Add(new Models.Car() { Registration = "abc123", Brand = "Volvo", Model = "Big boi" });
            cars.Add(new Models.Car() { Registration = "abc123", Brand = "Volvo", Model = "Big boi" });

            customers = new List<UserRecord>();
            customers.Add(new UserRecord() {FirstName="DERP"});
        }

        // GET: Rental
        public ActionResult CarsView()
        {
            return View(cars);
        }

        public ViewResult Details(string Regestration)
        {
            return View("CarDetails", cars.First(x => x.Registration == Regestration));
        }
     
        public PartialViewResult Cars()
        {
            return PartialView("_Cars", cars);

        }
        public PartialViewResult Customers()
        {

            return PartialView("_Customers", customers);
        }

    }
}