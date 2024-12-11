

using Microsoft.EntityFrameworkCore;
using ShopApp.Data.Entidades;

namespace ShopApp.Data.Context
{
    public partial class ShopContext: DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) 
        {

        }

        public DbSet<customers> Customers { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<products> Products { get; set; }
    }
}
