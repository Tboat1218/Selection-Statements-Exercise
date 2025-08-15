namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number");

            int userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Nevermind, you guessed it!");
            }
            Console.WriteLine("What's your favorite school subject?");
            string subject = Console.ReadLine().ToLower();

            switch (subject)
            {
                case "math":
                    Console.WriteLine("Math - the language of the universe!");
                    break;
                case"science":
                    Console.WriteLine("Science - where curiosity meets discovery!");
                    break;
                case "history":
                    Console.WriteLine("History — the best way to avoid past mistakes.");
                    break;
                case "english":
                    Console.WriteLine("English — unlocking the power of words.");
                    break;
                case "art":
                    Console.WriteLine("Art — creativity in its purest form.");
                    break;
                default:
                    Console.WriteLine("Interesting choice! That’s a great subject too.");
                    break;
                    
            }
            
                






        }
    }
}
