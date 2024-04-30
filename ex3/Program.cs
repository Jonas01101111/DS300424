using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            int[] peso = new int[5];
            int[] altura = new int[5];

            for (int i = 0; i<= 4; i++)
            {
                Console.WriteLine("Digite o nome:");
                nome[i]=Console.ReadLine();
                Console.WriteLine("Digite o peso:");
                peso[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura:");
                altura[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(nome[i]);
                Console.WriteLine(peso[i]);
                Console.WriteLine(altura[i]);

                if ((peso[i] / (altura[i] * altura[i])) < 18.5) { Console.WriteLine("Abaixo do peso ideal")}
                else if ((peso[i] / (altura[i] * altura[i])) < 24.9) { }
                else if ((peso[i] / (altura[i] * altura[i])) < 29.9) { }
                else if ((peso[i] / (altura[i] * altura[i])) < 34.9) { }
                else if ((peso[i] / (altura[i] * altura[i])) < 39.9) { }
                else { Console.WriteLine()}
            }

        }
    }
}
