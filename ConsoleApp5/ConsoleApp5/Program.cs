using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Entrer un nombre entier");
             int a = Convert.ToInt32(Console.ReadLine());
             int b = 1;
             if (a < 0)
             {
                 Console.WriteLine("la valeur saisie n'est pas positif ");
             }
             else if (a == 0)
             {
                 b = 1;
                 Console.WriteLine("le factorielle du nombre " + a + " est :" + b);
             }
             else
             {
                 for (int i = 0; i <= a-1; i++)
                 {
                     b *= (a - i);

                 }
                 Console.WriteLine("le factorielle du nombre " + a + " est :" + b);
             }*/

            /* Console.WriteLine("Entrer le nombre d'affichage : ");
             int g = Convert.ToInt32(Console.ReadLine());

             for( int i=1; i<=g; i++)
             {
                 Console.WriteLine("Bonjour");
             }*/

            /* Console.WriteLine("Entrer le nombre de note à saisir : ");
             int tr = Convert.ToInt32(Console.ReadLine());
             int note;
             for (int i = 1; i <= tr; i++)
             {
                 Console.WriteLine("Entrer la note de l'étudiant numéro " + i);
                     note = Convert.ToInt32(Console.ReadLine());
                 if (note > 60)
                 {
                     Console.WriteLine(note);
                 }

             }*/

            /*Console.WriteLine("Les nombres impairs ")
            for (int i = 1; i <= tb; i++)
            {   if(i%2==1)
                {
                     Console.WriteLine(i);
                }

            }
            for (int i = 1; i <= tb; i++)
            {
                Console.WriteLine(i);
                
            }
            Console.WriteLine("Les nombres impairs ");
            for (int i = 1; i <= tb; i += 2)
            {
                Console.WriteLine(i);

            }
            
            Console.WriteLine("Les nombres pairs ");
            for (int i = 2; i <= tb; i+=2)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("Les nombres pairs ");
            for (int i = 1; i <= tb; i++)
            {   if(i%2==0)
                {
                     Console.WriteLine(i);
                }

            }

            Console.WriteLine("Les nombres impairs ")
            for (int i = 1; i <= tb; i++)
            {   if(i%2==1)
                {
                     Console.WriteLine(i);
                }

            }*/

            /* for (int i = 1; i <= 1000; i++)
             {
                 if (i % 2 == 1)
                 {
                     Console.WriteLine(i);
                 }

             }*/
            /* int somme = 0;
             for (int i = 1;i <= 1000; i++)
             {

                 somme = somme + i;
                 Console.WriteLine("La somme est " + somme);
             }*/
            /*Console.WriteLine("La somme est "+ somme);*/

            /* Console.WriteLine("Entrer le nombre de note à saisir : ");
             int tr = Convert.ToInt32(Console.ReadLine());
             int note,som=0;
             for (int i = 1; i <= tr; i++)
             {
                 Console.WriteLine("Entrer la note de l'étudiant numéro " + i);
                 note = Convert.ToInt32(Console.ReadLine());
                 som = som + note;
                 Console.WriteLine("la somme est " +som);

             }*/

            /*Console.WriteLine("Enter saisir le nombres de notes");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer le nombre des étudiants");
            int C = Convert.ToInt32(Console.ReadLine());
            int note,sm=0;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= C; j++)
                {
                    Console.WriteLine("saisir note de l'étudiant " + i);
                    note = Convert.ToInt32(Console.ReadLine());
                    if (note >= 0 && note <=100)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("saisir note de l'étudiant " + i + " compris entre 0-100");
                        note = Convert.ToInt32(Console.ReadLine());
                    }
                    sm = sm + note;
                    
                }
                Console.WriteLine("La somme est " + sm);

            }*/
            /*Console.WriteLine("Combien d'étudiant avez-vous en salle ? " );
            int sqd = Convert.ToInt32(Console.ReadLine());
            int note,som=0;
            double moy;
            for (int i = 1; i <= sqd; i++)
            {
                Console.Write("Saisir la note de l'étudiant "+i+" ");
                note = Convert.ToInt32(Console.ReadLine());
                som = som + note;
            }
            moy = som / sqd;
            Console.WriteLine("la somme est "+som);
            Console.WriteLine("La moyenne est "+moy);*/

            /* Console.Write("Voulez-vous commencer ? ");
             string rep = Console.ReadLine();

             while (rep == "oui")
             {
                 Console.Write("Saisir la note ");
                 int note = Convert.ToInt32(Console.ReadLine());
                 Console.Write("Voulez - vous ajouter une autre note ? ");
                 rep = Console.ReadLine();
             }*/


            /*Console.WriteLine("Entrer un nombre entier");
            int X = Convert.ToInt32(Console.ReadLine());
            while (X < 1 || X >10)
            {
                Console.WriteLine("Error, entrer un nombre entier compris entre 1-10");
                X = Convert.ToInt32(Console.ReadLine());
              
            }
            for (int i = 0; i <= 100; i++)
            {
                if (i % X == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Write("Entrer un nombre entier ");
            int Y= Convert.ToInt32(Console.ReadLine());
            while(Y < 1 || Y > 4)
            {
                Console.WriteLine("Error, entrer un nombre compris entre  ");
                Y = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <=100; i++)
            {
                if (Y)
                {

                }
            }
*/
            /*Exercice 1*/
            /*string rep;
            do
            {
                for (int i = 1000; i <= 2000; i++)
                {
                    if (i % 6 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Voulez-vous recommencer ?");
                 rep = Console.ReadLine();
            }
            while (rep == "oui");*/


            /*Exercice 2*/

            /* Console.WriteLine("Combien de nombre voulez - vous saisir ?");
             int nbr = Convert.ToInt32(Console.ReadLine());
             string rep;
             int som = 0, max = 0,min = 0,moy;
             do 
             { 
             for(int i = 1;i<= nbr; i++)
             {
                 Console.WriteLine("Entrez un nombre entier ");
                 int nbre = Convert.ToInt32(Console.ReadLine());
                 som=som+nbre;


                 if (nbre > max)
                 {
                     max= nbre;

                 }
                 min=nbre;
                 if(nbre < min)
                 {
                     min= nbre;
                 }

             }
             moy=som/nbr;
             Console.Write("la somme total est : "+som);
             Console.Write("le maximum est : "+ max);
             Console.Write("le minimum est : "+min);
             Console.Write("la moyemme est : "+moy);

                 Console.WriteLine("Voulez-vous recommencer ?");
                 rep = Console.ReadLine();
             }
             while (rep=="oui");*/

            /*Exercice 1*/

            /* string ID, password;
             Console.WriteLine("Entrer votre identifiant");
             ID = Console.ReadLine();
             Console.WriteLine("Entrer votre mot de passe");
             password = Console.ReadLine();

             while (ID != "Alexandre" || password != "dina2000") {
                 Console.WriteLine("Entrer votre identifiant");
                 ID = Console.ReadLine();
                 Console.WriteLine("Entrer votre mot de passe");
                 password = Console.ReadLine();

             }*/

            /*Exercice2*/
            /*int i = 400;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 1110);*/



            /* Console.WriteLine("Entrer la valeur initial R ");
             int R = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Entrer la valeur final N");
             int N = Convert.ToInt32(Console.ReadLine());
             for (int i=R; i<=N; i++)
             {
                 Console.WriteLine(i);
             }*/

            /* Console.WriteLine("Entrer la valeur final N ");
             int N=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Entrer la valeur P");
             int P = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Entrer la valeur F");
             int F = Convert.ToInt32(Console.ReadLine());
             int somme=0;
             for (int i=1; i<=N; i++)
             {
                 if (i%P==0 && i%F==0)
                 {
                     somme=somme+i;
                 }

             }
             Console.WriteLine("La somme est "+somme);*/

            /*  Console.WriteLine("Entrer le nombre de valeur");
              int nbre=Convert.ToInt32(Console.ReadLine());
              int i = 1;
              while (i<=nbre) 
              {

                  Console.WriteLine("Entrer la note");
                  int nb=Convert.ToInt32(Console.ReadLine());
                  i++;
              }*/

            /*  Console.WriteLine("Entrer la valeur final N");
              int N=Convert.ToInt32(Console.ReadLine());
              int max=0, min = 999999, somme=0;
              for (int i=1; i<=N;i++)
              {
                  int nbr=Convert.ToInt32(Console.ReadLine());    
                  while (nbr>100 || nbr<0)
                  {
                      Console.WriteLine("Error");
                      nbr = Convert.ToInt32(Console.ReadLine());

                      if (max < nbr)
                      {
                          max = nbr;
                      }

                      if (min > nbr)
                      {
                          min= nbr;
                      }
                      somme=somme+nbr;
                  }
              }
              Console.WriteLine("La somme est"+somme);
              Console.WriteLine("le minimum est"+min);
              Console.WriteLine("Le maximum est"+max);*/

            /* Console.WriteLine("Entrer la taille du tableau :");
             int tails = Convert.ToInt32(Console.ReadLine());
             int[] Tab = new int[tails];

             for (int i = 0; i < tails; i++)
             {
                 Tab[i]=Convert.ToInt32(Console.ReadLine());
             }
             int max = 0 ,min = 9999999;

             for(int i = 0;i < tails; i++)
             {
                 if (Tab[i] > max)
                 {
                     max = Tab[i];
                 }

                 if (Tab[i] < min)
                 {
                     min = Tab[i];
                 }
             }

             Console.WriteLine("Le maximum est "+max);
             Console.WriteLine("Le minimum est "+min);
             int cpt = 0;

             for(int i = 0;i<tails; i++)
             {
                 if (Tab[i]==5)
                 {
                     cpt++;
                 }

             }
             Console.WriteLine("il a saisi 5 "+cpt+" fois");
             */
        /*  string rep;
            int i = 0;
            do
            {
                Console.WriteLine("Entrer la valeur final N");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entrer un nombre de semaine");
                int S = Convert.ToInt32(Console.ReadLine());
                int[] dp = new int[S];
                while (S < 1 || S > N)
                {
                    Console.WriteLine("Valeur invalide ! veuillez entrer une valeur valide");
                    S = Convert.ToInt32(Console.ReadLine());
                }
                montant(dp, S);
                Console.WriteLine("Entrer la semaine pour laquelle vous voulez vérifier le solde");
                int nbr = Convert.ToInt32(Console.ReadLine());
                affichage(dp, nbr);
                totalEpagne(dp, S);
                moyenne(dp, S);
                maximum(dp, S);
                minimum(dp, S);
                supMontant(dp, S);
                depMontant(dp, S);

                Console.WriteLine("Voulez-vous recommencer ?");
                rep = Console.ReadLine();
                i++;
            }

            while (rep=="oui");





        }
        static int montant(int [] dep,int se)
        {
            for (int i = 0;i<se; i++)
            {
                Console.WriteLine("Entrer un montant");
                dep[i] = Convert.ToInt32(Console.ReadLine());
            }
            return 0;
        }
        static int affichage(int[] dep,int se)
        {
            int i=se;
            while(i==se)
            {  
                Console.WriteLine(dep[i-1]);
                i++;
            }
          
            return 0;
        }
        static int totalEpagne(int[] dep,int se)
        {
            int som=0;
            for(int i = 0; i < se; i++)
            { 
                 som = som + dep[i];
            }
            Console.WriteLine("Le total épargné est  "+som);
            return som;
        }
        static int totalEpagnes(int[] dep, int se)
        {
            int som = 0;
            for (int i = 0; i < se; i++)
            {
                som = som + dep[i];
            }
           
            return som;
        }

        static int moyenne(int[] dep,int se) 
        {
            
            int moy = totalEpagnes(dep,se) / se;
            Console.WriteLine("La moyenne est " + moy);
            return moy;

        }
        static int maximum(int[] dep,int se)
        {
            int max = 0;
            for (int i = 0; i < se; i++)
            {

                if (dep[i] > max)
                {
                    max = dep[i];
                }
            }
            Console.WriteLine("Le maximum est" + max);
            return max;

        }

        static int minimum(int[] dep, int se)
        {
            int min = 999999;
            for (int i = 0; i < se; i++)
            {

                if (dep[i] < min)
                {
                    min = dep[i];
                }
            }
            Console.WriteLine("Le minimum est" + min);
            return min;
        }
        
        static  int supMontant(int[] dep,int se)
        {
            int cpt= 0;
            for (int i = 0;i < se; i++)
            {
                if (dep[i]>30000)
                {
                    cpt++;
                }
            }
            Console.WriteLine("Elle a fait "+cpt+" fois un depot supérieur à 30k$");
            return 0;
        }

        static int depMontant(int[] dep,int se)
        {

            if (totalEpagnes(dep, se) >= 100000)
            {
                Console.WriteLine("Bravo vous avez atteint votre objectif de plus de 100000 dollars");
            }
            return 0;
        }*/


        // Appel de la fonction Addition
        int resultat = Addition(3, 4);
        Console.WriteLine("Le résultat de l'addition est : " + resultat);
        // Appel de la fonction AfficherMessage
        AfficherMessage("Bonjour, monde !");

            // Appel de la fonction Addition
            int resultat = Addition(3, 4);
            Console.WriteLine("Le résultat de l'addition est : " + resultat);
            // Appel de la fonction AfficherMessage
            AfficherMessage("Bonjour, monde !");
            // Appel de la fonction Soustraction
            int difference = Soustraction(10, 5);
            Console.WriteLine("Le résultat de la soustraction est : " + difference);
            // Appel de la fonction Multiplication
            int produit = Multiplication(4, 5);
            Console.WriteLine("Le résultat de la multiplication est : " + produit);
            // Appel de la fonction Division
            double quotient = Division(20, 4);
            Console.WriteLine("Le résultat de la division est : " + quotient);


        }
        static int Addition(int a, int b)
        {
            return a + b;
        }

        static void AfficherMessage(string message)
        {
            Console.WriteLine(message);
        }
        static int Addition(int a, int b)
        {
            return a + b;
        }
       /* public static void AfficherMessage(string message)
        {
            Console.WriteLine(message);
        }*/
        static int Soustraction(int a, int b)
        {
            return a - b;
        }
        static int Multiplication(int a, int b)
        {
            return a * b;
        }

    }
}
