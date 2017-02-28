using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlexLoveDaniel.Models;

namespace AlexLoveDaniel.Controllers
{
    public class PersonsController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var models = DataManager.GetIndexList();
            return View(models);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonCreateVM viewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(viewModel);
            }
            DataManager.AddPerson(viewModel);
            return RedirectToAction(nameof(PersonsController.Index));
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View(person);
            }
            DataManager.EditPerson(person);
            return RedirectToAction(nameof(PersonsController.Index));
        }
    }
}
