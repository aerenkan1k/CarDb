using System.Collections.Generic;

namespace CarDb.Entities
{
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(int customerId, string firstName, string lastName)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<CarCustomer> CarCustomers { get; set; }

        public override string ToString()
        {
            return $"Customer Id={CustomerId,-5}  First Name={FirstName,-10}  Last Name={LastName,-10}";
        }

    }
}
