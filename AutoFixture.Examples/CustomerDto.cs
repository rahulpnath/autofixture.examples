using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace AutoFIxture.Examples
{
    public class CustomerDto
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public IFormFile Photo { get; set; }

        internal Customer ToCustomer()
        {
            return new Customer(
                FirstName,
                LastName,
                MiddleName,
                Age,
                new List<Address>());
        }
    }
}
