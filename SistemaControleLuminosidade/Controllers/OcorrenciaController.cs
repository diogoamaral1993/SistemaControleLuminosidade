using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaControleLuminosidade.Models;
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

        public ActionResult CadastroOcorrencia()
        {
            return View();
        }

        public string CadastrarOcorrencia(string descricao)
        {
            tb_ocorrencia ocorrencia = new tb_ocorrencia();
            ocorrencia.descricao = descricao;
            ocorrencia.status_ocorrencia = "Aberta";
            ocorrencia.data_inclusao = DateTime.Now;
            OcorrenciaRepositore repositore = new OcorrenciaRepositore();
            repositore.CadastrarOcorrencia(ocorrencia);
            return "Ocorrencia cadastrada com sucesso";
        }
    }
}
