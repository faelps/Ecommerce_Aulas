using RafaelRoupasECalcados.Adm.Models;
using RafaelRoupasECalcados.Adm.Models.Contexto;
using RafaelRoupasECalcados.Adm.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RafaelRoupasECalcados.Adm.Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly LojaContexto lojaContexto;
        public CategoriaRepositorio(LojaContexto lojaContexto)
        {
            this.lojaContexto = lojaContexto;
        }

        public async Task<List<Categoria>> ObterCategorias()
        {
            var retorno =  lojaContexto.Categorias.ToList();
            return retorno;
        }

        public void Salvar(Categoria categoria)
        {
            lojaContexto.Categorias.Add(categoria);
            lojaContexto.SaveChanges();
        }
    }
}
