namespace Encapsulate_Field.AposRefatorar
{
    public class Carro
    {
        private string nome;
        private string marca;
        private decimal preco;

        public string ObtenhaNome() => nome;

        public void DefinaNome(string nomeDefinido) => 
            nome = nomeDefinido;

        public string ObtenhaMarca() => marca;

        public void DefinaMarca(string marcaCarro) =>
            marca = marcaCarro;

        public decimal ObtenhaPreco() => preco;

        public void DefinaPreco(decimal precoAtualizado) =>
            preco = precoAtualizado;
    }
}
