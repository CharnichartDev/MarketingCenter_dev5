using Microsoft.EntityFrameworkCore;

namespace MarketingCenterData.DataBaseContext
{
    public class MCDBContext : DbContext
    {

        public MCDBContext(DbContextOptions<MCDBContext> options)
            : base(options)
        {
        }

        public DbSet<TableA> TableAs { get; set; }

        public DbSet<TableB> TableBs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TableA>(
                dbo =>
                {
                    dbo.ToTable("TableA");
                });

            modelBuilder.Entity<TableB>(
                dbo =>
                {
                    dbo.ToTable("TableB");
                });


        }


    }
}