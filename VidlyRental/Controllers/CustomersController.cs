using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRental.Models;

namespace VidlyRental.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer(){ Id= 1, Name="Harry"},
                new Customer(){ Id= 2, Name="Dumbledore" },
                new Customer(){ Id= 3, Name="Voldemort" },
                new Customer(){ Id= 4, Name="Snape" },
                new Customer(){ Id= 5, Name="Sirius" },
                new Customer(){ Id= 6, Name="Hermione" },
                new Customer(){ Id= 7, Name="Ron" },
                new Customer(){ Id= 8, Name="Draco" },
                new Customer(){ Id= 9, Name="Hagrid" },
                new Customer(){ Id= 10, Name="Neville" },
                new Customer(){ Id= 11, Name="Dobby" },
                new Customer(){ Id= 12, Name="Moody" },
                new Customer(){ Id= 13, Name="Lupin" },
                new Customer(){ Id= 14, Name="Bellatrix" },
                new Customer(){ Id= 15, Name="McGonagall" },
                new Customer(){ Id= 16, Name="Newt Scamander" },
                new Customer(){ Id= 17, Name="Grindelwald" },
                new Customer(){ Id= 18, Name="Tina" },
                new Customer(){ Id= 19, Name="Queenie" },
                new Customer(){ Id= 20, Name="Jacob" }
            };

        }
    }
}