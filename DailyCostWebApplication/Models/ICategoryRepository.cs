using System.Collections.Generic;

namespace DailyCostWebApplication.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
