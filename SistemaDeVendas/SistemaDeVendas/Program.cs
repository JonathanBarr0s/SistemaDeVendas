using Microsoft.EntityFrameworkCore;
using SistemaDeVendas;
using SistemaDeVendas.Data;
using SistemaDeVendas.Services;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

var cultureInfo = new CultureInfo("pt-BR");
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

// Adiciona serviços MVC
builder.Services.AddControllersWithViews();

// Configura session
builder.Services.AddSession(options =>
{
	options.IdleTimeout = TimeSpan.FromMinutes(30);
	options.Cookie.HttpOnly = true;
	options.Cookie.IsEssential = true;
});

// Permite injeção de HttpContext em outros serviços
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<VendedorService>();

// Configura o banco de dados
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseSqlServer(connectionString));

var app = builder.Build();

// Configura pipeline
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Session precisa vir antes do middleware que depende dela
app.UseSession();

// Middleware de autenticação customizado
app.UseMiddleware<AutenticacaoMiddleware>();

// Authorization (se houver)
app.UseAuthorization();

// Roteamento padrão
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();