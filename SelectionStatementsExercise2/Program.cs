namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FaveSubject();

        }

        public static void FaveSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();    

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I do not like Math");
                    break;

                case "science":
                    Console.WriteLine("Science is awesome!");
                    break;

                case "p.e.":
                case "pe":
                case "gym":
                    Console.WriteLine("Gym is alright");
                    break;
                case "history":
                    Console.WriteLine("History is my favorite!");
                    break;

                case "geography":
                    Console.WriteLine("Geography is boring");
                    break;

                default: Console.WriteLine("Nahhhh");
                    break;



            }
        }
    }
}