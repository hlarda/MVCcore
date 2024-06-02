using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Hiii.Controllers;

public class HiController : Controller
{
    public string Index()
    {
        return "This is my default action...";
    }
    public string Welcome(string name, int id = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID {id}");
    }
}

//? uses a format like this to determine what controller action to invoke:
///* /[Controller]/[ActionName]/[Parameters]
// for example:
// https://localhost:7144/Hi/welcome?name=hla&id=73