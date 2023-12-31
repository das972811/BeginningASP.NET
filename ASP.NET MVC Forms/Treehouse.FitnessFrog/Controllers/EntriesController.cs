using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        SetupActivitiesSelectListItems();

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

        // ModelState.AddModelError("", "This is a global message.");

        ValidateEntry(entry);


        if (ModelState.IsValid)
        {
            Console.WriteLine("Model State is valid");
            _entriesRepository.AddEntry(entry);

            return RedirectToAction("Index");

            /// TODO Display the Entries List Page
        }

        SetupActivitiesSelectListItems();

        return View(entry);
    }

    public IActionResult Edit(int? id)
    {
        if (id is null)
        {
            return BadRequest();
        }

        Entry? entry = _entriesRepository.GetEntry((int) id);

        if (entry is null)
        {
            return NotFound();
        }

        ValidateEntry(entry);
        SetupActivitiesSelectListItems();
        return View();
    }

    [HttpPost]
    public IActionResult Edit(Entry entry) {
        ValidateEntry(entry);

        if (ModelState.IsValid)
        {
            _entriesRepository.UpdateEntry(entry);

            return RedirectToAction("Index");
        }

        SetupActivitiesSelectListItems();
        return View(entry);
    }

    public IActionResult Delete(int? id)
    {
        if (id is null)
        {
            return BadRequest();
        }

        return View();
    }

    private void ValidateEntry(Entry entry)
    {
        if (ModelState.ContainsKey("Duration") && ModelState["Duration"]?.Errors.Count == 0 && entry.Duration <= 0)
        {
            ModelState.AddModelError("Duration", "The Duration Field value must be greater than '0'");
        }
    }

    private void SetupActivitiesSelectListItems()
    {
        ViewBag.ActivitiesSelectListItems = new SelectList(
            Data.Data.Activities, "Id", "Name"
        );
    }
}
