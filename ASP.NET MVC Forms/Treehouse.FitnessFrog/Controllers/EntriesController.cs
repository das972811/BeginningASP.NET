using Microsoft.AspNetCore.Mvc;

namespace Treehouse.FitnessFrogs.Controllers;

public class EntriesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Add()
    {
        return View();
    }
}
