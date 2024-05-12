using Dentistry_Diplom.Data.Context;
using Dentistry_Diplom.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Dentistry_Diplom.Controllers
{
    public class CategoryController : Controller
    {
        private DensContext db;
        public CategoryController(DensContext context)
        {
            db = context;
        }
        public IActionResult TerapevtCategory()
        {
            List<DentistryInfo> dens = db.DentistryTable.ToList();
            ViewBag.Title = "Терапевтическое отделение";
            return View(dens);
        }
        public IActionResult HirurgCategory()
        {
            List<DentistryInfo> dens = db.DentistryTable.ToList();
            ViewBag.Title = "Хирургическое отделение";
            return View(dens);
        }
        public IActionResult OrtodontCategory()
        {
            List<DentistryInfo> dens = db.DentistryTable.ToList();
            ViewBag.Title = "Ортодонтическое отделение";
            return View(dens);
        }
        public IActionResult OrtopedCategory()
        {
            List<DentistryInfo> dens = db.DentistryTable.ToList();
            ViewBag.Title = "Ортопедическое отделение";
            return View(dens);
        }
        public IActionResult SpecialistCategory()
        {
            List<DentistryInfo> dens = db.DentistryTable.ToList();
            ViewBag.Title = "Список наших специалистов";
            return View(dens);
        }
    }
}
