using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CleanArchMvc.WebUI.Controllers;
public class ProductsController : Controller
{
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;
    private readonly IWebHostEnvironment _env;
    public ProductsController(IProductService productService, ICategoryService categoryService, IWebHostEnvironment env)
    {
        _productService = productService;
        _categoryService = categoryService;
        _env = env;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var products = await _productService.GetProducts();
        return View(products);        
    }

    [HttpGet]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var product = await _productService.GetById(id);
        if (product == null)
        {
            return NotFound();
        }
       
        var wwwroot = _env.WebRootPath;
        var image = System.IO.Path.Combine(wwwroot, "images\\", product.Image!);
        ViewBag.ImageExist = System.IO.File.Exists(image);    

        return View(product);
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        ViewBag.CategoryId = new SelectList(await _categoryService.GetCategories(), "Id", "Name");
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ProductDTO productDto)
    {
        if (ModelState.IsValid)
        {
            await _productService.Add(productDto);
            return RedirectToAction(nameof(Index));
        }
        return View(productDto);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var product = await _productService.GetById(id);
        if (product == null)
        {
            return NotFound();
        }

        ViewBag.CategoryId = new SelectList(await _categoryService.GetCategories(), "Id", "Name",product.CategoryId);

        return View(product);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(ProductDTO productDto)
    {
        if (ModelState.IsValid)
        {
            try
            {
                await _productService.Update(productDto);
            }
            catch (Exception ex)
            {

                throw new Exception($"Error on update product: {ex.Message}");
            }
            
            return RedirectToAction(nameof(Index));
        }
        return View(productDto);
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var product = await _productService.GetById(id);
        if (product == null)
        {
            return NotFound();
        }
        return View(product);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        await _productService.Remove(id);
        return RedirectToAction(nameof(Index));
    }


}
