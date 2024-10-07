using System.Security;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Animal A1 = new Animal();
           Animal A2 = new Animal("Rex",2,"Berger Allemand","Hichem");
            A1.Affiche();
            A2.Affiche();
            A1.setNom("Yoyo");
            A1.setSorte(2);
            A1.setRace("Berger Australien");
            A1.setProprietaire("Jérôme");
            A1.Affiche();

            Animal.Verification(A1,A2);

        }

        public class Animal
        {
            private string nom;
            private int sorte;
            private string race;
            private string proprietaire;


            public string getNom() { 
                return this.nom; 
            }
            public int getSorte()
            {
                return this.sorte;
            }
            public string getRace()
            {
                return this.race;
            }
            public string getProprietaire()
            {
                return this.proprietaire;
            }
            public void setNom(string nom)
            {
                this.nom = nom;
            }
            public void setSorte(int sorte)
            {
                this.sorte = sorte;
            }
            public void setRace(string race)
            {
                this.race = race;
            }
            public void setProprietaire(string proprietaire)
            {
                this.proprietaire = proprietaire;
            }

            public Animal()
            {
               this.nom = "";
               this.sorte = 0;
               this.race = "";
               this.proprietaire = "";

            }

            public Animal(string nom, int sorte, string race, string proprietaire)
            {
                
                this.nom = nom;
                this.sorte = sorte;
                

                this.race = race;
                this.proprietaire = proprietaire;
            }

            public void Affiche()

            {
                string r;
                if (this.sorte == 1)
                {
                    r = "Chat";
                }
                else if (this.sorte == 2)
                {
                    r = "Chien";
                }
                else
                {
                    r = "Inconnue";
                }
                Console.WriteLine("nom :"+this.nom+", sorte : "+r+", race :"+this.race+", propriétaire : "+this.proprietaire);
            }

            public static bool Verification(Animal A, Animal B)
            {
                if(B== null || A==null  || A.getProprietaire()==null || B.getProprietaire==null)
                {
                    return false;
                }
                else
                {
                    return Equals(A.getProprietaire(),B.getProprietaire());
                }
            }

        }
   

    
    }
}
