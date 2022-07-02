namespace Tarefa009.Domain
{
    public class Veterinario
    {
        public string Examinar(Animal animal) =>
            $"Após analisar o animal ele emitiu o seguinte som: {animal.EmitirSom()}";
    }
}
