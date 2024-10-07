namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client CL1 = new Client(1,"Dario","Toliver");
            Client CL2 = new Client(2, "Don", "Silver");
            Compte CP = new Compte(2000, CL1);
            Compte CP1 = new Compte(1350, CL1);
            Compte CP2 = new Compte(900, CL2);
            CP.AfficherInfoCompte();
            //CP.setTitulaire(CL2);
            CP.AfficherInfoCompte();
            CL1.listCompte.Add(CP);
            CL1.listCompte.Add(CP1);
            CL2.listCompte.Add(CP2);

            foreach(Compte x in CL1.listCompte)
            {
                x.AfficherInfoCompte();
            }

            foreach (Compte x in CL2.listCompte)
            {
                x.AfficherInfoCompte();
            }

        }

        public class Client
        {
            public int id;
            public string nom;
            public string prenom;
            public static int nbclient = 0;
            public List<Compte> listCompte;

            public Client(int id, string nom, string prenom)
            {
                this.id = id;
                this.nom = nom;
                this.prenom = prenom;
                nbclient++;
                listCompte= new List<Compte>();
            }


        }

        public class Compte
        {
            public int code;
            public double solde;
            public Client Titulaire;
            public static int nbcompte = 0;

            public Compte( double solde, Client Titulaire)
            {
                this.code=++nbcompte;
                this.solde = solde;
                this.Titulaire = Titulaire;
            }

            public void AfficherInfoCompte()
            {
                Console.WriteLine("Code " +this.code+" Titulaire "+Titulaire.nom+" "+Titulaire.prenom+" Solde "+this.solde);
            }

            public void setTitulaire(Client A)
            {
                this.Titulaire= A;
            }
        }
    }
}
