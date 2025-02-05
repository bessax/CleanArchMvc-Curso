using CleanArchMvc.Application.Products.Queries;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Products.Handlers;
internal class GetProductsCategoryHandler : IRequestHandler<GetProdutcCategoryQuery, Product>
{
    private readonly IProductRepository _productRepository;
    public GetProductsCategoryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<Product> Handle(GetProdutcCategoryQuery request, CancellationToken cancellationToken)
    {
        return await _productRepository.GetProductCategoryAsync(request.CategoryId);
    }
}
