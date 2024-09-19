using Microsoft.AspNetCore.Mvc;
using ShoppingWebsite.Models;
using ShoppingWebsite.ViewModels;

namespace ShoppingWebsite.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = ProductsRepository.GetProducts(loadCategory: true);
            return View(products);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Action = "edit";

            var productViewModel = new ProductViewModel
            {
                Product = ProductsRepository.GetProductById(id)??new Product(),
                Categories = CategoriesRepository.GetCategories()
            };

            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
            ProductsRepository.UpdateProduct(productViewModel.Product.ProductId, productViewModel.Product);
            return RedirectToAction("Index");
            }

            productViewModel.Categories = CategoriesRepository.GetCategories();
            return View(productViewModel);
        }

        public IActionResult Add()
        {
            ViewBag.Action = "add";

            ProductViewModel productViewModel = new ProductViewModel
            {
                Categories = CategoriesRepository.GetCategories()
            };

            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult Add(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                ProductsRepository.AddProduct(productViewModel.Product);
                return RedirectToAction("Index");
            }

            productViewModel.Categories = CategoriesRepository.GetCategories();
            return View(productViewModel);
        }


        public IActionResult Delete(int id)
        {
            ProductsRepository.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}
