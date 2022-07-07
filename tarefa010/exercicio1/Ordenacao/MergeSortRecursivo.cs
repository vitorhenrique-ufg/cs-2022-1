namespace exercicio1.Ordenacao
{
    public class MergeSortRecursivo
    {
        public List<int> OrdeneLista(List<int> listaDesordenada)
        {
            if (listaDesordenada.Count <= 1)
                return listaDesordenada;

            List<int> elementosAEsquerda = new();
            List<int> elementosADireita = new();

            int meio = listaDesordenada.Count / 2;
            for (int i = 0; i < meio; i++)
            {
                elementosAEsquerda.Add(listaDesordenada[i]);
            }
            for (int i = meio; i < listaDesordenada.Count; i++)
            {
                elementosADireita.Add(listaDesordenada[i]);
            }

            elementosAEsquerda = OrdeneLista(elementosAEsquerda);
            elementosADireita = OrdeneLista(elementosADireita);
            return Ordene(elementosAEsquerda, elementosADireita);
        }

        private static List<int> Ordene(List<int> elementosAEsquerda, List<int> elementosADireita)
        {
            List<int> resultado = new();

            while (elementosAEsquerda.Count > 0 || elementosADireita.Count > 0)
            {
                if (elementosAEsquerda.Count > 0 && elementosADireita.Count > 0)
                {
                    if (elementosAEsquerda.First() <= elementosADireita.First())
                    {
                        resultado.Add(elementosAEsquerda.First());
                        elementosAEsquerda.Remove(elementosAEsquerda.First());
                    }
                    else
                    {
                        resultado.Add(elementosADireita.First());
                        elementosADireita.Remove(elementosADireita.First());
                    }
                }
                else if (elementosAEsquerda.Count > 0)
                {
                    resultado.Add(elementosAEsquerda.First());
                    elementosAEsquerda.Remove(elementosAEsquerda.First());
                }
                else if (elementosADireita.Count > 0)
                {
                    resultado.Add(elementosADireita.First());

                    elementosADireita.Remove(elementosADireita.First());
                }
            }
            return resultado;
        }
    }
}