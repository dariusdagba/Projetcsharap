using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Choisissez le type de conversion : " +"\n1-Km vers Mi" + "\n2-Mi vers Km" + "\n3-M vers Yd" + "\n4-Yd vers M");
            string con=Console.ReadLine();
            double k,mi,m,yd;
            if (con == "1")
            {
                Console.WriteLine("Entrer la valeur en kilomètres ");
                k= Convert.ToDouble(Console.ReadLine());
                mi = 1.60934 * k;
                Console.WriteLine("La valeur en miles est : " + mi +" miles ");

            }
            else if (con == "2")
            {
                Console.WriteLine("Entrer la valeur en miles");
                mi = Convert.ToDouble(Console.ReadLine());
                k = 0.621371 * mi;
                Console.WriteLine("La valeur en miles est : " + k +" kilomètres");

            }
            else if (con == "3")
            {
                Console.WriteLine("Entrer la valeur en mètres");
                m = Convert.ToDouble(Console.ReadLine());
                yd = 0.9144 * m;
                Console.WriteLine("La valeur en miles est : " + yd +" yards ");

            }
            else if (con == "4")
            {
                Console.WriteLine("Entrer la valeur en yards ");
                yd = Convert.ToDouble(Console.ReadLine());
                m = 1.09361 * yd;
                Console.WriteLine("La valeur en miles est : " + m +" mètres ");

            }
            else
            {
                Console.WriteLine("Error -con");
            }*/
            Console.WriteLine("Choisissez le type de conversion : " + "\n1-Ml vers Cup" + "\n2-Cup vers Ml" + "\n3-Tbsp vers Oz" + "\n4-Oz vers Tbsp");
            string con = Console.ReadLine();
            double cup, ml,tbsp, oz;
            if (con == "1")
            {
                Console.WriteLine("Entrer la valeur en ml ");
                ml = Convert.ToDouble(Console.ReadLine());
                cup = 240 * ml;
                Console.WriteLine("La valeur en miles est : " + cup + " tasses");

            }
            else if (con == "2")
            {
                Console.WriteLine("Entrer la valeur en tasses");
                cup = Convert.ToDouble(Console.ReadLine());
                ml = 0.00422675 * cup;
               
                Console.WriteLine("La valeur en miles est : " + ml + " millilitres ");

            }
            else if (con == "3")
            {
                Console.WriteLine("Entrer la valeur en mètres");
                tbsp = Convert.ToDouble(Console.ReadLine());
                oz = 2 * tbsp;
                Console.WriteLine("La valeur en miles est : " + oz + " ondes liquides");

            }
            else if (con == "4")
            {
                Console.WriteLine("Entrer la valeur en yards ");
                oz = Convert.ToDouble(Console.ReadLine());
                tbsp = 0.5 * oz;
                Console.WriteLine("La valeur en miles est : " + tbsp + " cuillères à soupes ");

            }
            else
            {
                Console.WriteLine("Error -con");
            }

        }
    }
}
