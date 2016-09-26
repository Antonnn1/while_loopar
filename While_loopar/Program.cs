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
            /*
             //Övn 2.1
             int i = 1;
             while (i++<=100)
             {
                 Console.WriteLine(i);
             }
             Console.ReadLine();
             */
            /*
           //Övn 2.2
           int i = 10;
           while (i-->=1)
           {
               Console.WriteLine(i);
           }
           Console.ReadLine();
           */
            /*
             //Övn 2.3
             int i = 1;
             while (i==1)
             {
                 Console.WriteLine("Hej");
             }
             */

            //Övn 2.4
            int inmatat = 0;
            Random rnd = new Random();
            int tal = rnd.Next(100);
            int antalGånger = 0;
            while (inmatat != tal)
            {
                antalGånger++;
                Console.WriteLine("Gissa ett tal mellan 1 och 100: ");
                inmatat = int.Parse(Console.ReadLine());
                if (inmatat > tal)
                    Console.WriteLine("För högt!");
                else if (inmatat < tal)
                    Console.WriteLine("För lågt!");
                else
                    Console.WriteLine("Ja! det var " + tal + "." + " Det tog dig " + antalGånger + " gissningar!");
            }
        }
    }
}
