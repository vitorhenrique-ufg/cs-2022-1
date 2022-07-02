using Tarefa009.Domain;

public static class AnimalTeste
{
    static Func<Type, Animal> FabricaDeAnimal => (tipoAnimal) => (Animal)Activator.CreateInstance(tipoAnimal)!;

    static void Main(string[] args)
    {
        Animal cachorro = (Cachorro)FabricaDeAnimal(typeof(Cachorro));
        Animal cavalo = (Cavalo)FabricaDeAnimal(typeof(Cavalo));
        Animal preguica = (Preguica)FabricaDeAnimal(typeof(Preguica));

        Console.WriteLine(@$"
O Primeiro animal emiti o som: {cachorro.EmitirSom()}
O Segundo animal emiti o som: {cavalo.EmitirSom()}
O Terceiro animal emiti o som: {preguica.EmitirSom()}");

        Veterinario veterinario = new();
        Console.WriteLine("------------------------------------------//-------------------------");
        Console.WriteLine(veterinario.Examinar(cachorro));
        Console.WriteLine(veterinario.Examinar(cavalo));
        Console.WriteLine(veterinario.Examinar(preguica));

        Zoologico zoologico = new();
        Animal animal1 = (Cachorro)FabricaDeAnimal(typeof(Cachorro));
        Animal animal2 = (Cachorro)FabricaDeAnimal(typeof(Cachorro));
        Animal animal3 = (Cachorro)FabricaDeAnimal(typeof(Cachorro));
        Animal animal4 = (Cachorro)FabricaDeAnimal(typeof(Cachorro));

        Animal animal5 = (Cavalo)FabricaDeAnimal(typeof(Cavalo));
        Animal animal6 = (Cavalo)FabricaDeAnimal(typeof(Cavalo));
        Animal animal7 = (Cavalo)FabricaDeAnimal(typeof(Cavalo));

        Animal animal8 = (Preguica)FabricaDeAnimal(typeof(Preguica));
        Animal animal9 = (Preguica)FabricaDeAnimal(typeof(Preguica));
        Animal animal10 = (Preguica)FabricaDeAnimal(typeof(Preguica));

        zoologico.Jaulas = new()
        {
            animal1,
            animal2,
            animal3,
            animal4,
            animal5,
            animal6,
            animal7,
            animal8,
            animal9,
            animal10,
        };
        Console.WriteLine("------------------------------------------//-------------------------");
        foreach(Animal animal in zoologico.Jaulas)
        {
            Console.WriteLine($"Som do animal: {animal.EmitirSom()}");
            if (animal is Cavalo || animal is Cachorro)
            {
                Console.WriteLine($"Comportamento do animal: {animal.AcaoDoAnimal()}");
            } 
        }
    }
}
