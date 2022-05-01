using Microsoft.AspNetCore.Mvc;

namespace Qichub.Controllers;

public class HomeController : Controller
{
    public string Index()
    {
        return "Hello World!";
    }
}