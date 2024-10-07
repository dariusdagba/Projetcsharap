using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Exercice");
             Console.WriteLine(" ");
             Console.WriteLine("Entrer votre nom");
             string nom = Console.ReadLine();
             Console.WriteLine("Entrer votre prenom");
             string prenom = Console.ReadLine();
             Console.WriteLine("Entrer votre salaire");
             int R=Convert.ToInt32(Console.ReadLine());
             double T;
             if(R <= 30000)
             {
                 T= 0.1;
             }
             else if( R <= 100000 && R >= 30001)
             {
                 T = 0.12;
             }
             else
             {
                 T = 0.17;
             }

             Console.WriteLine("Entrer votre statut marital");
             string stat = Console.ReadLine();
             double M;
             if(stat == "Célibataire")
             {
                 Console.WriteLine("Entrer votre âge");
                 int age = Convert.ToInt32(Console.ReadLine());
                 if( age <= 40)
                 {
                     M = 0;
                 }
                 else
                 {
                     M = 0.1;
                 }
             }
             else if(stat == "Marié(e)")
             {
                 M = 0.03;
             }
             else
             {
                 Console.WriteLine("Entrer votre âge");
                 int ag = Convert.ToInt32(Console.ReadLine());
                 if(ag > 40)
                 {
                     M = 0.1;
                 }
                 else 
                 { 
                     M = 0.02; 
                 }
             }

             Console.WriteLine("Entrer le nombre d'enfants");
             int enf = Convert.ToInt32(Console.ReadLine());
             double E;
             if(enf >= 1)
             {
                E = enf * 0.02;
             }
             else 
             {
                 E = 0.05;
             }
             Console.WriteLine("Entrer votre genre");
             string ge = Console.ReadLine();
             double G;
             if(ge == "Homme")
             {
                 G = 0;
             }
             else if(ge == "Femme" && stat == "Célibataire")
             {
                 G = 0.02;
             }
             else
             {
                 G= 0;
             }

             double impot;
             impot = (T - M - E - G) * R;
             Console.WriteLine("Impôt = "+impot);
 */


            /*Console.WriteLine("Exercice1");
            Console.WriteLine(" ");
            Console.WriteLine("Entrer le nombre de jour de vacances");
            int nj = Convert.ToInt32(Console.ReadLine());
            int cout_par_jour;
            if (nj <= 3)
            {
                cout_par_jour = 100 * nj;
            }
            else if (nj >= 4 && nj <= 7)
            {
                cout_par_jour = 90 * nj;
            }
            else
            {
                cout_par_jour = 85 * nj;
            }
            Console.WriteLine("Entrer votre destination");
            string des = Console.ReadLine();
            double frais_de_destination;
            if (des == "Plage")
            {
                frais_de_destination = 0 * cout_par_jour;
            }
            else if (des == "Montagne")
            {
                frais_de_destination = 0.1 * cout_par_jour;
            }
            else if (des == "Ville internationale")
            {
                Console.WriteLine("Entrer le nombre d'enfants");
                int nb_enf = Convert.ToInt32(Console.ReadLine());
                if (nb_enf >= 1)
                {
                    frais_de_destination = 0.1 * cout_par_jour;
                }
                else
                {
                    frais_de_destination = 0.2 * cout_par_jour;
                }

            }
            else
            {
                frais_de_destination = 0;
            }
            Console.WriteLine("Entrer votre choix d'activités : Standard, Aventure, Détente");
            string act = Console.ReadLine();
            double prix_act;
            if (act == "Standard")
            {
                prix_act = 0 * cout_par_jour;
            }
            else if (act == "Aventure")
            {
                Console.WriteLine("Etes vous un homme ou une femme");
                string genre = Console.ReadLine();
                if (genre == "homme")
                {
                    prix_act = 0.3 * cout_par_jour;
                }
                else
                {
                    prix_act = 0.1 * cout_par_jour;
                }
            }
            else if (act == "Détente")
            {
                Console.WriteLine("Etes vous en couple ou seul(e)");
                string statut_marital = Console.ReadLine();
                if (statut_marital == "couple")
                {
                    prix_act = 0.2 * cout_par_jour;
                }
                else if (statut_marital == "seul" || statut_marital == "seule")
                {
                    prix_act = 0.3 * cout_par_jour;
                }
                else
                {
                    prix_act = 0;
                }
            }
            else
            {
                prix_act = 0;
            }
            double prixTotal;
            prixTotal = cout_par_jour + frais_de_destination + prix_act;

            Console.WriteLine("Prix total = " + prixTotal);*/

            /* Console.WriteLine("Exercice2");
             Console.WriteLine("Souhaiter vous faire un depôt, retrait, verifier votre solde ");
             string demandes = Console.ReadLine();
             int solde;
             solde = 0;
             if(demandes == "depot")
             {
                 Console.WriteLine("Combien voulez-vous déposer ?");
                 int dep=Convert.ToInt32(Console.ReadLine());
                 solde = solde + dep;
                 Console.WriteLine("Votre solde actuel après depot est de " + solde);
             }
             else if(demandes == "retrait")
             {
                 Console.WriteLine("Combien voulez-vous retirer ?");
                 int ret = Convert.ToInt32(Console.ReadLine());
                 if(ret > solde)
                 {
                     Console.WriteLine("Votre solde est insuffisant");
                 }
                 else
                 {
                     solde = solde - ret;
                     Console.WriteLine("Votre solde actuel après retrait est de " + solde);
                 }
             }
             else
             {
                 Console.WriteLine("Votre solde actuel est "+solde);
             }*/

            Console.WriteLine("Exercice3");
            Console.WriteLine("Entrer le nombre de billet");
            int nb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer votre type de scéance");
            string type_seance = Console.ReadLine();
            int cout_sceance;
            if (type_seance == "Standard")
            {
                Console.WriteLine("Etes vous un homme ou une femme");
                string gen = Console.ReadLine();
                if (gen == "femme")
                {
                    cout_sceance = nb * 6;
                }
                else
                {
                    cout_sceance = nb * 8;
                }
            }
            else if (type_seance == "3D")
            {
                Console.WriteLine("Etes vous seul ou en couple");
                string mar = Console.ReadLine();
                if (mar == "couple")
                {
                    cout_sceance = nb * 8;
                }
                else
                {
                    cout_sceance = (nb * 10);
                }
            }
            else if (type_seance == "IMAX")
            {
                Console.WriteLine("Etes vous membre ou non ?");
                string memb = Console.ReadLine();
                if (memb == "oui")
                {
                    cout_sceance = nb * 13;
                }
                else
                {
                    cout_sceance = (nb * 15);
                }

            }
            else
            {
                cout_sceance = 0;
            }
            Console.WriteLine("Combien de portion de  popocorn voulez-vous ?");
            int pop = Convert.ToInt32(Console.ReadLine());
            int cout_pop;
            if (pop == 1)
            {
                cout_pop = 5;
            }
            else
            {
                cout_pop = 4 * pop;
            }
            Console.WriteLine("Entrer le nombre de boisson");
            int nb_b = Convert.ToInt32(Console.ReadLine());
            int cout_boi;
            if (nb_b == 1)
            {
                cout_boi = 3;
            }
            else
            {
                cout_boi = 3 * nb_b - 1;
            }
            int cout_total;
            cout_total = cout_sceance + cout_pop + cout_boi;
            Console.WriteLine("Votre cout total est " + cout_total);

            /*Console.WriteLine("Exercice 4");
            double T;
            T = 0.25;
            Console.WriteLine("Entrer votre statut marital");
            string st_mari = Console.ReadLine();
            double reduc_mar;
            if (st_mari == "Célibataire")
            {

            }else if(st_mari =="Marié")
            {
                Console.WriteLine("Votre revenu est-il combiné ou séparé ? ");
                string rep=Console.ReadLine();
                
                if(rep == "comblé")
                {
                    reduc_mar = 0.03;
                }
                else
                {
                    reduc_mar = 0.02;
                }
            }
            else
            {
                Console.WriteLine("Combien d'enfants avew-vous ?");
                int nb_en=Convert.ToInt32(Console.ReadLine());
                if(nb_en >= 3)
                {
                  reduc_mar=0.06;
                }
                else if( nb_en >= 1 && nb_en < 3)
                {
                    reduc_mar=0.02*nb_en;
                }
                else
                {
                    reduc_mar = 0;
                }
            }
            Console.WriteLine("Etes vous un homme ou une femme");
            string g_enre=Console.ReadLine();
            if(g_enre == "femme")
            {

            }
*/
        }

    }
}
