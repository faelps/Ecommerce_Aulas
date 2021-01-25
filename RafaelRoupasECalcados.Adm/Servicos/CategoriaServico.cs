using RafaelRoupasECalcados.Adm.Models;
using RafaelRoupasECalcados.Adm.Repositorio.Interface;
using RafaelRoupasECalcados.Adm.Servicos.Factory;
using RafaelRoupasECalcados.Adm.Servicos.Interface;
using RafaelRoupasECalcados.Adm.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RafaelRoupasECalcados.Adm.Servicos
{
    public class CategoriaServico : ICatagoriaServico
    {
        private readonly ICategoriaRepositorio categoriaRepositorio;
        public CategoriaServico(ICategoriaRepositorio categoriaRepositorio)
        {
            this.categoriaRepositorio = categoriaRepositorio;
        }
        public async Task<List<Categoria>> ObterTodasAsCategorias()
        {
            var retorno = await categoriaRepositorio.ObterCategorias();
            return retorno;
        }

        public void SalvarCategoria(AdicionarOuEditarCategoriaViewModel categoria)
        {
            var categoriaModel = CategoriaFactory.CriarCategoria(categoria);
            categoriaRepositorio.Salvar(categoriaModel);
            
        }
    }
}
