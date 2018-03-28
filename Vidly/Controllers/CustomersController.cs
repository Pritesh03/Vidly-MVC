﻿using System;
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

            var newCustomerViewModel = new NewCustomerViewModel() {
                MembershipType = membershipTypes                
            };

            return View(newCustomerViewModel);
        }
    }
}