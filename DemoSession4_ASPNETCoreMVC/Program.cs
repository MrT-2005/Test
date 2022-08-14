using DemoSession4_ASPNETCoreMVC.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<DemoService, DemoServiceImpl>();
builder.Services.AddScoped<CalculateService, CalculateServiceImpl>();
builder.Services.AddScoped<RectangleService, RectangleServiceImpl>();
builder.Services.AddScoped<InvoiceService, InvoiceServiceImpl>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");

app.Run();
