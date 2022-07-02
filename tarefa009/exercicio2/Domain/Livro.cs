namespace exercicio2.Domain
{
    public class Livro : Produto
    {
        public Livro(string descricao)
        {
            DescricaoProduto = descricao;
        }

        public string? Autor { get; set; }

        public override string Descricao => $"{DescricaoProduto} - {Autor}";
    }
}
