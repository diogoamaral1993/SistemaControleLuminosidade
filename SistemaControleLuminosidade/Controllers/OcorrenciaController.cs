using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaControleLuminosidade.Repositore;

namespace SistemaControleLuminosidade.Controllers
{
    public class OcorrenciaController : Controller
    {
        public ActionResult PainelOcorrenciaAdmin()
        {
            OcorrenciaRepositore repositore = new OcorrenciaRepositore();
            return View(repositore.BuscarOcorrencias());
        }
    }
}
