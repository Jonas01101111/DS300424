using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "JANEIRO", "FEVEREIRO", "MARÇO" ,"ABRIL" ,"MAIO" ,"JUNHO" ,"JULHO" ,"AGOSTO", "SETEMBRO" ,"OUTUBRO" ,"NOVEMBRO" ,"DEZEMBRO" };
            Console.WriteLine("Digite o número do mês(de 1 a 12):");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(meses[m-1]);
            Console.ReadKey();
        }
    }
}
