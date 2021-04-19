using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel { Name = "Emily" });
            users.Add(new UserModel { Name = "Richard" });
            ViewData["users"] = users;
            return View();
        }

       
        public ViewResult GetForm()
        {
            return View("Form");
        }

        [ServiceFilter(typeof(ValidationFilter))]
        [HttpPost]
        public IActionResult PostForm(EmployeeModel employee)
        { 
            ViewBag.FullName = "Thank you for submitting the form " + employee.FirstName + " " + employee.LastName;
            return View("Form");
        }
    }
}
