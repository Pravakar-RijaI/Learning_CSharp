using Microsoft.AspNetCore.Mvc;
using ShoppingWebsite.Models;

namespace ShoppingWebsite.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            List<Category> categories = CategoriesRepository.GetCategories();
            return View(categories);
        }

        public IActionResult Edit(int? id)
        {
            ViewBag.Action = "edit";
            Category? category = CategoriesRepository.GetCategoryById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
            CategoriesRepository.UpdateCategory(category.Id, category);

            return RedirectToAction("Index");
            }

            return View(category);
        }

        public IActionResult Add()
        {
            ViewBag.Action = "add";
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
            CategoriesRepository.AddCategory(category);
            return RedirectToAction("Index");
            }

            return View(category);
        }

        public IActionResult Delete(int id)
        {
            CategoriesRepository.DeleteCategory(id);
            return RedirectToAction("Index");
        }
    }
}
