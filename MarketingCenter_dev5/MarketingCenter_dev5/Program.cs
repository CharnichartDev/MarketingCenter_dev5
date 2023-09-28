using MarketingCenterData;
using Microsoft.EntityFrameworkCore;
using MarketingCenterData.DataBaseContext;
using Serilog;


namespace MarketingCenter_dev5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            builder.Services.AddDbContext<McdbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            var app = builder.Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(app.Configuration)
                .CreateLogger();

            Log.Information("Starting up");

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<McdbContext>();
                    context.Database.SetCommandTimeout(6000000);
                    context.Database.Migrate();
                    SeedData(context);
            }

            

            // Configure the HTTP request pipeline.
            // if (app.Environment.IsDevelopment())
            // {
            app.UseSwagger();
            app.UseSwaggerUI();
            //  }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();

            Log.Information("End App Configuration");
        }


        static void SeedData(McdbContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.Add(new Category { CategoryName = "Marketing" });
                context.Categories.Add(new Category { CategoryName = "Products" });
                context.Categories.Add(new Category { CategoryName = "Interiors" });
                context.SaveChanges();
            }
        }



    }
}