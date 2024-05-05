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

        public string FazerLogin(string usuario, string senha)
        {
            try
            {
                UsuarioRepositore repositore = new UsuarioRepositore();
                var login = repositore.FazerLogin(usuario, senha);
                if (login != null && login.tipo_usuario == "admin")
                {
                    return "admin";
                }
                else if (login != null && login.tipo_usuario == "normal")
                {
                    return "normal";
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }
    }
}
