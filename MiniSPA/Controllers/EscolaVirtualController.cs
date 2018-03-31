using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniSPA.EscolaVirtual.Registros.Factory;
using MiniSPA.EscolaVirtual.Registros.Interfaces;

namespace MiniSPA.Controllers
{
    public class EscolaVirtualController : Controller
    {
        private IRegistroFactory _registrationFactory;

        public EscolaVirtualController()
        {
            _registrationFactory = new RegistroFactory();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", _registrationFactory.BuildRegistration());
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}