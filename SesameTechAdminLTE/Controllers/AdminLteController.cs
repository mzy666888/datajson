using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SesameTechAdminLTE.Controllers
{
    public class AdminLteController : Controller
    {
        
        public AdminLteController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Echarts()
        {
            return View();
        }

        public IActionResult Create()
        {
            
            return View();
        }
    }
}