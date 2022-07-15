using endereco.Enum;

namespace endereco.Domain
{
    /// <summary>
    /// Classe para representar a entidade Endereço
    /// Data: 15/07/2022
    /// Autor: Vitor Henrique Ferreira de Brito
    /// </summary>
    public class Endereco
    {
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public int CEP { get; set; }
        public Bairro? Bairro { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
        public Logradouro? Logradouro { get; set; }
    }
}
