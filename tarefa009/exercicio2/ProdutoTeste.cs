using exercicio2.Domain;

public static class ProdutoTeste
{
    static void Main(string[] args)
    {
        Produto produto1 = new Mouse("Mouse ótico, Saída USB. 1.600 dpi")
        {
            Tipo = "Mouse colorido"
        };
        Produto produto2 = new Mouse("Mouse gamer")
        {
            Tipo = "Mouse longtech"
        };
        Produto produto3 = new Mouse("Mouse sem fio")
        {
            Tipo = "Mouse razor"
        };

        Produto produto4 = new Livro("Livro 1")
        {
            Autor = "Monteiro Lobato"
        };
        Produto produto5 = new Livro("Livro 2")
        {
            Autor = "Vitor Henrique"
        };
        Produto produto6 = new Livro("Livro 3")
        {
            Autor = "Stephen Meyer"
        };

        List<Produto> carrinho = new()
        {
            produto1, produto2, produto3, produto4, produto5, produto6
        };

        Console.WriteLine("----------CARRINHO----------");
        int contador = 1;
        carrinho.ForEach((produto) =>
        {
            Console.WriteLine($"Produto {contador++}: {produto.Descricao}");
        });
    }
}
