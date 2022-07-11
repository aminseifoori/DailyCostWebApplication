using System.Collections.Generic;

namespace DailyCostWebApplication.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        IEnumerable<Category> Delete(IEnumerable<int> DeleteList);
    }
}
