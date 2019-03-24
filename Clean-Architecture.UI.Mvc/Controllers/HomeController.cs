using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Clean_Architecture.UI.Mvc.Models;
using Clean_Architecture.Core.Interfaces.UseCases;
using Clean_Architecture.Core.Entities;

namespace Clean_Architecture.UI.Mvc.Controllers
{
    public class HomeController : Controller
    {
        IRegisterCollaboraterUseCase _UseCase;

        public HomeController(IRegisterCollaboraterUseCase useCase)
        {
            _UseCase = useCase;
        }

        public IActionResult Index()
        {
            List<Collaborater> list = _UseCase.GetCollaboraters();
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
