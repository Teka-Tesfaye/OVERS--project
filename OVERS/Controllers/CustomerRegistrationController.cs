using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
        public IActionResult Register(custometbl c)
        {
            cd.Add(c);
            cd.SaveChanges();
            ViewBag.Message = "customer is successfully recorded";
            return View();


        }
       

        public IActionResult ShowCustomers(CustomerDB c)
        {
            var cust = cd.custometbl.ToArray();
            cd.SaveChanges();
            ViewBag.Message = "Data is successfully inserted";
            return View(cust);
        }
       [ HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DisplayCustomers()
        {
            var result = cd.custometbl.ToList();
            return View(result);
        }

    
    }
}
