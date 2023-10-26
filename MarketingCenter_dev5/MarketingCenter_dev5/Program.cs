using MarketingCenterData;
using Microsoft.EntityFrameworkCore;
using MarketingCenterData.DataBaseContext;
using Serilog;
using MarketingCenter_dev5.DTI;


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

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {
                        policy.WithOrigins("*")
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });


            builder.Services.AddScoped<CategoryDti>();
            builder.Services.AddScoped<SubcategoryDti>();
            builder.Services.AddScoped<InteriorSubCategoryDti>();
            builder.Services.AddScoped<ContentPublish>();




            var app = builder.Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(app.Configuration)
                .CreateLogger();

            Log.Information("Starting up");


            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<McdbContext>();
                context.Database.SetCommandTimeout(6000000);

                if (!context.Database.CanConnect())
                {
                    context.Database.Migrate();
                }
            }


            // Configure the HTTP request pipeline.
            // if (app.Environment.IsDevelopment())
            // {
            app.UseSwagger();
            app.UseSwaggerUI();
            //  }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors();

            app.UseRouting();


            app.MapControllers();

            app.Run();

            Log.Information("End App Configuration");
        }






    }
}