namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var favSubject = Console.ReadLine().ToLower();

            switch (favSubject)
            {
                case "math":
                    Console.WriteLine($"{favSubject}? Nerd...");
                    break;
                case "science":
                    Console.WriteLine($"{favSubject}? Okay Einstein");
                    break;
                case "english":
                    Console.WriteLine($"{favSubject}? Snob");
                    break;
                case "history":
                    Console.WriteLine($"{favSubject}? Good for you");
                    break;
                case "philosophy":
                    Console.WriteLine($"{favSubject}? Alright Pluto");
                    break;
                default :
                    Console.WriteLine("What subject is that?");
                        break;




            }
        }
    }
}