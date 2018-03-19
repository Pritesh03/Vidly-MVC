﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

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
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult CustomersList()
        {
            var Customers = _context.Customers.ToList();

            return View(Customers);
        }

        public ActionResult Details(int? id)
        {
            var Customers = _context.Customers;
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
    }
}