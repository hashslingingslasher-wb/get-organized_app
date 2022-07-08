using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace get_organized.Controllers
{
    public class GoController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}