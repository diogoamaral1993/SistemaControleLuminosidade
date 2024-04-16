using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SistemaControleLuminosidade.Controllers
{
    public class OcorrenciaController : Controller
    {
        public ActionResult PainelOcorrencia()
        {
            return View();
        }
    }
}
