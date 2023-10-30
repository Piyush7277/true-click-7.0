using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;
using System.Text;
using webcode.Models;
using webcode.ViewModels;

namespace webcode.Controllers
{
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

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Plan()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel oLoginViewModel)
        {
            try
            {
                if(ModelState.IsValid)
                {

                }
                return View();
            }
            catch(Exception ex)
            {
                ViewData["_ErrorMessage"] = ex.Message;
                return View();
            }
           
        }
        public IActionResult Registration(string rid)
        {

            //Response.Redirect("https://play.google.com/store/apps/details?id=com.mobilebaapnetwork");

            ViewData["_referralcode"] = rid;

            //DataTable dtCountry = fnIU.GetCountryList();
            //ViewData["_country"] = dtCountry;

            return View();
        }
        public IActionResult ForgetPassword()
        {
            return View();
        }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
