using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(TestFormViewModel model)
        {
            var data = new List<string>();
            var spliter=model.Number.ToCharArray();
            for (int i = 0; i < spliter.Length; i++)
            {
                var nol = "";
                for (int j = 0; j <= i; j++)
                {
                    nol = nol + "0";
                }
                var hasil = spliter[i].ToString() + nol +"\n";
                data.Add(hasil);
            }
            TempData["hasil"]=data;
            return View();
        }

        public IActionResult Privacy()
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