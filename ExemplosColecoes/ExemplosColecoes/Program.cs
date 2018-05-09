using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosColecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<int> enumeracao = new List<int>() { 1, 2, 3, 4 };

            foreach (int x in enumeracao)
            {
                Console.WriteLine("O valor é: {0} ", x);
            }

            ICollection<int> colecao = new List<int>() { 4, 5, 3, 2, 1 };

            colecao.Add(8);
            //colecao[1] = 2;
            foreach (int x in colecao)
            {
                Console.WriteLine("O valor é: {0}", x);
            }

            IList<int> lista = new List<int> { 2, 3, 4, 1, 5 };
            lista.Add(8);
            lista[0] = 10;
            lista.Remove(4);
            foreach (int x in lista)
            {
                Console.WriteLine("O valor é: {0}", x);
            }

            IDictionary<String, float> notas = new Dictionary<String, float>();
            notas.Add("Anderson", 10f);
            notas.Add("Alex", 10f);
            notas.Add("João", 5.0f);

            Console.WriteLine("Qual a nota do João? {0}", notas["João"]);

            Console.ReadKey();
        }

        public static void Exercicio()
        {
            IList<int> listaDeValores = new List<int>();
            int x = 100;

            while(x-- > 0)
            {
                listaDeValores.Add((new Random()).Next());
            }

            for (int i=0; i < listaDeValores.Count(); i++)
            {
                int menor = listaDeValores[i];
                int indiceMenor = i;

                for(int j = i+1; j < listaDeValores.Count(); j++)
                {
                    if (listaDeValores[j] < menor)
                    {
                        menor = listaDeValores[j];
                        indiceMenor = j;
                    }
                }

                int aux = listaDeValores[i];
                listaDeValores[i] = menor;
                listaDeValores[indiceMenor] = aux;
            }



        }
    }
}
