namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            Personne p2 = new Personne("Don", "Silver", 25);
            Personne p3 = new Personne("Donne", "Tilver", 14);
            Personne p4 = new Personne("Donne", "Tilver", 34);
            p1.afficher();
            p1.setNom("Don");
            Console.WriteLine("le nouveau est "+p1.getNom());
            p1.setNom("");
            p1.setAge(-12);
            p1.setPrenom("Ducaprio");
            p1.afficher();
            //._Age = -12;
            p1._Age = 20;
            p1.afficher();
            Console.WriteLine(Personne.compareAge(p1, p2));
            Personne.compareAges(p1, p4);
            Console.WriteLine(Personne.Compareage(p1, p4).getNom());



            /*p2.afficher();
            p3.afficher();*/
            Console.WriteLine("Le nombre de personne est " + Personne.nbrpersonne);
            
            

        }

        public struct Personne
        {
            private string Nom;
            private string prenom;
            private int age;
            public static int nbrpersonne=0;

            public Personne()
            {
                age = 10;
                Nom = "Dario";
                prenom = "Toliver";
                nbrpersonne++;
            }

            public Personne(string Nom, string prenom, int age)
            {
                if (age > 15) 
                {
                    this.age = age;
                    this.Nom = Nom;
                    this.prenom = prenom;
                     nbrpersonne++;

                }
                else
                {
                    Console.WriteLine("Veuillez saisir une age supérieur à 15");
                }
               
            }


            public int _Age
            {
                set
                {
                    if (age > 0)
                    {
                        this.age = value;
                    }
                    else
                    {
                        Console.WriteLine("Veuillez entrer un age supérieur à zero");
                    }
                }
                get {return this.age;}
            }
            public string getNom()
            {
                return this.Nom;
            }
            public void setNom(string Nom)
            {
                if (Nom == "")
                {
                    Console.WriteLine("Veuillez entrer un nom svp");
                }
                else
                {
                    this.Nom = Nom;
                }
            }
            public string getPrenom()
            {
                    return this.prenom;
            }
            public void setPrenom(string prenom)
            {
                if (prenom == "")
                {
                    Console.WriteLine("Veuillez entrer un prenom svp");
                }
                else
                {
                    this.prenom = prenom;
                }
            }
            public int getAge()
            {
                return this.age;
            }
            public void setAge(int age)
            {
                if(age > 0)
                {
                    this.age = age;
                }
                else 
                {
                    Console.WriteLine("Veuillez entrer un age supérieur à zero");
                }
                
            }

            public static string compareAge(Personne p1, Personne p2)
            {
                if (p1.getAge()>p2.getAge())
                {
                    return p1.getNom();
                }
                else if(p1.getAge() < p2.getAge())
                {
                    return p2.getNom();
                }
                else
                {
                    return "les deux ont le même age";
                }
            }
            public static void compareAges(Personne p1, Personne p2)
            {
                if (p1.getAge() > p2.getAge())
                {
                    Console.WriteLine("la personne le plus agée est "+ p1.getNom());
                }
                else if (p1.getAge() < p2.getAge())
                {
                    Console.WriteLine("la personne le plus agée est " + p2.getNom());
                }
                else
                {
                    Console.WriteLine("les deux ont le même age");
                }
            }
            public static Personne Compareage(Personne p1, Personne p2)
            {
                if (p1.getAge() > p2.getAge())
                {
                    return p1;
                }
                else
                {
                    return p2;
                }
                
            }
            public void afficher()
            {
                Console.WriteLine("Mon nom complet est : " + this.Nom + " " + this.prenom+" et mon age est "+this.age);
            }

        }
    }
}
