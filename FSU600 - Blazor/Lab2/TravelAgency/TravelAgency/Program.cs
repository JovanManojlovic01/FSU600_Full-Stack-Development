using Microsoft.EntityFrameworkCore;
using TravelAgency.Components;
using TravelAgency.Repositories;

namespace TravelAgency
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddRazorComponents().AddInteractiveServerComponents();
            builder.Services.AddDbContextFactory<AppDbContext>(options => options.UseSqlite("Data Source = TravelAgency.db"));
            builder.Services.AddScoped<DestinationRepository>();
            builder.Services.AddScoped<CustomerRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}