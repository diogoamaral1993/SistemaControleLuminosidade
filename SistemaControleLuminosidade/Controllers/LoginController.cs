using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaControleLuminosidade.Repositore;

namespace SistemaControleLuminosidade.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        public ActionResult Login()
        {
            return View();
        }

        public Boolean FazerLogin(string usuario, string senha)
        {
            UsuarioRepositore repositore = new UsuarioRepositore();
            if (repositore.FazerLogin(usuario, senha))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
