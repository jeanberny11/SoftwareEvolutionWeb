using Microsoft.AspNetCore.Mvc;

namespace EvolutionWebApp.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult InfoClientes()
        {
            return View();
        }
    }
}
