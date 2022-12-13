using DataAccess.Repositories.Abstract;
using DataAccess.Repositories.Concrete;
using Business.Abstract;
using Business.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// IOC Container for Data Access
builder.Services.AddScoped<IColorDal,EfColorDal>();

// IOC Container for Business
builder.Services.AddScoped<IColorService,ColorManager>();

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
