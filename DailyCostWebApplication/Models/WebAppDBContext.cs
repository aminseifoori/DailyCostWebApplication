using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Models
{
    public class WebAppDBContext : DbContext
    {
        public WebAppDBContext(DbContextOptions<WebAppDBContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cost> Costs { get; set; }
    }
}
