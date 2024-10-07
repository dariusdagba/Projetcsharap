using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Entrer le coté du carré");
            int c;
            c = Convert.ToInt32(Console.ReadLine());
            int s;
            
            s = c * c;
            int p;
            p = c * 4;
            int d;
            d = p / 2;
            Console.WriteLine("La surface du carré de coté " + c + " est : " + s);
            Console.WriteLine("Le périmêtre du carré de coté " + c + " est : " + p);
            Console.WriteLine("Le demi périmêtre du carré de coté " + c + " est : " + d);
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Entrer la longueur du rectangle");
            int Long;
            Long = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer la largeur du rectangle");
            int lar;
            lar = Convert.ToInt32(Console.ReadLine());
            int sur;
            sur = Long * lar;
            int dp;
            dp = Long + lar;
            int per;
            per = dp * 2;
            

            Console.WriteLine("La surface du rectangle de long " + Long + " et de largeur " + lar + "  est : " + sur);
            Console.WriteLine("Le demi périmêtre du rectangle de long " + Long + " et de largeur " + lar + "  est : " + dp);
            Console.WriteLine("Le périmêtre du rectangle de long " + Long + " et de largeur " + lar + "  est : " + per);
            */


            /*Console.WriteLine("Exo 1");
            Console.WriteLine("");
            Console.WriteLine("Entrer X ");
            int x;
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrer Y ");
            int y;
            y = Convert.ToInt32(Console.ReadLine());
            bool resultat;
            resultat = (x != y)&&(x > 5);
            Console.WriteLine("Le resultat est " + resultat);*/

            /*  Console.WriteLine("Exo 2");
              Console.WriteLine("");
              Console.WriteLine("Entrer c ");
              int c;
              c = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Entrer d ");
              int d;
              d = Convert.ToInt32(Console.ReadLine());
              bool res;
              res = !(c >= 3) || (d < 2);
              Console.WriteLine("Le resultat est " + res);*/


            /* Console.WriteLine("Exo 3");
             Console.WriteLine("");
             Console.WriteLine("Entrer a");
             int a;
             a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Entrer b");
             int b;
             b = Convert.ToInt32(Console.ReadLine());
             bool resul;
             resul = (a <= b) || !(b != 10);
             Console.WriteLine("Le resultat est " + resul);*/



            /*  Console.WriteLine("Exo 5");
              Console.WriteLine("");
              Console.WriteLine("Entrer e ");
              int e;
              e = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Entrer f");
              int f;
              f = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Entrer g ");
              int g;
              g = Convert.ToInt32(Console.ReadLine());
              bool result;
              result = !(e == f) && (f > g) || (e < 10);
              Console.WriteLine("Le resultat est " + result);
  */

            Console.WriteLine("Veillez saisir le nom de l'étudiant");
            string nom;
            nom = Console.ReadLine();
            Console.WriteLine("Veuillez saisir le prenom de l'étudiant ");
            string prenom;
            prenom = Console.ReadLine();
            Console.WriteLine("Veuillez saisir la date de naissance de l'étudiant ");
            string date_naissance;
            date_naissance = Console.ReadLine();
            Console.WriteLine("Veillez saisir la note de maths de l'étudiant");
            double maths;
            maths =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Veillez saisir le coefficient de maths de l'étudiant");
            double coef_math;
            coef_math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Veillez saisir la note de preparation de poste de l'étudiant");
            double ppost;
            ppost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Veillez saisir le coefficient de preparation de poste de l'étudiant");
            double coef_ppost;
            coef_ppost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Veillez saisir la note de HTML de l'étudiant");
            double html_css;
            html_css = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Veillez saisir le coefficient de HTML de l'étudiant");
            double coef_html;
            coef_html = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Veillez saisir la note de Logique de programmation de l'étudiant");
            double logp;
            logp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Veillez saisir le coefficient de Logique de programmation de l'étudiant");
            double coef_logp;
            coef_logp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Veillez saisir la note de Algorithme de programmation de l'étudiant");
            double algop;
            algop = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Veillez saisir le coefficient de Algorithme de programmation de l'étudiant");
            double coef_algop;
            coef_algop = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Veillez saisir la note de Linux de l'étudiant");
            double linux;
            linux = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Veillez saisir le coefficient de Linux de l'étudiant");
            double coef_linux;
            coef_linux = Convert.ToDouble(Console.ReadLine());

            double moyenne;
           /* moyenne = (maths * coef_math + ppost * coef_ppost + html_css * coef_html + logp * coef_logp + algop * coef_algop + linux * coef_linux) / 6;*/
            moyenne = (maths * coef_math + ppost * coef_ppost + html_css * coef_html + logp * coef_logp + algop * coef_algop + linux * coef_linux);
            if (moyenne > 60)
            {
                Console.WriteLine("Bravo,"+ nom + " " + prenom + " vous avez reussi");

                Console.WriteLine("La moyenne générale de l'etudiant " + nom + " " + prenom + " est " + moyenne);
            }
            /*else
            {
                Console.WriteLine("Malheusement," + nom + " " + prenom + " vous avez echoué");
            }*/
        }
    }
}
