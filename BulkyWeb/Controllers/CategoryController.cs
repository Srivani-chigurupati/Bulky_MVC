using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryController(ICategoryRepository db)
        {
            _categoryRepo = db;
        }

       
        public IActionResult Index()
        {
            List<Category> categoryList = _categoryRepo.GetAll().ToList();
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display order cannot be same as Name");
            }
           
            if (ModelState.IsValid)
            {
                _categoryRepo.Add(obj);
                _categoryRepo.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");

            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            //Category item= _db.Categories.Find(id);
            Category? item = _categoryRepo.Get(u => u.Id == id);

            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
      
            if (ModelState.IsValid)
            {
                _categoryRepo.Update(obj);
                _categoryRepo.Save();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //Category item= _db.Categories.Find(id);
            Category? item = _categoryRepo.Get(u => u.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category? obj = _categoryRepo.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            
            _categoryRepo.Remove(obj);
            _categoryRepo.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
           
        }
    }
}
