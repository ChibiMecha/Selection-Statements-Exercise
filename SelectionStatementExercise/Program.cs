namespace SelectionStatementExercise
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 10);
            int userInput;
            do
            {
                Console.WriteLine("Try to guess my favorite number 1-10");
                userInput = int.Parse(Console.ReadLine());
            
                if (userInput < favNumber)
                {
                Console.WriteLine("Too Low");
                }
                else if (userInput > favNumber)
                {
                Console.WriteLine("Too High");
                }
                else
                {
                Console.WriteLine("You guessed it!!!");
                }
            } while (userInput != favNumber);
        }
    }
}
