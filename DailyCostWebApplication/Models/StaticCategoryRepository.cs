using System.Collections.Generic;

namespace DailyCostWebApplication.Models
{
    public class StaticCategoryRepository : ICategoryRepository
    {
        List<Category> _categories = new()
        {
            new Category { ID = 1, CategoryName = "Bill", Description = "Category for recording cost of bills", Active = CategoryActiveOptions.Yes },
            new Category { ID = 2, CategoryName = "Rent", Description = "Category for recording montly rental cost", Active = CategoryActiveOptions.Yes },
            new Category { ID = 3, CategoryName = "Petrol", Description = "Category for recording cost of petrol (Gas)", Active = CategoryActiveOptions.Yes }
        };

        public IEnumerable<Category> Delete(IEnumerable<int> DeleteList)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categories;
        }
    }
}
