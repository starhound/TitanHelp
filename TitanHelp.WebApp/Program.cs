
using Microsoft.EntityFrameworkCore;
using TitanHelp.EntityFramework.Data;
using TitanHelp.Services;

namespace TitanHelp.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // DI
            builder.Services.AddScoped<TicketService>();

            try
            {
                using (var db = new TicketContext())
                {
                    db.Database.EnsureCreated();
                    db.Database.Migrate();
                }
            }
            catch(Exception ex)
            {

            }
           

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}