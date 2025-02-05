using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Exceptions;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Application.Products.Commands;
using CleanArchMvc.Application.Products.Queries;
using MediatR;

namespace CleanArchMvc.Application.Services;
public class ProductService : IProductService
{

    private readonly IMapper _mapper;
    private readonly IMediator _mediator;
    public ProductService(IMapper mapper, IMediator mediator)
    {

        _mapper = mapper;
        _mediator = mediator;
    }
     public async Task<ProductDTO> GetById(int? id)
    {
        var getProductByIdQuery = new GetProductByIdQuery(id.Value);
        if (getProductByIdQuery == null)
        {
            throw new ApplicationHandlerException($"Entity could not be loaded");
        }
        var productEntity = await _mediator.Send(getProductByIdQuery);
        return _mapper.Map<ProductDTO>(productEntity);
    }

    public async Task<ProductDTO> GetProductCategory(int? id)
    {
        var getproductCategoryQuery = new GetProdutcCategoryQuery(id!.Value);
        if (getproductCategoryQuery == null)
        {
            throw new ApplicationHandlerException($"Entity could not be loaded");
        }
        var productEntity = await _mediator.Send(getproductCategoryQuery);
        return _mapper.Map<ProductDTO>(productEntity);

    }

    public async Task<IEnumerable<ProductDTO>> GetProducts()
    {
        var productsQuery = new GetProductsQuery();

        if (productsQuery == null)
        {
            throw new ApplicationHandlerException($"Entity could not be loaded");
        }

        var result = await _mediator.Send(productsQuery);

        return _mapper.Map<IEnumerable<ProductDTO>>(result);
    }

    public async Task Add(ProductDTO productDto)
    {
        var productCreateCommand = _mapper.Map<ProductCreateCommand>(productDto);
        await _mediator.Send(productCreateCommand);
    }

    public async Task Update(ProductDTO productDto)
    {
        var productUpdateCommand = _mapper.Map<ProductUpdateCommand>(productDto);
        await _mediator.Send(productUpdateCommand);
    }

    public async Task Remove(int? id)
    {
        var productRemoveCommand = new ProductRemoveCommand(id.Value);
        if (productRemoveCommand == null)
            throw new ApplicationHandlerException($"Entity could not be loaded.");

        await _mediator.Send(productRemoveCommand);
    }

}
