using Microsoft.EntityFrameworkCore;

namespace DailyCostWebApplication.Models
{
    public static class SeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    ID = 1,
                    CategoryName = "Bill",
                    Description = "This categoroy is assigned for recording Bill cost",
                    Active = CategoryActiveOptions.Yes
                },
                new Category
                {
                    ID = 2,
                    CategoryName = "Gerocery",
                    Description = "This categoroy is assigned for recording Gerocery cost",
                    Active = CategoryActiveOptions.Yes
                },
                new Category
                {
                    ID = 3,
                    CategoryName = "Rent",
                    Description = "This categoroy is assigned for recording Rental cost",
                    Active = CategoryActiveOptions.Yes
                }
            );
        }
    }
}
