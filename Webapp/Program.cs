using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Webapp.Data;
using Webapp.Models;
using Webapp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("LocalDB")));
builder.Services.AddScoped<UserService>();
builder.Services.AddIdentity<AppUser,IdentityRole>(x =>
    {
        x.Password.RequiredLength = 8;
        x.User.RequireUniqueEmail = true;
        x.SignIn.RequireConfirmedEmail = false;
    })
    .AddEntityFrameworkStores<DataContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(x => 
    {
        x.LoginPath = "/auth/signin";
        x.LogoutPath = "/auth/signout";
        x.AccessDeniedPath = "/auth/denied";
        x.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        x.SlidingExpiration = true;
    });

var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Login}/{id?}")
    .WithStaticAssets();

app.Run();
