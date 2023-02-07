using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using EvolutionLogic.Services.impl;
using EvolutionWebApp.ViewModels;
using EvolutionLogic.Models;
using EvolutionLogic.Services.interfaces;

namespace EvolutionWebApp.Controllers
{
    public class LoginController : Controller
    {
		private readonly IUsuarioServices _services;

		public LoginController(IUsuarioServices services)
		{
			this._services = services;
		}

		public IActionResult Login()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
			var usuario = await _services.GetAuthUsuario(model.User,model.Password);

            if (usuario is not null)
            {
                await SigIn(usuario);
                return Redirect("/Home/Index");
            }
			Console.WriteLine("Usuario no encontrado.");
            return View();
		}

		private async Task SigIn(Usuario usuario)
		{
			var claims = new List<Claim>();
			claims.Add(new Claim(ClaimTypes.NameIdentifier, usuario.NombreUsuario));
			claims.Add(new Claim(ClaimTypes.Name, usuario.Nombre));
			claims.Add(new Claim(ClaimTypes.Email, usuario.Email));
			var identityClaim = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
			var claimsPrincipal = new ClaimsPrincipal(identityClaim);
			var authProps = new AuthenticationProperties()
			{
				ExpiresUtc = DateTime.Now.AddMinutes(10)
			};
			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, authProps);
		}

		public IActionResult Register()
        {
            return View();
        }
    }
}
