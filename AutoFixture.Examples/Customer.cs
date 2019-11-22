using System;

namespace AutoFIxture.Examples
{
    public class Customer
    {
        public Customer(
            string firstName, string lastName, string middleName,
            string zipCode, int age, string address)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            MiddleName = middleName ?? throw new ArgumentNullException(nameof(middleName));
            Age = age;
            Address = address ?? throw new ArgumentNullException(nameof(address));
            ZipCode = zipCode ?? throw new ArgumentNullException(nameof(zipCode)); ;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {MiddleName} {LastName}"; } }
        public int Age { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
    }
}
