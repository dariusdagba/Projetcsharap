using System.Diagnostics.Contracts;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe E1 = new Employe("Don","Toliver");
            Employe E2 = new Employe("Dan", "Sliver");
            Entreprise Ent1 = new Entreprise("Microsoft", "1212 rue des bourgeois");
            Entreprise Ent2 = new Entreprise("ZARA", "456 rue des vêtements");
            Departement D1 = new Departement("Infographie",Ent1);
            D1.EmployeList.Add(E1);
            D1.EmployeList.Add(E2);
            D1.AfficheDept();
            foreach(Employe E in D1.EmployeList)
            {
                E.AfficheInfo();
            }

        }

        public class Employe
        {
            public int code;
            public string Nom;
            public string Prenom;
            public static int nbemploye=0;

            public Employe( string Nom, string Prenom)
            {
                this.code = ++nbemploye;
                this.Nom = Nom;
                this.Prenom = Prenom;
            }

            public void AfficheInfo()
            {
                Console.WriteLine("Code : "+this.code+" Nom : "+this.Nom+" Prenom : "+this.Prenom);
            }
        }

        public class Departement
        {
            public int codeDept;
            public string Nom;
            public Entreprise entreprise;
            public List<Employe> EmployeList;
            public static int nbdept=0;

            public Departement(string Nom, Entreprise e )
            {
                this.codeDept = ++nbdept;
                this.Nom = Nom;
                this.entreprise = e;
                EmployeList = new List<Employe>();
            }

            public void setEntreprise( Entreprise entreprise )
            {
                this .entreprise = entreprise;
            }
            
            public void AfficheDept()
            {
                Console.WriteLine("Code : "+this.codeDept+" Nom : "+this.Nom);
            }
        }

        public class Entreprise
        {
            public int codeEntreprise;
            public string Nom;
            public string address;
            public List<Departement> DeptList;
            public static int nbEnt;

            public Entreprise(string Nom,String address)
            {
                this.codeEntreprise = ++nbEnt;
                this.Nom=Nom;
                this.address=address;
                DeptList= new List<Departement>();

            }
        }
    }
}
