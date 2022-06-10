using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HW4Project.Models;
using System.Drawing;


namespace HW4Project.Controllers
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

        public IActionResult RgbColorPage()
        {
            return View("Rgbcolor");
        }

        [HttpGet]
        public IActionResult RgbColor(int? red, int? green, int? blue)
        {
            string hexString = null;

            int newRed = red ?? 0;
            int newGreen = green ?? 0;
            int newBlue = blue ?? 0;

            Color newColor = Color.FromArgb(newRed, newGreen, newBlue);

            hexString = ColorTranslator.ToHtml(newColor);

            return View("Rgbcolor", hexString);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
