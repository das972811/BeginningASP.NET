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

        return View(ViewBag);
    }

    public IActionResult Add()
    {
        return View();
    }
}
