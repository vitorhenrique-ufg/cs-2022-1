namespace tarefa019
{
    public static class Program
    {
        //[TODO]
        //Extract interface permite isolar os comportamentos repetidos entre classes
        //Garantindo que as classes que implementam essas interfaces possam assinar um "contrato" 
        //de que forma elas querem que os metodos se comportem de formas diferentes

        static void Main(string[] args)
        {
            //Antes da refatoracao
            Extract_Interface.AntesRefatorar.ImpressoraNormal impressoraNormal = new("Impressora normal");
            impressoraNormal.Imprima();
            Extract_Interface.AntesRefatorar.ImpressoraLaser impressoraLaser = new("Impressora laser");
            impressoraLaser.Imprima();
            Extract_Interface.AntesRefatorar.Impressora3D impressora3D = new("Impressora 3D");
            impressora3D.Imprima();

            //Após a refatoracao
            Extract_Interface.AntesRefatorar.ImpressoraNormal impressoraNormalRefatorada = new("Impressora normal");
            impressoraNormalRefatorada.Imprima();
            Extract_Interface.AntesRefatorar.ImpressoraLaser impressoraLaserRefatorada = new("Impressora laser");
            impressoraLaserRefatorada.Imprima();
            Extract_Interface.AntesRefatorar.Impressora3D impressora3DRefatorada = new("Impressora 3D");
            impressora3DRefatorada.Imprima();
        }
    }
}