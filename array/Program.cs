using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = { "João", "Pedro", "Maria" };

            Console.WriteLine("Digite um número de 0 a 2:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome Selecionado: "+ nome[i]);
            Console.ReadKey();
            






        }
    }
}
