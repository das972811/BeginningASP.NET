using Microsoft.AspNetCore.Mvc;

namespace comic_book_gallery.Controllers;

public class ComicBooksController : Controller
{
    public IActionResult Detail()
    {
        return View();
    }
}