using Generics;

namespace Tarefa016
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Concessionaria<Carro> concessionaria = new();
            concessionaria.FabriqueCarro<Creta>();
            concessionaria.FabriqueCarro<Corolla>();
            concessionaria.FabriqueCarro<Golf>();

            concessionaria.PubliqueAnuncios();
        }
    }
}

