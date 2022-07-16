using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Net.Http;

namespace get_organized.Controllers
{
    public class GoController : Controller
    {
        IWebHostEnvironment _hostingEnvironment;
        public GoController(IWebHostEnvironment hostingEnvironmnent){
            _hostingEnvironment = hostingEnvironmnent;
        }
        //private Microsoft.AspNetCore.Hosting.IWebHostEnvironment Environment;
        //Get Views
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Confirm()
        {
            return View();
        }
        public IActionResult Upload()
        {
            return View();
        }
        //File upload functions
        
    
    }
}