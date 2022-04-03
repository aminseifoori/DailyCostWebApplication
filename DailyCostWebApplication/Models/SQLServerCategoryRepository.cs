using System.Collections.Generic;

namespace DailyCostWebApplication.Models
{
    public class SQLServerCategoryRepository : ICategoryRepository
    {
        private readonly WebAppDBContext webAppDBContext;

        public SQLServerCategoryRepository(WebAppDBContext _webAppDBContext)
        {
            webAppDBContext = _webAppDBContext;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return webAppDBContext.Categories;
        }
    }
}
