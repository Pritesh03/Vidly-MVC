using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var Customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(Customers);
        }

        public ActionResult Details(int? id)
        {
            var Customers = _context.Customers.Include(c => c.MembershipType);
            Customer customer = Customers.FirstOrDefault(c => c.Id == id);

            if (customer != null)
                return View(customer);

            else
                return HttpNotFound("Customer not found...");
        }

        private IEnumerable<Customer> GetCustomers()
        {
            List<Customer> lstCustomers = new List<Customer>() {
            new Customer(){ Id = 1, Name = "Chandler Bing" },
            new Customer(){ Id = 2, Name = "Ross Gellar" },
            new Customer(){ Id = 3, Name = "Joey Tribbiani" }
            };

            return lstCustomers;
        }

        //Create a new Customer
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new CustomerFormViewModel()
            {
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        //Create a new Customer
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            //id == 0  means a new customer. we directly add it to the context.
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.DateOfBirth = customer.DateOfBirth;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }
            _context.SaveChanges();

            return RedirectToAction("index", "customers");

        }

        //Edit an existing customer
        public ActionResult Edit(int Id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customer == null)
                return HttpNotFound("Customer Not Found!");
            else
            {

                var viewModel = new CustomerFormViewModel()
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };

                return View("CustomerForm", viewModel);
            }
        }
    }
}