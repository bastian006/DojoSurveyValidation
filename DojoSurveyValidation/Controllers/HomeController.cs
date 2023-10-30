using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpGet]
    [Route("privacy")]
    public IActionResult Privacy()
    {
        return View("Privacy");
    }

    [HttpPost("survey")]
    public IActionResult Form(Survey yourSurvey)
    {
        if(ModelState.IsValid)
        {
            return RedirectToAction("Results", yourSurvey);
        }

        return View("Index");
    }


    [HttpGet("results")]
    public ViewResult Results(Survey yourSurvey)
    {
        return View("Results", yourSurvey);
    }
        



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
