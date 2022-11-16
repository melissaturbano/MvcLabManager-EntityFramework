using Microsoft.EntityFrameworkCore;
using MvcLabManager.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Configurando para pedir instância com esse modelo
builder.Services.AddDbContext<LabManagerContext>(
    options => options.UseMySQL("server=localhost;database=estudante;user=melissa;password=15186631841")
   /* options => options.UseMySQL("server=localhost;database=estudante;user=estudante;password=estudante")*/
);

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
