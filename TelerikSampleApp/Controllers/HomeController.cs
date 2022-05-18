using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace TelerikSampleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Setting TLS 1.2 protocol
            //ServicePointManager.Expect100Continue = true;
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This code sample was a joint effort between Progress and Karen Payne";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
