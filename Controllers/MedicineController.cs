using AppointmentScheduling.Models;
using AppointmentScheduling.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Controllers
{
    public class MedicineController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MedicineController(ApplicationDbContext db)
        {
            _db = db;
        }

        //public IActionResult Index()
        //{
        //    IEnumerable<Medicine> objList = _db.Medicines;

        //    foreach (var obj in objList)
        //    {
        //        obj.Category = _db.Categories.FirstOrDefault(u => u.Id == obj.CategoryId);
        //    }

        //    return View(objList);
        //}

        //--------bawah-----------------
        public IActionResult Index(string SearchText = "")
        {
            IEnumerable<Medicine> objList;

            if (SearchText != "" && SearchText != null)
            {
                objList = _db.Medicines
                .Where(p => p.MedicineName.Contains(SearchText))
                .ToList();
            }
            else
            objList = _db.Medicines;

            foreach(var obj in objList)
            {
                obj.Category = _db.Categories.FirstOrDefault(u => u.Id == obj.CategoryId);
            }

            return View(objList);
        }
        //---------atas----------------


        // GET-Create
        public IActionResult Create()
        {
            MedicineVM medicineVM = new MedicineVM()
            {
                Medicine = new Medicine(),
                TypeDropDown = _db.Categories.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };

            return View(medicineVM);
        }

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MedicineVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Medicines.Add(obj.Medicine);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET-Delete
       
        public IActionResult Delete(int? id)
        {
            
            if (id == null || id==0)
            {
                return NotFound();
            }
            var obj = _db.Medicines.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }


        // POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Medicines.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
         
                _db.Medicines.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
          
        }

        // GET UPDATE
        public IActionResult Update(int? id)
        {
            MedicineVM medicineVM = new MedicineVM()
            {
                Medicine = new Medicine(),
                TypeDropDown = _db.Categories.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };

            if (id == null || id == 0)
            {
                return NotFound();
            }
            medicineVM.Medicine = _db.Medicines.Find(id);
            if (medicineVM.Medicine == null)
            {
                return NotFound();
            }
            return View(medicineVM);

        }

        // POST UPDATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(MedicineVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Medicines.Update(obj.Medicine);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}

    

