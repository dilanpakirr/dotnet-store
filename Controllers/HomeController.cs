using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_store.Models;

namespace dotnet_store.Controllers;

public class HomeController : Controller

{
    private readonly DataContext _context;
    public HomeController(DataContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        ViewData["categories"] = _context.Categories.ToList();
        return View(products);
    }
}