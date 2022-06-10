using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HW3Project.Models;

namespace HW3Project.Controllers
{
    public class HomeController : Controller
    {
        private GroceryItemsModel _GroceryItemsModel = new GroceryItemsModel();
        public IList<GroceryItemModel> currentItems = new List<GroceryItemModel>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Directions()
        {
            return View();
        }
        public IActionResult AddGroceryItem(string itemName, int? itemQuantity)
        { 
            var newItem = new GroceryItemModel();
            newItem.ItemName = itemName;
            newItem.ItemCount = itemQuantity ?? 1;

            currentItems = _GroceryItemsModel.AddItem(newItem, currentItems);

            return View("Index", currentItems);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
