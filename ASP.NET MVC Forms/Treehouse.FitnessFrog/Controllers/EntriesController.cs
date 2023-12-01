using System.Net;
using Microsoft.AspNetCore.Mvc;

using Treehouse.FitnessFrog.Data;
using Treehouse.FitnessFrog.Models;

namespace Treehouse.FitnessFrog.Controllers;

public class EntriesController : Controller
{
    private EntriesRepository _entriesRepository;

    public EntriesController()
    {
        _entriesRepository = new();
    }

    public IActionResult Index()
    {
        List<Entry> entries = _entriesRepository.GetEntries();

        double totalActivity = entries
            .Where(e => e.Exclude == false)
            .Sum(e => e.Duration);

        int numberOfActiveDays = entries
            .Select(e => e.Date)
            .Distinct()
            .Count();

        ViewBag.TotalActivity = totalActivity;
        ViewBag.AverageDailyActivity = (double) (totalActivity / (double) numberOfActiveDays);

        return View(entries);
    }

    public IActionResult Add()
    {
        var entry = new Entry()
        {
            Date = DateTime.Today
        };

        return View(entry);
    }

    // [HttpPost]
    // public IActionResult Add(
    //     DateTime? date, int? activityId, double? duration,
    //     Entry.IntensityLevel? intensity, bool? exclude, string notes
    // )
    [HttpPost]
    public IActionResult Add(Entry entry)
    {

        // ViewBag.Date = ModelState["Date"]?.AttemptedValue;
        // ViewBag.ActivityId = ModelState["ActivityId"]?.AttemptedValue;
        // ViewBag.Duration = ModelState["Duration"]?.AttemptedValue;
        // ViewBag.Intensity = ModelState["Intensity"]?.AttemptedValue;
        // ViewBag.Exclude = ModelState["Exclude"]?.AttemptedValue;
        // ViewBag.Notes = ModelState["Notes"]?.AttemptedValue;
        if (ModelState.IsValid)
        {
            Console.WriteLine("Model State is valid");
            _entriesRepository.AddEntry(entry);

            return RedirectToAction("Index");

            /// TODO Display the Entries List Page
        }

        return View(entry);
    }

    public IActionResult Edit(int? id)
    {
        if (id is null)
        {
            return BadRequest();
        }
        
        return View();
    }

    public IActionResult Delete(int? id)
    {
        if (id is null)
        {
            return BadRequest();
        }

        return View();
    }
}
