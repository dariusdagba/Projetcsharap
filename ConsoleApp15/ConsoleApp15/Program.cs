using System.Numerics;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client CL1 = new Client(1, "Dario", "Toliver");
            Client CL2 = new Client(2, "Don", "Silver");
            Compte CP = new Compte(2000, CL1);
            CP.listClient.Add(CL1);
            CP.listClient.Add(CL2);
            CP.AfficherInfoCompte();
            foreach (Client c in CP.listClient) 
            {
                c.afficherInfoClient();
                
            }
        }

        public class Client
        {
            public int id;
            public string nom;
            public string prenom;
            public static int nbclient = 0;
            

            public Client(int id, string nom, string prenom)
            {
                this.id = id;
                this.nom = nom;
                this.prenom = prenom;
                nbclient++;
                
            }

            public void afficherInfoClient()
            {
                Console.WriteLine("Nom "+this.nom+" Prenom "+this.prenom);
            }

        }
        public class Compte
        {
            public int code;
            public double solde;
            public Client Titulaire;
            public static int nbcompte = 0;
            public List<Client> listClient;

            public Compte(double solde, Client Titulaire)
            {
                this.code = ++nbcompte;
                this.solde = solde;
                this.Titulaire = Titulaire;
                listClient = new List<Client>();
            }

            public void AfficherInfoCompte()
            {
                Console.WriteLine("Code " + this.code + " Titulaire " + Titulaire.nom + " " + Titulaire.prenom + " Solde " + this.solde);
            }

            public void setTitulaire(Client A)
            {
                this.Titulaire = A;
            }
        }
    }
}
