using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercice 17*/
            /* for (int i = 0; i <=10; i++)
             {
                 Console.WriteLine("Bonjour");
             }*/

            /*Exercice 18*/
            /*  int som = 0;
             for (int i = 1; i <= 10; i++)
              {
                  som=som+i;
              }
              Console.WriteLine("La somme est "+som);*/

            /*Exercice 19*/
            /*  Console.WriteLine("Entrer un nombre entier ");
              int nbre=Convert.ToInt32(Console.ReadLine());
              int sm = 0;
              for (int i = 1; i <=nbre; i++)
              {
                  sm=sm+i;
              }
              Console.WriteLine("La somme est " + sm);*/

            /*Exercice 20*/
            /* int k = 5;
             for (int i = 1; i <= 12; i++)
             {
                 int result = k * i;
                 Console.WriteLine(k+ " * "+ i +" = "+result);
             }*/

            /*Exercice 21*/

            Console.Write("Entrer un nombre entier ");
            int nbr = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 12; i++)
            {
                int resul = nbr * i;
                Console.WriteLine(nbr + " * " + i + " = " + resul);
            }

            /*Exercice 22*/
            /* int i = 1;
             do
              { 
                  Console.WriteLine("Bonjour");
                  i++;
              }
              while (i<=10);*/
        }
    }
}
