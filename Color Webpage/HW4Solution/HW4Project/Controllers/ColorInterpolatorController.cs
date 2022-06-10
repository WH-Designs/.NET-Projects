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
    public class ColorInterpolatorController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View("ColorInterpolator");
        }

        [HttpPost]
        public IActionResult Create(ColorInterpolation c)
        {
            Color firstColor = ColorTranslator.FromHtml(c.FirstColor);
            Color secondColor = ColorTranslator.FromHtml(c.SecondColor);

            int steps = c.NumberOfColors;

            c.ListOfColors = ColorInterpolation.CreateListOfColors(firstColor, secondColor, steps);

            return View("ColorInterpolator", c);
        }
    }
}