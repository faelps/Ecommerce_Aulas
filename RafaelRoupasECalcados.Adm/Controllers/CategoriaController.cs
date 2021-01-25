using Microsoft.AspNetCore.Mvc;
using RafaelRoupasECalcados.Adm.Models;
using RafaelRoupasECalcados.Adm.Servicos.Interface;
using RafaelRoupasECalcados.Adm.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RafaelRoupasECalcados.Adm.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICatagoriaServico catagoriaServico;
        public CategoriaController(ICatagoriaServico catagoriaServico)
        {
            this.catagoriaServico = catagoriaServico;
        }
        public async Task<IActionResult> Index()
        {
            var categorias = await catagoriaServico.ObterTodasAsCategorias();
            return View(categorias);
        }
        public async Task<IActionResult> AdicionarCategoria()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdicionarCategoria(AdicionarOuEditarCategoriaViewModel categoria)
        {
            catagoriaServico.SalvarCategoria(categoria);
            return RedirectToAction("Index");
        }
    }
}
