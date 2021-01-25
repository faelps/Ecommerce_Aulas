using RafaelRoupasECalcados.Adm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RafaelRoupasECalcados.Adm.Repositorio.Interface
{
    public interface ICategoriaRepositorio
    {
        void Salvar(Categoria categoriaModel);
        Task<List<Categoria>> ObterCategorias();
    }
}
