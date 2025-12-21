using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Services;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

var cultureInfo = new CultureInfo("pt-BR");
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

builder.Services.AddControllersWithViews();

builder.Services.AddSession(options =>
{
	options.IdleTimeout = TimeSpan.FromMinutes(30);
	options.Cookie.HttpOnly = true;
	options.Cookie.IsEssential = true;
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<VendedorService>();

builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
	var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
	db.Database.Migrate();
}

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseMiddleware<AutenticacaoMiddleware>();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();