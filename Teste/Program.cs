using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quilometragem:");
            int Km = int.Parse(Console.ReadLine());
            Console.Write("Digite de litros:");
            double Litros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Consumo = Km / Litros;

            var result = $"O consumo medio foi {Consumo:#.000}";

            Console.WriteLine(result);
            
            // teste
            //Console.WriteLine(Consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
} 