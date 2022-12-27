using Bogus;

namespace SingleOrDefault;

public class CustomerService
{
    private readonly List<Customer> _customers = new();

    public CustomerService()
    {
        Randomizer.Seed = new Random(69);
        var customerFaker = new Faker<Customer>()
            .RuleFor(x => x.Id, faker => faker.IndexFaker)
            .RuleFor(x => x.FullName, faker => faker.Person.FullName)
            .RuleFor(x => x.Email, faker => faker.Person.Email)
            .RuleFor(x => x.DateOfBirth, faker => faker.Person.DateOfBirth);

        _customers = customerFaker.Generate(10000);

    }
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