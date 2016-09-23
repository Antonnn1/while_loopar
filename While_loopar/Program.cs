using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             //Övn 1
             int i= 0; 
             while (i++<100)
             {
                 Console.WriteLine(i + " ");
             }
             */
            /*
           //Övn 2
           string inmatat = "";
           while (inmatat != "develooper")
           {
             Console.Write("Skriv in lösenord: ");
             inmatat = Console.ReadLine();
             if (inmatat == "develooper")
                 Console.WriteLine("Korrekt lösenord");
             else
                 Console.WriteLine("Inkorrekt lösenord");
           }
           */
            //Övn 3
            int i = 1;
            while (i++<=100)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
