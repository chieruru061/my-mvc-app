using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SampleMVCApp.Data;
using SampleMVCApp.Models;

// Hallo World
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MvcMovieContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MvcMovieContext") ?? throw new InvalidOperationException("Connection string 'MvcMovieContext' not found.")));

var mvcBuilder = builder.Services.AddControllersWithViews();
if (builder.Environment.IsDevelopment())
{
    mvcBuilder.AddRazorRuntimeCompilation();
}

// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

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
    // 一番目のURLセグメントでは、実行するコントローラークラスが決定される。 localhost:0000/HelloWorld -> HelloWorldController
    // URL セグメントの 2 番目の部分では、クラスのアクション メソッドが決定される。 指定しない場合は、indexメソッドが設定される。　localhost:5001/HelloWorld/Index
    // 3番目のセグメントはメソッドの引数がパラメータとして設定される。
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
