namespace exercicio2.Domain
{
    public class Mouse : Produto
    {
        public string? Tipo { get; set; }

        public Mouse(string descricao)
        {
            DescricaoProduto = descricao;
        }

        public override string Descricao => $"{DescricaoProduto} - {Tipo}";
    }
}
