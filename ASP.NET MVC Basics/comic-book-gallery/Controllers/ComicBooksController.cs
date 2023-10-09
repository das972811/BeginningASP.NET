using Microsoft.AspNetCore.Mvc;

namespace comic_book_gallery.Controllers;

public class ComicBooksController : Controller
{
    public IActionResult Detail()
    {
        if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
        {
            return Redirect("/");
        }

        return Content("Hello from the comic books controller");
    }
}