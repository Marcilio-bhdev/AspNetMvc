using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Services;

namespace SalesWeb.Controllers
{
    public class SallerController : Controller
    {
        private readonly SallerService _sellerService;

        public SallerController(SallerService sellerService) 
        {
            _sellerService = sellerService;
        
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

    }
}