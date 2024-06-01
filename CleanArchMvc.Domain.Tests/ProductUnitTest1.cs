using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Validation;
using FluentAssertions;

namespace CleanArchMvc.Domain.Tests;
public class ProductUnitTest1
{
    [Fact(DisplayName = "Create Product With Valid State")]
    public void CreateProduct_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Product(1, "Product Name","Description Name", 100.00m, 10, "product image");
        action.Should().NotThrow<DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create Product With Invalid Id Value")]
    public void CreateProduct_WithInvalidIdValue_ResultObjectInvalidState()
    {
        Action action = () => new Product(-1, "Product Name", "Description Name", 100.00m, 10, "product image");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid Id value");
    }

    [Fact(DisplayName = "Create Product With Short Name Value")]
    public void CreateProduct_WithShortNameValue_ResultObjectInvalidState()
    {
        Action action = () => new Product(1, "Pr", "Description Name", 100.00m, 10, "product image");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Too short, minimum 3 characters");
    }

    [Fact(DisplayName = "Create Product With Long Name Value")]
    public void CreateProduct_WithLongNameValue_ResultObjectInvalidState()
    {
        Action action = () => new Product(1, "svdsahfvsahjfvhjsafhjsahjfvsahjvfhjsavfhsavfhsahvsahjfvajhsvfhjasvhfashfjvsahjfvhsajfvhjsavfhjasvfhahfvsahfvashfvhsafvhasvfhsavfhsavhsavhsahfvashvfhsavfhasvfhasvhasvfhasvashfvasfvhasvhasvfhasvfhasvfhasvhvashvashvhasjsvfhassvfhjassvfhasvfhjasvfhjvewbfjbwejkfbjwebfbewfbjwebfjkbwejkfbewjkbfjwebfjbwejbewjfbjwebfjewbjfbwejfbjwebfjwebfjwebjfbwejfbjwefbjwefjewbjfbwejfbjwefbjkwebfjwebfjewbjfbewjfbjewbfjewbfjwebfjkwebjkfbwejkfbjwkefbjkwebfjkwebfjkwebjfbwejkfbjwekfbjkwebfjkwebfjkwebfkjbwejkfbwejfbowefipewfoiewboweboubwfjbwejbjwebjkwebjwebfwjekbfjbfkjweebfkjwefbkwefkwevkwevfwkev", "Description Name", 100.00m, 10, "product image");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Too long, maximum 100 characters");
    }

    [Fact(DisplayName = "Create Product With Null Name Value")]
    public void CreateProduct_WithNullNameValue_ResultObjectInvalidState()
    {
        Action action = () => new Product(1, null, "Description Name", 100.00m, 10, "product image");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Name is required");
    }

    [Fact(DisplayName = "Create Product With Null Name Value")]
    public void CreateProduct_WithNullNameValue_ResultObjectInvalidState2()
    {
        Action action = () => new Product(1, "", "Description Name", 100.00m, 10, "product image");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Name is required");
    }

    [Fact(DisplayName = "Create Product With Null Description Value")]
    public void CreateProduct_WithNullDescriptionValue_ResultObjectInvalidState()
    {
        Action action = () => new Product(1, "Product Name", null, 100.00m, 10, "product image");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid description. Description is required");
    }

    [Fact(DisplayName = "Create Product With Null Description Value")]
    public void CreateProduct_WithNullDescriptionValue_ResultObjectInvalidState2()
    {
        Action action = () => new Product(1, "Product Name", "", 100.00m, 10, "product image");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid description. Description is required");
    }

    [Fact(DisplayName = "Create Product With Short Description Value")]
    public void CreateProduct_WithShortDescriptionValue_ResultObjectInvalidState()
    {
        Action action = () => new Product(1, "Product Name", "Desc", 100.00m, 10, "product image");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid description. Too short, minimum 5 characters");
    }

    [Fact(DisplayName = "Create Product With Long Description Value")]
    public void CreateProduct_WithLongDescriptionValue_ResultObjectInvalidState()
    {
        Action action = () => new Product(1, "Product Name", "svdsahfvsahjfvhjsafhjsahjfvsahjvfhjsavfhsavfhsahvsahjfvajhsvfhjasvhfashfjvsahjfvhsajfvhjsavfhjasvfhahfvsahfvashfvhsafvhasvfhsavfhsavhsavhsahfvashvfhsavfhasvfhasvhasvfhasvashfvasfvhasvhasvfhasvfhasvfhasvhvashvashvhasjsvfhassvfhjassvfhasvfhjasvfhjvewbfjbwejkfbjwebfbewfbjwebfjkbwejkfbewjkbfjwebfjbwejbewjfbjwebfjewbjfbwejfbjwebfjwebfjwebjfbwejfbjwefbjwefjewbjfbwejfbjwefbjkwebfjwebfjewbjfbewjfbjewbfjewbfjwebfjkwebjkfbwejkfbjwkefbjkwebfjkwebfjkwebjfbwejkfbjwekfbjkwebfjkwebfjkwebfkjbwejkfbwejfbowefipewfoiewboweboubwfjbwejbjwebjkwebjwebfwjekbfjbfkjweebfkjwefbkwefkwevkwevfwkev", 100.00m, 10, "product image");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid description. Too long, maximum 200 characters");
    }

    [Fact(DisplayName = "Create Product With Invalid Price Value")]
    public void CreateProduct_WithInvalidPriceValue_ResultObjectInvalidState()
    {
        Action action = () => new Product(1, "Product Name", "Description Name", -1.00m, 10, "product image");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid price value");
    }

    [Fact(DisplayName = "Create Product With Invalid Stock Value")]
    public void CreateProduct_WithInvalidStockValue_ResultObjectInvalidState()
    {
        Action action = () => new Product(1, "Product Name", "Description Name", 100.00m, -1, "product image");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid stock value");
    }

    [Fact(DisplayName = "Create Product With Null Image Name No DomainException")]
    public void CreateProduct_WithNullImageName_ResultNoDomainException()
    {
        Action action = () => new Product(1, "Product Name", "Description Name", 100.00m, 10, null);
        action.Should().NotThrow<DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create Product With Null Image Name No Reference Exception")]
    public void CreateProduct_WithNullImageName_ResultNoNullReferenceException()
    {
        Action action = () => new Product(1, "Product Name", "Description Name", 100.00m, 10, null);
        action.Should().NotThrow<NullReferenceException>();
    }

}
