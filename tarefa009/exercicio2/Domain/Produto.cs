namespace exercicio2.Domain
{
    public abstract class Produto
    {
        public string? NomeLoja { get; set; }

        public decimal Preco { get; set; }

        public virtual string? Descricao => "Produto de informática";

        public string? DescricaoProduto { get; set; }
    }
}
