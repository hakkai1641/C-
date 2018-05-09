using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sorteado = (new Random()).Next(10);
            int escolhido;

            do
            {
                Console.WriteLine("Qual o valor gerado?: ");
                escolhido = int.Parse(Console.ReadLine());
                
                if (escolhido > sorteado)
                {
                    Console.WriteLine("O número escolhido é maior que o sorteado!");
                }
                if(escolhido < sorteado)
                {
                    Console.WriteLine("O número escolhido é menor que o sorteado");
                }

            } while (sorteado != escolhido);
            Console.WriteLine("Parabéns, acertou mizeravi!!");
            Console.ReadKey();

            //formas de printar a variável:
            //Console.WriteLine("Parabéns, você acertou {0}. Você digitou {1}", sorteado, escolhido);
            //OU
            Console.WriteLine("Parabéns, você acertou! %d", sorteado);
        }
    }
}
