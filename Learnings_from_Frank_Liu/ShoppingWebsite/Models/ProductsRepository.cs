namespace ShoppingWebsite.Models
{
    public static class ProductsRepository
    {
        public static List<Product> _products = new List<Product>
        {
            new Product {ProductId = 1, CategoryId = 1, Name = "Coca-Cola", Price = 35.23, Quantity = 231},
            new Product {ProductId = 2, CategoryId = 2, Name = "Bread", Price = 5.86, Quantity = 31},
            new Product {ProductId = 3, CategoryId = 3, Name = "Goat", Price = 1555.13, Quantity = 7}
        };

        public static List<Product> GetProducts(bool loadCategory = false)
        {
            if (!(loadCategory))
            return _products;
            else
            {
                if (_products != null && _products.Count > 0)
                {
                    _products.ForEach(x =>
                    {
                        if (x.CategoryId.HasValue)
                            x.Category = CategoriesRepository.GetCategoryById(x.CategoryId);
                    });
                }

                return _products?? new List<Product>();
            }

        }

        public static Product? GetProductById(int productId, bool loadCategory = false)
        {   
            var product = _products.FirstOrDefault(x => x.ProductId == productId);
            if (product != null)
            {
                var prod = new Product
                {
                    ProductId = product.ProductId,
                    CategoryId = product.CategoryId,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = product.Quantity
                };

                if (loadCategory && prod.CategoryId.HasValue)
                {
                    prod.Category = CategoriesRepository.GetCategoryById(prod.CategoryId.Value);
                }

                return prod;
            }

            return null;
        }

        public static void AddProduct(Product product)
        {
            var latestItem = _products.Max(x => x.ProductId);
            product.ProductId = latestItem + 1;
            _products.Add(product);
        }

        public static void UpdateProduct(int? productId, Product product)
        {
            if(productId != product.ProductId) return;

            var productToChange = _products.FirstOrDefault(x => x.ProductId == productId);
            if (productToChange != null)
            {
                productToChange.ProductId = product.ProductId;
                productToChange.CategoryId = product.CategoryId;
                productToChange.Name = product.Name;
                productToChange.Quantity = product.Quantity;
                productToChange.Price = product.Price;
            }
        }

        public static void DeleteProduct(int productId)
        {
            var productToDelete = _products.FirstOrDefault(x => x.ProductId == productId);
            if(productToDelete != null)
            _products.Remove(productToDelete);
        }

        public static List<Product> GetProductsByCategoryId(int categoryId)
        {
            var CategoryProducts = _products.Where(x => x.CategoryId == categoryId);
            if (CategoryProducts != null)
            {
                return CategoryProducts.ToList();
            }
            else
                return new List<Product>();
        }
    }
}
