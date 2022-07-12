using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace get_organized.Controllers
{
    public class GoController : Controller
    {
        // 
        // GET: /Go/(Index)

        public IActionResult Index()
        {
            return View();
        } 
        // GET: /Go/Confirm/
        public IActionResult Confirm()
        {
            return View();
        }
        //GET: /Go/Upload/
        public IActionResult Upload()
        {
            return View();
        }
    }
}