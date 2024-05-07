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
            double[] altura = new double[5];
            int countob = 0;
            for (int i = 0; i<= 4; i++)
            {
                Console.WriteLine("Digite o nome:");
                nome[i]=Console.ReadLine();
                Console.WriteLine("Digite o peso:");
                peso[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura:");
                altura[i]=double.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Nome: "+nome[i]);
                Console.WriteLine("Peso: "+peso[i]);
                Console.WriteLine("Altura: "+altura[i]);
                Console.WriteLine("IMC: " + (peso[i] / (altura[i] * altura[i])) );
                if ((peso[i] / (altura[i] * altura[i])) <= 18.5) { Console.WriteLine("Abaixo do peso ideal");countob--; }
                else if ((peso[i] / (altura[i] * altura[i])) <= 24.9) { Console.WriteLine("Está no peso ideal");countob--; }
                else if ((peso[i] / (altura[i] * altura[i])) <= 29.9) { Console.WriteLine("Levemente acima do peso"); countob++; }
                else if ((peso[i] / (altura[i] * altura[i])) <= 34.9) { Console.WriteLine("Obesidade I"); countob++; }
                else if ((peso[i] / (altura[i] * altura[i])) <= 39.9) { Console.WriteLine("Obesidade II"); countob++; }
                else Console.WriteLine("Obesidade III"); countob++; 
            }
            Console.WriteLine("\n" +countob+" de 5 estão acima do peso");
            Console.ReadKey();
        
        
        
        
        }

    }
}
