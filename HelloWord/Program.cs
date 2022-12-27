
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Digiti sua idade :");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança !");
            }

            else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é um adolecente !");
            }

            else if (idade >= 19 && idade <= 55)
            {
                Console.WriteLine("Você é um adulto !");
            }
            
            else if (idade >= 56 && idade <= 100)
            {
                Console.WriteLine("Você é um idoso(a) !");
            }
            else
            {
                Console.WriteLine("Coloque sua idade ");
            }
            
            Console.ReadLine();


        }
    }
}
