using AppointmentScheduling.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CompanyController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Company> objList = _db.Companies;
            return View(objList);
        }

        // GET-Create
        public IActionResult Create()
        {
            return View();
        }

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Company obj)
        {
            _db.Companies.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
