namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("----------Compte simple-----------");
           CompteSimple CS=new CompteSimple(2000,"Darius Toliver",900);
           Console.WriteLine(CS.Afficher());
           CS.retrait(800);
           Console.WriteLine(CS.Afficher());
           Console.WriteLine("----------Compte épargne-----------");
           CompteEpargne CE = new CompteEpargne(2000,"Don silver", 5);
           Console.WriteLine(CE.Afficher());
           CE.CalulerInteret();
           Console.WriteLine(CE.Afficher());
           Console.WriteLine("----------Compte payant------------");
           ComptePayant CP1 = new ComptePayant(0, "Darius Toliver");
           ComptePayant CP2 = new ComptePayant(0, "Darius Toliver");
           CP1.deposer(100);
           CP2.deposer(400);
           Console.WriteLine(CP1.Afficher());
           Console.WriteLine(CP2.Afficher());
           CP1.retrait(54);
           CP2.retrait(100);
           Console.WriteLine(CP1.Afficher());
           Console.WriteLine(CP2.Afficher());


        }
    }

    public abstract class Compte
    {
        protected int code;
        protected double solde;
        protected string Titulaire;
        public static int nbcpt = 0;

        public Compte(double solde, string Titulaire)
        {
            this.code = ++nbcpt;
            this.solde = solde;
            this.Titulaire = Titulaire;
            
        }

        public int getCode() { return this.code; }
        public double getSolde(){ return this.solde;}

        public void setCode(int code) { this.code = code; }
        public void setSolde(double solde) { this.solde = solde; }

        public string getTitulaire() { return this.Titulaire; }
        public void  setTitulaire(string Titulaire) { this.Titulaire= Titulaire; }

        public void deposer(double montant)
        {
            if (montant > 0) { this.solde = montant; }
            else { Console.WriteLine("Montant insuffisant"); }
        }

        public void retrait(double montant)
        {
            if (montant <=solde) { this.solde -= montant; }
            else { Console.WriteLine("Solde insuffisant"); }
        }

        public virtual string Afficher()
        {
            return "Numero " + this.code + " Solde " + this.solde+" Titulaire "+this.Titulaire;
        }

    }

    public class CompteSimple : Compte
    {
        protected double decouvert;

        public CompteSimple( double solde,string Titulaire, double decouvert):base(solde,Titulaire)
        {
            this.decouvert = decouvert;
        }

        public double getDecouvert(){ return this.decouvert;}
        public void setDecouvert(double decouvert) { this.decouvert = decouvert; }

        public override string Afficher()
        {
            return base.Afficher()+" Decouvert "+this.decouvert;
        }

        public new void retrait(double montant )
        {
            if (montant <= solde + decouvert)
            {
                solde -= montant;
            }
            else 
            { 
                Console.WriteLine("Opération impossible"); 
            }
        }



    }

    public class CompteEpargne : Compte 
    {
        public double tauxInteret;

        public CompteEpargne( double solde, string Titulaire, double tauxInteret) : base(solde,Titulaire) 
        { 
            this.tauxInteret = tauxInteret;
        }

        public double getTauxInteret()
        {
            return this.tauxInteret;
        }

        public void setTauxInteret(double tauxInteret)
        {
            this.tauxInteret=tauxInteret;
        }

        public override string Afficher()
        {
            return base.Afficher()+" Taux d'intèrêt "+this.tauxInteret;
        }

        public void CalulerInteret()
        {
            this.solde += (solde*this.tauxInteret)/100;
        }


    }

    public class ComptePayant : Compte 
    {
        const double taux = 0.05;
        public ComptePayant(double solde,string Titulaire) : base( solde,Titulaire) { }

        public new void deposer(double montant)
        {
            double frais = montant * taux;
            if (montant > 0) 
            {
                this.solde += montant-frais;
            }
            else
            {
                Console.WriteLine("Montant insuffisant");
            }
        }

        public new void retrait(double montant)
        {
            double frais = montant * taux;
            if (solde >= (montant + frais))
            {
                this.solde -= montant + frais;
            }
            else 
            {
                Console.WriteLine("Solde insuffisant");
            }
        }

    }
}
