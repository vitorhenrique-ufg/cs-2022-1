namespace Extract_Class.AposRefatorar
{
    public class Pessoa
    {
        private string nome;
        private Endereco endereco;

        public Pessoa(string nomePessoa)
        {
            nome = nomePessoa;
        }

        public void DefinaEndereco(Endereco endereco) =>
            this.endereco = endereco;
        
        public string ObtenhaEndereco() =>
            $"Endereço de {nome}\n{endereco}";
    }
}
