namespace tarefa019
{
    public static class Program
    {
        //[TODO]
        //Encapsulate Field é conceito ligado a capacidade de ocultar dados de objetos.
        //Caso contrário, todos os objetos seriam públicos e outros objetos poderiam obter e 
        //modificar os dados do seu objeto sem quaisquer verificações e contrapesos.

        static void Main(string[] args)
        {
            //Antes da refatoracao
            Encapsulate_Field.AntesRefatorar.Carro carroNaoRefatorado = new()
            {
                Nome = "Corolla",
                Marca = "Toyota",
                Preco = 180.500M
            };

            //Após a refatoracao
            Encapsulate_Field.AposRefatorar.Carro carroRefatorado = new();
            carroRefatorado.DefinaNome("BMW 320i");
            carroRefatorado.DefinaMarca("BMW");
            carroRefatorado.DefinaPreco(150.600M);
        }
    }
}