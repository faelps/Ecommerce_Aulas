using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RafaelRoupasECalcados.Adm.Models
{
    public class Categoria
    {
        public Categoria()
        {

        }
        public Categoria(int id, string nome, string imagem)
        {
            this.Id = id;
            this.Nome = nome;
            this.Imagem = imagem;
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Imagem { get; private set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
