using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities;
public sealed class Category : Entity
{
    public string? Name { get; private set; }
    public ICollection<Product>? Products { get; set; }

    public Category(string? name)
    {      
        ValidationDomain(name);   
    }

    public Category(int id, string? name)
    {
        DomainExceptionValidation.When(id < 0, "Invalid Id value");
        Id = id;
        ValidationDomain(name);
    }

    private void ValidationDomain(string? name)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required");

        DomainExceptionValidation.When(name!.Length < 3, "Invalid name. Too short, minimum 3 characters");

        DomainExceptionValidation.When(name!.Length > 100, "Invalid name. Too long, maximum 100 characters");

        this.Name = name;
    }

    public void Update(string name)
    {
        ValidationDomain(name);
    }
}
