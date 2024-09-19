using ShoppingWebsite.Models;
using ShoppingWebsite.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingWebsite.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            SalesViewModel salesViewModel = new SalesViewModel
            {
                Categories = CategoriesRepository.GetCategories()
            };

            return View(salesViewModel);
        }

        public IActionResult ProductsByCategoryPartial(int categoryId)
        {
            List<Product> categoryProducts = ProductsRepository.GetProductsByCategoryId(categoryId);

            return PartialView("_CategoryProducts",categoryProducts);
        }
    }
}
