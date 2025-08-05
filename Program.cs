using Equinox.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
<<<<<<< HEAD
//var dbPath = builder.Environment.IsDevelopment()
//? "Data Source=Equinox.db"
// : "Data Source=D:\\home\\data\\Equinox.db";
var dbPath = "Data Source=D:\\home\\data\\Equinox.db";
=======


>>>>>>> dc69ecd (Update project files)
builder.Services.AddDbContext<EquinoxContext>(options =>
    options.UseSqlite("Data Source=Equinox.db"));

builder.Services.AddControllersWithViews();
builder.Services.AddSession();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
