using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSaleMVC.Services;

namespace ProjectSaleMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        //injeção de dependêcia
        public SellersController(SellerService sellerService)
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