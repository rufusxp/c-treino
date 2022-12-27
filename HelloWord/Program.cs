
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
        {   
            GerarPreco(50);
            GerarPreco(40);
            GerarPreco(30);
            GerarPreco(-10);
            GerarPreco(-1000);
            GerarPreco(-10454);
            Console.ReadLine();

        }

        static void GerarPreco(int preco )
        {  
            int precoAbs = Math.Abs(preco);// Match.Abs converte o valor negativo para positivo automaticamente
            int valorFinal = precoAbs + (2 * precoAbs); 
            Console.WriteLine("Valor final é :" + valorFinal);
                

         }


    }
}
