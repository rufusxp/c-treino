
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
           // tabelinha das condições para ( && ) " e " 
            // TRUE && TRUE -> true 
            // FALSE  && FALSE -> false 
            // FALSE && TRUE -> false 
            // TRUE && FALSE -> false 

             // tabelinha das condições para ( || ) " OU " 
            // TRUE && TRUE -> true 
            // FALSE  && FALSE -> false 
            // FALSE && TRUE -> true 
            // TRUE && FALSE -> true 
            
            
            
            
           int a = 10 ;
           int b = 20 ;
           int c = 2 ;
 
            
            if (a > b || c < b ) 
            {
                Console.WriteLine("É VERDADE!! ");
            }
            else if (a < b)
            {
                Console.WriteLine(" pegou els if");
            }
            else
            {
                Console.WriteLine("É MENTIRA");
            }

            Console.ReadLine();


        }
    }
}
