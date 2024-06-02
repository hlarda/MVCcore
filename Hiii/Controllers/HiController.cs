using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Hiii.Controllers;

public class HiController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Welcome(string name, int id = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["ID"] = id;
        return View();
    }
}

//? uses a format like this to determine what controller action to invoke:
///* /[Controller]/[ActionName]/[Parameters]
// for example:
// https://localhost:7144/Hi/welcome?name=hla&id=73