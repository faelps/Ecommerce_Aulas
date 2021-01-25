using RafaelRoupasECalcados.Adm.Models;
using RafaelRoupasECalcados.Adm.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RafaelRoupasECalcados.Adm.Servicos.Interface
{
    public interface ICatagoriaServico
    {
        Task<List<Categoria>> ObterTodasAsCategorias();
        void SalvarCategoria(AdicionarOuEditarCategoriaViewModel categoria);
    }
}
