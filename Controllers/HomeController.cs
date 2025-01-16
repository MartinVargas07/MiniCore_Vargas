using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VideoExplicativoAspNet.Models;
using System.ComponentModel.DataAnnotations;
using System; 
using System.Linq;
using Microsoft.Extensions.Logging;
using VideoExplicativoAspNet.Data; 

namespace VideoExplicativoAspNet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
