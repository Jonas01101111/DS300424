using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verdadeiro_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            int[] venda = new int[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Digite o nome do vendedor:");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite o valor da venda");
                venda[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
            }
            Console.Clear();
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Nome do vendedor: " + nome[i]);
                Console.WriteLine("Valor da venda: " + venda[i]);
                if (venda[i] <= 20000)
                {
                    Console.WriteLine("Comissão:" + venda[i] * 0.05);
                }
                else if (venda[i] <= 40000)
                {
                    Console.WriteLine("Comissão:" + venda[i] * 0.06);
                }
                else
                {
                    Console.WriteLine("Comissão:" + venda[i] * 0.07);
                }
                Console.WriteLine("\n");


            }
            Console.ReadKey();
        }
    }
}
