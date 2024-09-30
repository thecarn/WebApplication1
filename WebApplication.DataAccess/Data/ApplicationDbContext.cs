using Microsoft.EntityFrameworkCore;
using WebApplication.Models.Models;

namespace WebApplication.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
    
        public DbSet<Category> Categories {  get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1},
                new Category { Id = 2, Name = "Scifi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Fortune of Time",
                        Author = "Billy Spark",
                        Description = "Praesent vitae sodales libero.",
                        ISBN = "SWD9999001",
                        ListPrice = 99,
                        Price = 90,
                        Price50 = 85,
                        Price100 = 80
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Mystery of the Old",
                        Author = "Nancy Weaver",
                        Description = "Curabitur aliquet quam id dui posuere blandit.",
                        ISBN = "SWD9999002",
                        ListPrice = 105,
                        Price = 95,
                        Price50 = 90,
                        Price100 = 85
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "The Final Frontier",
                        Author = "George R. R. Brown",
                        Description = "Sed porttitor lectus nibh.",
                        ISBN = "SWD9999003",
                        ListPrice = 120,
                        Price = 110,
                        Price50 = 105,
                        Price100 = 100
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "Secrets of the Universe",
                        Author = "Diana Prince",
                        Description = "Vivamus magna justo, lacinia eget consectetur sed.",
                        ISBN = "SWD9999004",
                        ListPrice = 115,
                        Price = 105,
                        Price50 = 100,
                        Price100 = 95
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "Adventures of Tomorrow",
                        Author = "Mark Twain",
                        Description = "Nulla porttitor accumsan tincidunt.",
                        ISBN = "SWD9999005",
                        ListPrice = 98,
                        Price = 88,
                        Price50 = 83,
                        Price100 = 78
                    },
                    new Product
                    {
                        Id = 6,
                        Title = "Legends of the Past",
                        Author = "Jane Austen",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        ISBN = "SWD9999006",
                        ListPrice = 125,
                        Price = 115,
                        Price50 = 110,
                        Price100 = 105
                    },
                    new Product
                    {
                        Id = 7,
                        Title = "Voyage to the Stars",
                        Author = "H.P. Lovecraft",
                        Description = "Vestibulum ac diam sit amet quam vehicula elementum.",
                        ISBN = "SWD9999007",
                        ListPrice = 135,
                        Price = 125,
                        Price50 = 120,
                        Price100 = 115
                    },
                    new Product
                    {
                        Id = 8,
                        Title = "Chronicles of the Unknown",
                        Author = "Isaac Asimov",
                        Description = "Donec sollicitudin molestie malesuada.",
                        ISBN = "SWD9999008",
                        ListPrice = 145,
                        Price = 135,
                        Price50 = 130,
                        Price100 = 125
                    },
                    new Product
                    {
                        Id = 9,
                        Title = "Echoes of Eternity",
                        Author = "Stephen King",
                        Description = "Vivamus suscipit tortor eget felis porttitor volutpat.",
                        ISBN = "SWD9999009",
                        ListPrice = 110,
                        Price = 100,
                        Price50 = 95,
                        Price100 = 90
                    },
                    new Product
                    {
                        Id = 10,
                        Title = "Winds of Fate",
                        Author = "J.K. Rowling",
                        Description = "Pellentesque in ipsum id orci porta dapibus.",
                        ISBN = "SWD9999010",
                        ListPrice = 130,
                        Price = 120,
                        Price50 = 115,
                        Price100 = 110
                    }
                );
        }

    }
}
