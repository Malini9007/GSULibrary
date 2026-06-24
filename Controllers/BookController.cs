using Microsoft.AspNetCore.Mvc;
using GSULibrary.Models;

namespace GSULibrary.Controllers;

public class BookController : Controller
{
    private readonly GSUBookContext _context;

    public BookController(GSUBookContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View(new GSUBook());
    }

    [HttpPost]
    public IActionResult Add(GSUBook book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var book = _context.Books.Find(id);
        if (book == null)
            return NotFound();

        return View(book);
    }

    [HttpPost]
    public IActionResult Edit(GSUBook book)
    {
        _context.Books.Update(book);
        _context.SaveChanges();
        return RedirectToAction("Index", "Home");
    }

    // GET: confirm deletion
    public IActionResult Delete(int id)
    {
        var book = _context.Books.Find(id);
        if (book == null)
            return NotFound();

        return View(book);
    }

    // POST: confirmed deletion
    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var book = _context.Books.Find(id);
        if (book != null)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        return RedirectToAction("Index", "Home");
    }
}
