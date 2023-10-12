using Microsoft.AspNetCore.Mvc;

using comic_book_gallery.Data;

namespace comic_book_gallery.Controllers;

public class ComicBooksController : Controller
{
    public IActionResult Detail()
    {
        var comicBook = new ComicBookRepository();
        return View(comicBook.GetComicBook(700));
    }
}