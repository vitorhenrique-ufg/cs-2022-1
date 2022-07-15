namespace endereco.Domain
{
    /// <summary>
    /// Classe para representar a entidade Bairro
    /// Data: 15/07/2022
    /// Autor: Vitor Henrique Ferreira de Brito
    /// </summary>
    public class Bairro
    {
        public string? Nome { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
