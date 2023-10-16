
using Microsoft.AspNetCore.Mvc;

using comic_book_gallery.Data;

namespace comic_book_gallery.Controllers;

public class ComicBooksController : Controller
{
    private readonly ComicBookRepository _comicBookRepository;

    public ComicBooksController()
    {
        _comicBookRepository = new ComicBookRepository();
    }

    public IActionResult Index()
    {
        var comicBooks = _comicBookRepository.GetComicBooks();

        return View(comicBooks);
    }

    public IActionResult Detail(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        return View(_comicBookRepository.GetComicBook(id.Value));
    }
}