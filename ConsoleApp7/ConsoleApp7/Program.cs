using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {    
           // Appel de la fonction Addition
            int resultat = Addition(3, 4);
            Console.WriteLine("Le résultat de l'addition est : " + resultat);
            // Appel de la fonction AfficherMessage
            AfficherMessage("Bonjour, monde !");

            // Appel de la fonction Addition
            int resultats = Additions(3, 4);
            Console.WriteLine("Le résultat de l'addition est : " + resultats);
            // Appel de la fonction AfficherMessage
            AfficherMessages("Bonjour, monde !");
            // Appel de la fonction Soustraction
            int difference = Soustraction(10, 5);
            Console.WriteLine("Le résultat de la soustraction est : " + difference);
            // Appel de la fonction Multiplication
            int produit = Multiplication(4, 5);
            Console.WriteLine("Le résultat de la multiplication est : " + produit);
            // Appel de la fonction Division
            double quotient = Division(20, 4);
            Console.WriteLine("Le résultat de la division est : " + quotient); 

            // Calcul de la factorielle
            int nombre = 5;
            int resultatFactorielle = Factorielle(nombre);
            Console.WriteLine($"La factorielle de {nombre} est : " + resultatFactorielle);

            // Vérification si un nombre est pair ou impair
            int nombr = 7;
            bool estPair = EstPair(nombr);
            Console.WriteLine($"{nombr} est pair ? : " + estPair);

            Console.WriteLine("Le carré de "+nombre+" est "+Carre(nombre));

            int celsu = 145;
            Console.WriteLine("La conversion du dégré celsus en dégré feh " + CelsiusEnFahrenheit(celsu));
            int[]Tab=new int[5];
            Tab[0] = 50; Tab[4] = 70; Tab[2] = 43; Tab[3] = 39; Tab[4] = 65;
            Console.WriteLine("Le maximum est "+TrouverMax(Tab));

        }
        // Fonction qui additionne deux nombres
        static int Addition(int a, int b)
        {
            return a + b;
        }
        // Fonction qui affiche un message
        static void AfficherMessage(string message)
        {
            Console.WriteLine(message);
        }
        static int Additions(int a, int b)
        {
            return a + b;
        }
        static void AfficherMessages(string message)
        {
            Console.WriteLine(message);
        }
        static int Soustraction(int a, int b)
        {
            return a - b;
        }
        static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static double Division(int a, int b)
        {
            if (b != 0)
            {
                return (double)a / b;
            }
            else
            {
                Console.WriteLine("Erreur : Division par zéro");
                return 0;
            }
        }
        public static int Factorielle(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorielle(n - 1);
            }
        }
        static bool EstPair(int n)
        {   
                return n % 2 == 0;
            
        }

        static int Carre(int nombre)
        {
            return nombre * nombre;
        }
        static double CelsiusEnFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static int TrouverMax(int[] tableau)
        {
            int max = tableau[0];
            for (int i=0; i<tableau.Length;i++)
            {
                if (tableau[i] > max)
                {
                    max = tableau[i];
                }
            }
            return max;
        }

    }
}
