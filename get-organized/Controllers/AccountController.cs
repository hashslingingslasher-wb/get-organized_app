using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace get_organized.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult CreateAccount()
        {
            return View();
        }
        
        public IActionResult Login(){
            return View();
        }

    }
}