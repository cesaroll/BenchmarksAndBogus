namespace SingleOrDefault;

public class CustomerService
{
    private readonly List<Customer> _customers = new();

    public Customer? GetById_SingleOrDefault(int id)
    {
        return _customers.SingleOrDefault(x => x.Id == id);
    }
    
    public Customer? GetById_FirstOrDefault(int id)
    {
        return _customers.FirstOrDefault(x => x.Id == id);
    }
    
    public Customer? GetByEmail_SingleOrDefault(string email)
    {
        return _customers.SingleOrDefault(x => x.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
    }
    
    public Customer? GetByEmail_FirstOrDefault(string email)
    {
        return _customers.FirstOrDefault(x => x.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
    }
}