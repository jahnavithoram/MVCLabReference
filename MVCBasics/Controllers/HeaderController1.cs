using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Controllers
{
    public class HeaderController1 : Controller
    {
        public PartialViewResult Index()
        {
            ViewBag.Text = "This partial v data coming from server";
            return PartialView("_Header");
        }
    }
}
