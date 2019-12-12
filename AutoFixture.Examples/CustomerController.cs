namespace AutoFIxture.Examples
{
    public class CustomerController
    {
        public ICustomerRepository Repository { get; }

        public CustomerController(
            ICustomerRepository repository)
        {
            Repository = repository;
        }

        public void CreateCustomer(CustomerDto dto)
        {
            if (dto.Photo != null)
                Repository.Create(dto.ToCustomer());
        }
    }
}
