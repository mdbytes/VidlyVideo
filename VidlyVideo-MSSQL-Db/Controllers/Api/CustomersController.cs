﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        // Get /api/customers
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        // Get /api/customers/1
        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customer==null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return customer; ;
        }

        // POST /api/customers
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Customers.Add(customer);

            _context.SaveChanges();

            return customer;

        }

        [HttpPut]
        public void UpdateCustomer(int id,Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb =_context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


            customerInDb.Name = customer.Name;
            customerInDb.Birthday = customer.Birthday;
            customerInDb.MembershipTypeId = customer.MembershipTypeId;
            customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;

            _context.SaveChanges();

        }

        // DELETE /api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDb);

            _context.SaveChanges();
        }

    }
}
