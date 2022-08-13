namespace tarefa019
{
    //[TODO]
    //Extract subclass é importante utilizar quando
    //sua classe principal tem métodos e campos para implementar um determinado caso de uso para a classe.
    //A classe é responsável por isso e seria errado mover todos os campos e métodos associados para uma classe totalmente separada.

    public static class Program
    {
        static void Main(string[] args)
        {
            //Antes da refatoracao
            Extract_Subclass.AntesRefatorar.Carro carroEletrico = new("Corolla hybrid", true);
            Extract_Subclass.AntesRefatorar.Carro carroGasolina = new("Gol g6", true);
            carroEletrico.Abasteca();
            carroGasolina.Abasteca();

            //Após a refatoracao
            Extract_Subclass.AposRefatorar.Carro carroRefatoradoEletrico = new Extract_Subclass.AposRefatorar.CarroEletrico("Corolla hybrid 2.0");
            Extract_Subclass.AposRefatorar.Carro carroRefatoradoEGasolina = new Extract_Subclass.AposRefatorar.CarroGasolina("Golf gti");

            carroRefatoradoEletrico.Abasteca();
            carroRefatoradoEGasolina.Abasteca();
        }
    }
}