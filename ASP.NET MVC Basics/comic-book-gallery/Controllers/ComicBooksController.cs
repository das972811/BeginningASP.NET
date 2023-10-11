using comic_book_gallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace comic_book_gallery.Controllers;

public class ComicBooksController : Controller
{
    public IActionResult Detail()
    {
        var comicBook = new ComicBook()
        {
            SeriesTitle = "The Amazing Spier-Man",
            IssueNumber = 700,
            DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
            Artists = new Artist[]
            {
                new() { Name = "Script", Role = "Dan Slott" },
                new() { Name = "Pendils", Role = "Humberto Ramos" },
                new() { Name = "Inks", Role = "Victor Olazaba" },
                new() { Name = "Colors", Role = "Edgar Delgado" },
                new() { Name = "Letters", Role = "Chris Elipoulos" }
            }
        };

        // ViewBag.SeriesTitle = "The Amazing Spider-Man";
        // ViewBag.IssuedNumber = 700;
        // ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
        // ViewBag.Artists = new string[]
        // {
        //     "Script: Dan Slott",
        //     "Pencils: Humberto Ramos",
        //     "Inks: Victor Olazaba",
        //     "Colors: Edgar Delgado",
        //     "Letters: Chris Eliopoulos"
        // };



        return View(comicBook);
    }
}