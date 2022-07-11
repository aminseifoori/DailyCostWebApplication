using System.Collections.Generic;
using System.Linq;

namespace DailyCostWebApplication.Models
{
    public class SQLServerCategoryRepository : ICategoryRepository
    {
        private readonly WebAppDBContext webAppDBContext;

        public SQLServerCategoryRepository(WebAppDBContext _webAppDBContext)
        {
            webAppDBContext = _webAppDBContext;
        }

        public IEnumerable<Category> Delete(IEnumerable<int> DeleteList)
        {
            try
            {
                var DeleteCatList = webAppDBContext.Categories.Where(z => DeleteList.Contains(z.ID)).ToList();
                webAppDBContext.Categories.RemoveRange(DeleteCatList);
                webAppDBContext.SaveChanges();
                return DeleteCatList;
            }
            catch
            {
                return null;
            }

        }

        public IEnumerable<Category> GetAllCategories()
        {
            return webAppDBContext.Categories;
        }
    }
}
