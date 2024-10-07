namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Etudiant E1=new Etudiant("Toliver","Dario","ET001");
           Enseignant En1 = new Enseignant("Goidiola", "Paul", "EN001");
           E1.afficheInfo();
           En1.afficheInfo();
           
        }
    }

    public class Personne
    {
        public string nom;
        public string prenom;

        public string getNom() {  return nom; }   
        public string getPrenom() { return prenom; }

        public void setNom(string nom) { this.nom = nom; }
        public void setPrenom(string prenom) {  this.prenom = prenom;}

        public Personne(string nom, string prenom) 
        { 
            this.nom = nom;
            this.prenom = prenom;
        }

        public void afficheInfo()
        {
            Console.WriteLine(" Votre nom : "+this.nom+" Votre prenom :"+this.prenom);
        }
    }

    public class Etudiant : Personne
    {
        public string numEtud;

        public string getNumEtud() { return this.numEtud; }
        public void setNumEtud(string numEtud)
        {
            this.numEtud = numEtud;
        }

        public Etudiant(string nom, string prenom, string numEtud):base(nom, prenom)
        {
            this.numEtud = numEtud;
        }

        public new void afficheInfo()
        {
            base.afficheInfo();
            Console.WriteLine("Votre numéro étudiant : "+this.numEtud);
        }
    }

    public class Enseignant : Personne
    {
        public string grade;

        public string getGrade() {  return this.grade; }
        public void setGrade(string grade) {  this.grade = grade; }

        public Enseignant(string nom, string prenom,string grade):base(nom, prenom)
        {
            this.grade = grade;
        }

        public new void afficheInfo()
        {
            base.afficheInfo();
            Console.WriteLine("Votre grade : " + this.grade);
        }
    }
}
