namespace GlitterBaum.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category {
                    Id= 1,
                    Name = "Ornaments",
                    Url = "ornaments"
               }
               );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Stranger Things Ornament",
                        Description = "",
                        ImgUrl = "Stranger-Things-Ornament.jpg",
                        Price = 9.99m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Chanel Ornament",
                        Description = "",
                        ImgUrl = "Chanel-Ornament.jpg",
                        Price = 8.99m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Tiffany & Co Ornament",
                        Description = "",
                        ImgUrl = "Tiffany-Ornament.jpg",
                        Price = 7.99m,
                        CategoryId = 1
                    }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
