using endereco.Domain;

namespace endereco.Interface
{
    /// <summary>
    /// Interface para referenciar a consulta por cep
    /// Data: 15/07/2022
    /// Autor: Vitor Henrique Ferreira de Brito
    /// </summary>
    public interface IEndereco
    {
        /// <summary>
        /// Método responável por consultar um endereço pelo CEP
        /// Data: 15/07/2022
        /// Autor: Vitor Henrique Ferreira de Brito
        /// </summary>
        public Endereco ConsultaPorCep();
    }
}
