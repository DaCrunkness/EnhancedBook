using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Models.DataModels;


namespace Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataContext _db;
        public CategoryController(DataContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> categoryList = _db.Categories.ToList();
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display Order cannot exactly match the Name");
            }

            if (category.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Test is an invalid value");
            }

            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null | id == 0)
            {
                return NotFound();
            }
            Category? dbCategory = _db.Categories.Find(id);
            return View(dbCategory);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {

            if (ModelState.IsValid)
            {
                _db.Categories.Update(category);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null | id == 0)
            {
                return NotFound();
            }
            Category? dbCategory = _db.Categories.Find(id);
            return View(dbCategory);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category? category = _db.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(category);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}