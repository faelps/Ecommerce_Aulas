using RafaelRoupasECalcados.Adm.Models;
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
        public Task<Categoria> ObterTodasAsCategorias()
        {
            throw new NotImplementedException();
        }

        public Task SalvarCategoria(AdicionarOuEditarCategoriaViewModel categoria)
        {
            throw new NotImplementedException();
        }
    }
}
