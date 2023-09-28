using Microsoft.EntityFrameworkCore;

namespace MarketingCenterData.DataBaseContext
{
    public class McdbContext : DbContext
    {

        public McdbContext(DbContextOptions<McdbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public McdbContext()
        {
        }

        public DbSet<Category>? Categories { get; set; }

        public DbSet<Subcategory>? Subcategories { get; set; }

        public DbSet<InteriorSubCategory>? InteriorSubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>(
                dbo =>
                {
                    dbo.ToTable("Category");
                });

            modelBuilder.Entity<Subcategory>(
                dbo =>
                {
                    dbo.ToTable("Subcategory");
                    dbo.HasKey(s => s.SubcategoryId);
                    dbo.HasOne(s => s.Category)
                        .WithMany()
                        .HasForeignKey(s => s.CategoryId);

                });


            modelBuilder.Entity<InteriorSubCategory>(
                dbo =>
                {
                    dbo.ToTable("InteriorSubCategory");

                    dbo.HasOne(s => s.Subcategory)
                        .WithMany()
                        .HasForeignKey(s => s.SubcategoryId);
                });
        }


    }
}