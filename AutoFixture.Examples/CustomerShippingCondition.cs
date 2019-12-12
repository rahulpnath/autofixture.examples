using System.Linq;

namespace AutoFIxture.Examples
{
    public class CustomerShippingCondition
    {
        public bool Check(Customer customer)
        {
            return customer.Addresses.Any() &&
                customer.Age > 21;
        }
    }
}
