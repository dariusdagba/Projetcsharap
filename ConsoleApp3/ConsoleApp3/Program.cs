using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Choisissez un snack parmis la liste de snacks : chips, barre chocolatée, fruit");
            string snak = Console.ReadLine();
            double arg,chang;
            int quan;
            if(snak == "chips")
            {
                Console.Write("Combien de snacks de "+snak+" voulez-vous ? ");
                quan = Convert.ToInt32(Console.ReadLine());
                Console.Write("Saisissez la quantité d'argent à insérer ");
                arg = Convert.ToDouble(Console.ReadLine());
                
                if (arg >=0.75 * quan) 
                {
                    chang = arg - 0.75 * quan;
                    Console.WriteLine("Le change est " + chang + " $");
                }
                else 
                {
                    chang = 0.75 * quan - arg;
                    Console.WriteLine("Vous devez complèter avec une somme de " + chang + " $ pour payer ce snack");
                }
            }
            else if (snak == "barre chocolatee")
            {
                Console.WriteLine("Combien de snacks de " + snak + " voulez-vous ? ");
                quan = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Saisissez la quantité d'argent à insérer : ");
                arg = Convert.ToDouble(Console.ReadLine());
                
                if (arg >= 1 * quan)
                {
                    chang = arg - 1 * quan;
                    Console.WriteLine("Le change est " + chang+ " $");
                }
                else
                {
                    chang = 1 * quan - arg;
                    Console.WriteLine("Vous devez complèter avec une somme de " + chang + " $ pour payer ce snack");
                }
            }
            else if (snak == "fruit")
            {
                Console.Write("Combien de snacks de "+snak+" voulez-vous ? ");
                quan = Convert.ToInt32(Console.ReadLine());
                Console.Write("Saisissez la quantité d'argent à insérer : ");
                arg = Convert.ToDouble(Console.ReadLine());
                
                if (arg >= 0.5*quan)
                {
                    chang = arg - 0.5 * quan;
                    Console.WriteLine("Le change est " + chang + " $");
                }
                else
                {
                    chang = 0.5 * quan - arg;
                    Console.WriteLine("Vous devez complèter avec une somme de " + chang + " $ pour payer ce snack");
                }
            }
            else 
            { 
                Console.WriteLine("Error -snack"); 
            }*/

            Console.WriteLine("Quelle conversion voulez-vous faire :" +"\n1- celsius à Fahrenheint " + "\n2- fahrenheint à celsius " + "\n3- celsius à Kelvin " + "\n4- Kelvin à Celsius" + "\n5- Fahrenheit à Kelvin" + "\n6- Kelvin à Fahrenheit");
            string con=Console.ReadLine();
            double c, k, f;
            if(con == "1")
            {
                Console.WriteLine("Entrer la valeur de celsus ");
                c=Convert.ToDouble(Console.ReadLine());
                k = c + 273.15;
                Console.WriteLine("La valeur en kelvin est "+k);

            }
            else if(con == "2") 
            {

            }
            else if(con == "3")
            {

            }
            else if(con == "4")
            {

            }
            else if (con == "5")
            {

            }
            else if (con=="6")
            {

            }
 
        }
    }
}
