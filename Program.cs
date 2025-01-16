using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; // <-- Este using
using Microsoft.Extensions.Hosting;

using Microsoft.EntityFrameworkCore;
using VideoExplicativoAspNet.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar EF Core con SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Manejo de errores en Producción
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Rutas MVC por defecto
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Empleados}/{action=Index}/{id?}"
);

app.Run();
