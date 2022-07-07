namespace exercicio1.Ordenacao
{
    public class MergeSort
    {
        public void OrdeneLista(int[] listaDesordenada)
        {
            int index = 1;
            int start;
            int middle;
            int end;

            while (index < listaDesordenada.Length)
            {
                start = 0;
                while (start + index < listaDesordenada.Length)
                {
                    middle = start + index;
                    end = start + 2 * index;

                    if (end > listaDesordenada.Length)
                    {
                        end = listaDesordenada.Length;
                    }

                    Ordene(listaDesordenada, start, middle, end);
                    start = end;
                }
                index *= 2;
            }
        }

        private static void Ordene(int[] listaDesordenada, int start, int middle, int end)
        {
            int[] targetArray = new int[end - start];
            int i = start;
            int j = middle;
            int k = 0;

            while (i < middle && j < end)
            {
                if (listaDesordenada[i] <= listaDesordenada[j])
                {
                    targetArray[k] = listaDesordenada[i];
                    k++;
                    i++;

                }
                else
                {
                    targetArray[k] = listaDesordenada[j];
                    k++;
                    j++;
                }
            }
            while (i < middle)
            {
                targetArray[k] = listaDesordenada[i];
                k++;
                i++;
            }

            while (j < end)
            {
                targetArray[k] = listaDesordenada[j];
                k++;
                j++;
            }
            i = start;
            for (k = 0; i < end; k++)
            {
                listaDesordenada[i] = targetArray[k];
                i++;
            }
        }
    }
}

