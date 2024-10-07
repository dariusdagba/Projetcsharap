namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvaluationExamen Ex1=new EvaluationExamen(45);
            EvaluationExamen Ex2 = new EvaluationExamen(35);
            EvaluationExamen Ex3 = new EvaluationExamen(55);
            Ex3.CalculerMoyenne();
        }

        interface IEvaluation
        {
            void Noter(int note);
            void AfficherNote();
        }

        public abstract class Evaluation
        {
            public int note;
            public abstract void CalculerMoyenne();
            public Evaluation( int note){ this.note = note; }
        }

        public class EvaluationExamen:Evaluation
        {
            public static int nbexam = 0;
            public EvaluationExamen(int note):base(note) 
            {
                nbexam++;
            }
            public override void CalculerMoyenne()
            {
                int[] tab= new int[nbexam];

                int somme = 0;
                for(int i = 0; i < tab.Length; i++)
                {
                    somme += note;
                }
                double moyenne=somme/nbexam;
                Console.WriteLine("moyenne"+moyenne);
            }
        }
    }
}
