using MergePractice.Context;
using MergePractice.Data.Interfaces;
using MergePractice.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PoSContext>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("PoS")));

builder.Services.AddScoped<IUsuarioRepository,UsuarioRepository>();
<<<<<<< HEAD
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IVentasRepository, VentasRepository>();
=======
builder.Services.AddScoped<ISuplidorRepository, SuplidorRepository>();

>>>>>>> origin/main
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
