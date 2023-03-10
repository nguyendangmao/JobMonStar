using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

namespace JobMonStar.Data
{
    public class DBJobContext:DbContext 
    {
        public DBJobContext(DbContextOptions<DBJobContext> options) : base(options) { }


        #region seddcategoris
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1 ,CategoryName="Work"},
                 new Category { CategoryId = 2, CategoryName = "Work" },
                  new Category { CategoryId = 3, CategoryName = "Family" },
                   new Category { CategoryId = 4, CategoryName = "Shool" },
                    new Category { CategoryId = 5, CategoryName = "Soccer" },
                   new Category { CategoryId = 6, CategoryName = "Ball" },
                   new Category { CategoryId = 7, CategoryName = "Hart" }

                );
        }
        #endregion

        #region DbSet
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Job>? Jobs { get; set; }
        public DbSet<User>? Users { get; set; }
        #endregion
    }
}
