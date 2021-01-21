using System.Collections.Generic;

namespace RafaelRoupasECalcados.Adm.Models
{
    public class Produto
    {
        public Produto()
        {

        }
        public Produto(int id, string nome, string descricao, decimal preco, string imagem, string codReferencia)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
            this.ImagemDestaque = imagem;
            this.CodDeReferencia = codReferencia;
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public string ImagemDestaque { get; private set; }
        public string CodDeReferencia { get; private set; }
        public bool Destaque { get; private set; }
        public ICollection<Categoria> Categorias { get; private set; }
        public virtual ICollection<DadosDoProduto> DadosDoProduto { get; private set; }

    }
}
