using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Digite o primeiro valor");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("O maior valor é: " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("O maior valor é: " + num2);
            }
            else
            {
                Console.WriteLine("O maior valor é: " + num3);
            }
        }
    }
}
