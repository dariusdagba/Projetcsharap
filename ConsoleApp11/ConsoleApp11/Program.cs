namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire C1 = new CompteBancaire("Darius", 12000);
            CompteBancaire C2 = new CompteBancaire("Don", 42000);
            CompteBancaire C3 = new CompteBancaire("Toliver", 42000);
            C1.Deposer(25000);
            C1.AfficherSolde();
            C1.Retirer(17900);
            C1.AfficherSolde();
            C1.Deposer(2000);
            C1.AfficherSolde();
            C1.Retirer(35000);
            C1.AfficherSolde();
            CompteBancaire.Verification(C1, C2);
            CompteBancaire.Verification(C2, C3);



        }

        public class CompteBancaire
        {
            private string Titulaire;
            private double Solde;

            public string getTitulaire()
            {
                return this.Titulaire;
            }
            public double getSolde()
            {
                return this.Solde;
            }

            public CompteBancaire(string Titulaire, double Solde)
            {
                this.Titulaire = Titulaire;
                this.Solde = Solde;
            }

            public void Deposer(double montant)
            {
                if (montant > 0)
                {
                    this.Solde += montant;
                }
                else
                {
                    Console.WriteLine("Veuillez saisir un montant positif");
                }
            }

            public void Retirer(double montant)
            {
                if (montant > this.Solde)
                {
                    Console.WriteLine(" Solde insuffisant");
                }
                else if (montant < 0)
                {
                    Console.WriteLine(" Veuillez saisir un montant positif");
                }
                else
                {
                    this.Solde -= montant;
                }
            }

            public void AfficherSolde()
            {
                Console.WriteLine("Le solde actuel est : " + this.Solde);
            }

            public static void Verification(CompteBancaire C1, CompteBancaire C2)
            {
                if (C1.Solde < C2.Solde)
                {
                    Console.WriteLine("Le propriétaire qui possède le solde le plus élevé est :" + C2.getTitulaire());
                }
                else if (C1.Solde > C2.Solde)
                {
                    Console.WriteLine("Le propriétaire qui possède le solde le plus élevé est :" + C1.getTitulaire());
                }
                else
                {
                    Console.WriteLine("Les deux comptes possèdent le même solde");
                }
            }
            public static CompteBancaire verification2(CompteBancaire C1, CompteBancaire C2)
            {
                if(C1.Solde < C2.Solde)
                {
                    return C2;
                }
                else if (C1.Solde > C2.Solde)
                {
                    return C1;
                }
                else
                {
                    return new CompteBancaire();
                }

            }
        }
    }
    }
