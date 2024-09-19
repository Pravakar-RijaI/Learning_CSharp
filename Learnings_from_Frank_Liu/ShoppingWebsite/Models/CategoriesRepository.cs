namespace ShoppingWebsite.Models
{
    public static class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>
        {
            new Category{Id = 1, Name = "Beverages", Description = "Drink Something."},
            new Category{Id = 2, Name = "Bakery", Description = "Eat Something."},
            new Category{Id = 3, Name = "Meat", Description = "Deviour Something."}
        };

        public static void AddCategory(Category category)
        {
            var latestId = _categories.Max(x => x.Id);

            if (!latestId.HasValue)
            {
                latestId = 0;
            }

            category.Id = latestId + 1;
            _categories.Add(category);
        }

        public static List<Category> GetCategories()
        {
            return _categories;
        }

        public static Category? GetCategoryById(int? id)
        {
            var category = _categories.FirstOrDefault(x => x.Id == id);
            if (category != null)
            {
                return new Category
                    {
                        Id = category.Id,
                        Name = category.Name,
                        Description = category.Description
                    };
            }
                return null;
        }

        public static void UpdateCategory(int? id, Category category)
        {
            if (id != category.Id) 
                return;
            
            var categoryToChange = _categories.FirstOrDefault(x => x.Id == id);
            if (categoryToChange != null)
            {
                categoryToChange.Id = category.Id;
                categoryToChange.Name = category.Name;
                categoryToChange.Description = category.Description;
            }
        }

        public static void DeleteCategory(int id)
        {
            var categoryToDelete = _categories.FirstOrDefault(x => x.Id == id);
            if(categoryToDelete != null)
                _categories.Remove(categoryToDelete);
        }
    }
}
