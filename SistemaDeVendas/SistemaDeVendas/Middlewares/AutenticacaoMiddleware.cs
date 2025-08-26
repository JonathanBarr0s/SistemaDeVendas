using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;

public class AutenticacaoMiddleware
{
	private readonly RequestDelegate _next;

	public AutenticacaoMiddleware(RequestDelegate next)
	{
		_next = next;
	}

	public async Task InvokeAsync(HttpContext context)
	{
		var caminhosPermitidos = new[] { "/login", "/login/index", "/login/login", "/register" };
		var caminhoAtual = context.Request.Path.Value.ToLower();

		if (!caminhosPermitidos.Any(c => caminhoAtual.StartsWith(c)) &&
			string.IsNullOrEmpty(context.Session.GetString("VendedorNome")))
		{
			context.Response.Redirect("/Login");
			return;
		}

		await _next(context);
	}
}