using DemoAppDotNet7.Data;
using DemoAppDotNet7.Data.Interceptors;
using DemoAppDotNet7.Repository;
using DemoAppDotNet7.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using DemoAppDotNet7.Models;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("https://jsoneditoronline.org/#left=local.voyise&right=local.yeqodi")
                                  .AllowAnyMethod()
                                  .AllowAnyHeader();
                      });
});
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("constr"))
                                                              .AddInterceptors(new SoftDeleteInterceptor())
                                                              );

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

//builder.Services.AddTransient(typeof(IRepository<>), typeof(MainRepository<>));

builder.Services.AddTransient<IEmailSender, CustomEmailSender>();
//using unit of work with repository patterns
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

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

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllerRoute(
    name: "area"
    , pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints => endpoints.MapRazorPages());
app.Run();
