using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SampleMVCApp.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /Hello/
    public IActionResult Index()
    {
        return View();
    }
    //
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello" + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}