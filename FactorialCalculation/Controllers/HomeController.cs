using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FactorialCalculation.Models;

namespace FactorialCalculation.Controllers
{
    public class HomeController : Controller
    {        
        [HttpGet]
        public ActionResult CalculateFactorial()
        {
            Factorial fact = new Factorial();
            return View(fact);
        }

        [HttpPost]
        public ActionResult CalculateFactorial(Factorial fact) 
        {
            double res = 1;
            if(ModelState.IsValid)
            {
                if (fact.Number < 2) 
                    res = 1;
                else
                    for (int i = fact.Number; i > 1; i--)
                        res = res * i;
                fact.Result = res;
            }
            return View(fact);
        }
    }
}