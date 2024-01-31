using DataAccess.Data;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Models.IdentityModels;
using Microsoft.EntityFrameworkCore;
using Web.Configurations;
using Microsoft.AspNetCore.Identity.UI.Services;
using Blaze.Configurations.MailJet;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<DataContext>().AddDefaultTokenProviders();

//builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("Stripe"));

builder.Services.ConfigureApplicationCookie(options => {
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
    
});
//builder.Services.AddAuthentication().AddFacebook(option => {
//    option.AppId = "193813826680436";
//    option.AppSecret = "8fc42ae3f4f2a4986143461d4e2da919";
//});
//builder.Services.AddAuthentication().AddMicrosoftAccount(option => {
//    option.ClientId = "ec4d380d-d631-465d-b473-1e26ee706331";
//    option.ClientSecret = "qMW8Q~LlEEZST~SDxDgcEVx_45LJQF2cQ_rEKcSQ";
//});

//builder.Services.AddDistributedMemoryCache();
//builder.Services.AddSession(options => {
//    options.IdleTimeout = TimeSpan.FromMinutes(100);
//    options.Cookie.HttpOnly = true;
//    options.Cookie.IsEssential = true;
//});

//builder.Services.AddScoped<IDbInitializer, DbInitializer>();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IEmailSender, MailJetEmailSender>();
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
//StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
//app.UseSession();
//SeedDatabase();
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{area=Visitor}/{controller=Home}/{action=Index}/{id?}");
app.Run();

//void SeedDatabase()
//{
//    using (var scope = app.Services.CreateScope())
//    {
//        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
//        dbInitializer.Initialize();
//    }
//}