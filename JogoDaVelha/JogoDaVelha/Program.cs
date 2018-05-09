using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class Program
    {
        public static void Jogar(int [,] jogo, int turno)
        {
            Console.WriteLine("Qual coluna você quer jogar: ");
            int col = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual linha você quer jogar: ");
            int lin = int.Parse(Console.ReadLine());
            jogo[lin, col] = turno;
        }

        static void Main(string[] args)
        {
            int[,] jogo = new int[3, 3];
            int turno = 1;

            while (true)
            {
                Jogar(jogo, turno);
                ImprimirJogoDaVelha(jogo);
                turno = turno == 1 ? 2 : 1;
            }
            Console.ReadKey();
        }

        public static void ImprimirJogoDaVelha(int [,] jogo)
        {
            for (int i = 0; i < 3; i++)
            {
                ImprimirLinha(new int[] { jogo[i, 0], jogo[i, 1], jogo[i, 2] });

                if (i < 2)
                {
                    Console.WriteLine("------------");
                }
            }
        }

        public static void ImprimirLinha(int [] linha)
        {
            Console.WriteLine("   |   |   ");
            string pos0;
            string pos1;
            string pos2;

            if (linha[0] == 1) pos0 = "X";
            else if (linha[0] == 2) pos0 = "O";
            else pos0 = " ";
            if (linha[1] == 1) pos1 = "X";
            else if (linha[1] == 2) pos1 = "O";
            else pos1 = " ";
            if (linha[2] == 1) pos2 = "X";
            else if (linha[2] == 2) pos2 = "O";
            else pos2 = " ";

            Console.WriteLine (" {0} | {1} | {2} ", pos0, pos1, pos2);
            Console.WriteLine("   |   |   ");
        }
    }
}
