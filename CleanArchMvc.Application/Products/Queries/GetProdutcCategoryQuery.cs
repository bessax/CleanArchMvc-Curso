using CleanArchMvc.Domain.Entities;
using MediatR;

namespace CleanArchMvc.Application.Products.Queries;
public class GetProdutcCategoryQuery : IRequest<Product>
{
    public int CategoryId { get; set; }
    public GetProdutcCategoryQuery(int categoriaId)
    {
        CategoryId = categoriaId;
    }
}
