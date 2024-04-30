using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de nomes:");
            int n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];

            for (int i = 0; i <= n; i++) { 
            Console.WriteLine("Digite o nome "+i+": ");
            nome[i] = Console.ReadLine();
            }

            for ( int i = 0; i <= n; i++)
            {
                Console.WriteLine("Nome " + i + ": " + nome[i]);
            }

            Console.ReadKey();
        }
    }
}
