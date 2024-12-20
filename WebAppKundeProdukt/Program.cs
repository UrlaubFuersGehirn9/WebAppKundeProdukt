﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using WebAppKundeProdukt.Data;
namespace WebAppKundeProdukt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-EN"); 
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<WebAppKundeProduktContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("WebAppKundeProduktContext") ?? throw new InvalidOperationException("Connection string 'WebAppKundeProduktContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
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
