namespace basisprogrammering_quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter User name: ");
            string navn = Console.ReadLine();

            int score = 0;

            for (int i = 1; i <= 10; i++)
            {
                bool correct = false;

                while (!correct)
                {
                    Console.Write("Question " + i + ": What is " + i + " + " + i + "? ");
                    int svar = int.Parse(Console.ReadLine());
                    int facit = i + i;

                    if (svar == facit)
                    {
                        Console.WriteLine("Correkt!");
                        score++;
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! Try again");
                        score--;
                    }
                }
            }

            Console.WriteLine(navn + ", Your final score is: " + score);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
