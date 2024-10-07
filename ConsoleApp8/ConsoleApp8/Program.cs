using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //additionner deux matrices
             Console.WriteLine("Entrer la longueur du tableau");
             int l=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Entrer la largeur du tableau");
             int c=Convert.ToInt32(Console.ReadLine());
             int[,] Tab = new int[l, c];
             int[,] Tab2 = new int[l, c];
             int[,] Tab3 = new int[l, c];

             for(int i=0; i<l; i++)
             {
                 for (int j = 0; j < c; j++)
                 {
                     Console.WriteLine("Entrer les valeurs du tableau 1");
                     Tab[i,j]=Convert.ToInt32(Console.ReadLine());
                 }
             }

             for (int i = 0; i < l; i++)
             {
                 for (int j = 0; j < c; j++)
                 {
                     Console.WriteLine("Entrer les valeurs du tableau 2");
                     Tab2[i, j] = Convert.ToInt32(Console.ReadLine());
                 }
             }

             for (int i = 0; i < l; i++)
             {
                 for (int j = 0; j < c; j++)
                 {

                     Tab3[i, j] = Tab[i, j] + Tab2[i,j];
                 }
             }

             Console.WriteLine("Le tableau 3 est ");

             for (int i = 0; i < l; i++)
             {
                 for (int j = 0; j < c; j++)
                 {
                     Console.Write(Tab3[i,j]+" ");

                 }
             }
             Console.WriteLine();*/

            /*//calcul de la trace d'une matrice
            Console.WriteLine("Entrer la longueur du tableau");
            int lg=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer la largeur du tableau");
            int lr=Convert.ToInt32(Console.ReadLine());
            int[,] Tb=new int[lg,lr];

            for(int i = 0;i< lg; i++)
            {
                for (int j = 0; j < lr; j++)
                {
                    Console.WriteLine("Entrer la valeur "+j+" du tableau ");
                    Tb[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int som = 0;
            for (int i = 0; i < lg; i++)
            {
                som = som + Tb[i, i];
            }
            Console.WriteLine("la trace de la matrice est " + som);*/

            /*//matrice carrée en matrice triangulaire
            Console.WriteLine("Entrer la taille du tableau");
            int lo=Convert.ToInt32(Console.ReadLine());
            int[,]Ta=new int[lo,lo];
            int[,]T=new int[lo,lo];

            for (int i = 0; i < lo; i++)
            {
                for (int j = 0; j < lo; j++)
                {
                    Console.WriteLine("Entrer la valeur " + j + " du tableau");
                    Ta[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < lo; i++)
            {
                for (int j = 0; j < lo; j++)
                {
                    if (i > j)
                    {
                        T[i,j] = 0;
                    }
                    else
                    {
                        T[i,j] = Ta[i,j];
                    }
                }
            }

            Console.WriteLine("la matrice triangulaire est  ");
            for (int i = 0; i < lo; i++)
            {
                for (int j = 0; j < lo; j++)
                {
                    Console.Write(T[i,j]+" ");
                }
            }
            */

            /*//Matrice symétrique
            Console.WriteLine("Entrer la taille de la matrice");
            int w=Convert.ToInt32(Console.ReadLine());
            int[,]Tr=new int[w,w];
            bool rep = true;

            for(int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.WriteLine("Entrer la valeur " + j + " de la matrice");
                    Tr[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (Tr[i,j] != Tr[j, i])
                    {
                        rep = false; 
                        break;
                    } 
                }
            }
            if(rep)
            {
                Console.WriteLine("La matrice est symétrique");
            }
            else
            {
               Console.WriteLine("La matrice n'est pas symétrique");
            }*/


            /*//matrice d'identité
            Console.WriteLine("Entrer la taille de la matrice");
            int y=Convert.ToInt32(Console.ReadLine()); 
            int[,]Tg=new int[y,y];
            bool rep = true;
            for(int i=0; i < y; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("Entrer la valeur " + j + " de la matrice");
                    Tg[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if(i== j && Tg[i, j] != 1)
                    {
                        rep=false;break;
                    }
                    if (i != j && Tg[i, j] != 0)
                    {
                        rep = false; break;
                    }

                }
            }
            if(rep)
            {
                Console.WriteLine("La matrice est une matrice d'identité");
            }
            else
            {
                Console.WriteLine("La matrice n'est pas une matrice d'identité");
            }*/

            /*//multilication deux matrices
            Console.WriteLine("Entrer la longueur du tableau");
            int l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer la largeur du tableau");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer la longueur du tableau 2");
            int l2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer la largeur du tableau 2");
            int c2 = Convert.ToInt32(Console.ReadLine());
            if (c1 != l2)
            {
                Console.WriteLine("impossible de faire la multiplication ");
            }
            else
            {
                int[,] Tab = new int[l1, c1];
                int[,] Tab2 = new int[l2, c2];
                int[,] Tab3 = new int[l1, c2];

                for (int i = 0; i < l1; i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        Console.WriteLine("Entrer les valeurs du tableau 1");
                        Tab[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (int i = 0; i < l2; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        Console.WriteLine("Entrer les valeurs du tableau 2");
                        Tab2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (int i = 0; i < l1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        Tab3[i, j] =0;
                        for(int k = 0; k < c1; k++)
                        {
                            Tab3[i, j] = Tab[i, k] * Tab2[k, j];
                        }
                       
                    }
                }

                Console.WriteLine("Le tableau 3 est ");

                for (int i = 0; i < l1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        Console.Write(Tab3[i, j] + " ");

                    }
                }
                Console.WriteLine();

                
            }*/
            /*
            List<int> L1 = new List<int> { 12, 12, 45, 15 };
            List<int> L2 = new List<int>();

            L1.Add(10);
            L1.Remove(15);
            L2.Add(30); L2.Add(13); L2.Add(24); L2.Add(60); L2.Add(89); L2.Add(9);
            L1.RemoveRange(1,2);
            L2.AddRange(L1);
            L1.Sort();
            foreach (int i in L1) 
            { 
                Console.Write(i+" ");
            }
            Console.WriteLine();
            foreach (int i in L2)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            */
            int a=6; int b=5;
            Console.WriteLine(" avant a = " + a + " et b = " + b);
            permutation(ref a, ref b);
            Console.WriteLine(" Apres b = " + a + " et b = " + b);

            string mt = "67890";
            Inversion(mt);
            Console.WriteLine("Le mot inversé est "+Inversion(mt));
            
        }
        static int permutation(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            //Console.WriteLine(" c = " + a + " et d = " + b);
            //(a, b) = (b, a);
            return 0;
        }
        static string Inversion(string mt) 
        {
            if (mt.Length ==0) 
            {
                return mt;
            }
            else
            {
                return Inversion(mt.Substring(1)) + mt[0];
            }
        }


    }
   
}
