namespace RafaelRoupasECalcados.Adm.Models
{
    public class DadosDoProduto
    {

        public DadosDoProduto()
        {

        }
        public DadosDoProduto(Produto produto, int quantidade, string cor, string tamanho, string paleta, bool disponivel)
        {
            this.Quantidade = quantidade;
            this.Cor = cor;
            this.Tamanho = tamanho;
            this.Paleta = paleta;
            this.Disponivel = disponivel;
            this.ProdutoId = produto.Id;
        }
        public int Id { get; private set; }
        public int Quantidade { get; private set; }
        public string Cor { get; private set; }
        public string Tamanho { get; private set; }
        public string Paleta { get; private set; }
        public string Imagem { get; private set; }
        public bool Disponivel { get; private set; }
        public int ProdutoId { get; private set; }
        public virtual Produto Produto { get; private set; }
    }
}