using Microsoft.AspNetCore.Mvc;

namespace comic_book_gallery.Controllers;

public class ComicBooksController : Controller
{
    public IActionResult Detail()
    {
        ViewBag.SeriesTitle = "The Amazing Spider-Man";
        ViewBag.issuedNumber = 700;
        ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
        ViewBag.Artists = new string[]
        {
            "Script: Dan Slott",
            "Pencils: Humberto Ramos",
            "Inks: Victor Olazaba",
            "Colors: Edgar Delgado",
            "Letters: Chris Eliopoulos"
        };



        return View();
    }
}