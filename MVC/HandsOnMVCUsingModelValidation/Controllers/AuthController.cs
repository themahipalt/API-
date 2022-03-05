using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingModelValidation.Models;
namespace HandsOnMVCUsingModelValidation.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if(ModelState.IsValid)
            {
                //add Customer Details to db table
                return Json(customer);
            }
            else
            {
                return View(); //retrun to Create View
            }
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            if(ModelState.IsValid)
            {
                //validating the User
                if(user.Email=="admin@gmail.com" && user.Password=="12345")
                {
                    return Json(user); //return Json data
                }
                else
                {
                    ViewBag.Error = "Invalid Credentials";
                    return View();
                }
               
            }
            else
            {
                return View();
            }
        }

    }
}
