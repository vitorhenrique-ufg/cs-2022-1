namespace Extract_Class.AntesRefatorar
{
    public class Pessoa
    {
        private string nome;
        private string logradouro;
        private string bairro;
        private string cidade;

        public Pessoa(string nomePessoa)
        {
            nome = nomePessoa;
        }

        public void DefinaLogradouro(string logradouro)
        {
            this.logradouro = logradouro;
        }

        public void DefinaBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public void DefinaCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string ObtenhaEndereco() =>
            $"Endereço de {nome}\nLogradouro: {logradouro}\nBairro: {bairro}\nCidade: {cidade}";
    }
}
