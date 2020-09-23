using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OVERS.Models;
namespace OVERS.Controllers
{
    public class CustomerRegistrationController : Controller
    {
        private readonly CustomerDB cd;
        public CustomerRegistrationController(CustomerDB _cd)
        {
            cd = _cd;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Custometb c)
        {
            cd.Add(c);
            cd.SaveChanges();
            ViewBag.Message = "customer is successfully recorded";
            return View();


        }
        [HttpPost]
        public IActionResult ShowCustomers()
        {
            return View();
        }

        public IActionResult ShowCustomers(CustomerDB c)
        {
            var cust = cd.custometbl.ToArray();
            cd.SaveChanges();
            return View(cust);
        }
    }
}
