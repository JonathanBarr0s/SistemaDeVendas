using Microsoft.AspNetCore.Http;
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
		var caminhosPermitidos = new[] { "/Login", "/Login/Index", "/Login/Login" };

		var caminhoAtual = context.Request.Path.Value;

		if (!caminhosPermitidos.Contains(caminhoAtual) &&
			string.IsNullOrEmpty(context.Session.GetString("VendedorNome")))
		{
			context.Response.Redirect("/Login");
			return;
		}
		await _next(context);
	}
}
