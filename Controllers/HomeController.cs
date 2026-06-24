using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GSULibrary.Models;

namespace GSULibrary.Controllers;

public class HomeController : Controller
{
    private readonly GSUBookContext _context;

    public HomeController(GSUBookContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var books = _context.Books.OrderBy(b => b.Name).ToList();
        return View(books);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
