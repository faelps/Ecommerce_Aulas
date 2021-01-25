using RafaelRoupasECalcados.Adm.Models;
using RafaelRoupasECalcados.Adm.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RafaelRoupasECalcados.Adm.Servicos.Factory
{
    public static class CategoriaFactory
    {
        internal static Categoria CriarCategoria(AdicionarOuEditarCategoriaViewModel categoria)
        {
            var result = new Categoria();
            result.CriarCategoria(categoria);
            return result;
        }
    }
}
