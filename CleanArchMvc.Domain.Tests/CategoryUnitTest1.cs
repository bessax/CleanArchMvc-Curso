using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Validation;
using FluentAssertions;

namespace CleanArchMvc.Domain.Tests;

public class CategoryUnitTest1
{
    [Fact(DisplayName ="Create Category With Valid State.")]
    public void CreateCategory_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Category(1, "Category Name");
       action.Should().NotThrow<DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create Category With Invalid Id Value.")]
    public void CreateCategory_WithInvalidIdValue_ResultObjectInvalidState()
    {
        Action action = () => new Category(-1, "Category Name");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid Id value");
    }

    [Fact(DisplayName = "Create Category With Short Name Value.")]
    public void CreateCategory_WithShortNameValue_ResultObjectInvalidState()
    {
        Action action = () => new Category(1, "Ca");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Too short, minimum 3 characters");
    }

    [Fact(DisplayName = "Create Category With Long Name Value.")]
    public void CreateCategory_WithLongNameValue_ResultObjectInvalidState()
    {
        Action action = () => new Category(1, "svdsahfvsahjfvhjsafhjsahjfvsahjvfhjsavfhsavfhsahvsahjfvajhsvfhjasvhfashfjvsahjfvhsajfvhjsavfhjasvfhahfvsahfvashfvhsafvhasvfhsavfhsavhsavhsahfvashvfhsavfhasvfhasvhasvfhasvashfvasfvhasvhasvfhasvfhasvfhasvhvashvashvhasjsvfhassvfhjassvfhasvfhjasvfhjvewbfjbwejkfbjwebfbewfbjwebfjkbwejkfbewjkbfjwebfjbwejbewjfbjwebfjewbjfbwejfbjwebfjwebfjwebjfbwejfbjwefbjwefjewbjfbwejfbjwefbjkwebfjwebfjewbjfbewjfbjewbfjewbfjwebfjkwebjkfbwejkfbjwkefbjkwebfjkwebfjkwebjfbwejkfbjwekfbjkwebfjkwebfjkwebfkjbwejkfbwejfbowefipewfoiewboweboubwfjbwejbjwebjkwebjwebfwjekbfjbfkjweebfkjwefbkwefkwevkwevfwkev");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Too long, maximum 100 characters");
    }

    [Fact(DisplayName = "Create Category With Null Name Value.")]
    public void CreateCategory_WithNullNameValue_ResultObjectInvalidState()
    {
        Action action = () => new Category(1, null);
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Name is required");
    }

    [Fact(DisplayName = "Create Category With Null Name Value.")]
    public void CreateCategory_WithNullNameValue_ResultObjectInvalidState2()
    {
        Action action = () => new Category(1, "");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Name is required");
    }

    [Fact(DisplayName = "Update Category With Valid Name.")]
    public void UpdateCategory_WithValidName_ResultObjectValidState()
    {
        var category = new Category(1, "Category Name");
        Action action = () => category.Update("New Category Name");
        action.Should().NotThrow<DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Update Category With Short Name Value.")]
    public void UpdateCategory_WithShortNameValue_ResultObjectInvalidState()
    {
        var category = new Category(1, "Category Name");
        Action action = () => category.Update("Ca");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Too short, minimum 3 characters");
    }

    [Fact(DisplayName = "Update Category With Long Name Value.")]
    public void UpdateCategory_WithLongNameValue_ResultObjectInvalidState()
    {
        var category = new Category(1, "Category Name");
        Action action = () => category.Update("svdsahfvsahjfvhjsafhjsahjfvsahjvfhjsavfhsavfhsahvsahjfvajhsvfhjasvhfashfjvsahjfvhsajfvhjsavfhjasvfhahfvsahfvashfvhsafvhasvfhsavfhsavhsavhsahfvashvfhsavfhasvfhasvhasvfhasvashfvasfvhasvhasvfhasvfhasvfhasvhvashvashvhasjsvfhassvfhjassvfhasvfhjasvfhjvewbfjbwejkfbjwebfbewfbjwebfjkbwejkfbewjkbfjwebfjbwejbewjfbjwebfjewbjfbwejfbjwefbjwefjewbjfbwejfbjwefbjkwebfjwebfjewbjfbewjfbjewbfjewbfjwebfjkwebjkfbwejkfbjwkefbjkwebfjkwebfjkwebjfbwejkfbjwekfbjkwebfjkwebfjkwebfkjbwejkfbwejfbowefipewfoiewboweboubwfjbwejbjwebjkwebjwebfwjekbfjbfkjweebfkjwefbkwefkwevkwevfwkev");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Too long, maximum 100 characters");
    }

    [Fact(DisplayName = "Update Category With Null Name Value.")]
    public void UpdateCategory_WithNullNameValue_ResultObjectInvalidState()
    {
        var category = new Category(1, "Category Name");
        Action action = () => category.Update(null);
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Name is required");
    }

    [Fact(DisplayName = "Update Category With Null Name Value.")]
    public void UpdateCategory_WithNullNameValue_ResultObjectInvalidState2()
    {
        var category = new Category(1, "Category Name");
        Action action = () => category.Update("");
        action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name. Name is required");
    }
    
    
}
