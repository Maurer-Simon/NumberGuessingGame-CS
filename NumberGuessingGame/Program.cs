namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int point = 0;
            int guesses = 0;
            Console.WriteLine("Welcome to the Number Guessing Game!\nIf you want to start the game type 's', if you want to exit type 'e'.");
            string start = Console.ReadLine();
            if (start == "s") { NumGame(); }
            else if (start == "e") { System.Environment.Exit(0); }
            else if (start == "c") { NumGame(); }
        }

        static void NumGame()
        {
            Random r = new Random();
            int winNum = r.Next(0, 100);
            bool win = false;
            Console.WriteLine("Guess a number inbetween 0 and 100: ");

            do
            {
                string s = Console.ReadLine();
                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Guessed number is to high!");
                    Console.WriteLine();
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Guessed number is to low!");
                    Console.WriteLine();
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You guessed the Right number!");
                    win = true;
                }
            }
            while (win == false);
            Console.WriteLine("Thanks for playing the game!");
            Console.WriteLine("Press any key to finsih!");
            Console.ReadKey(true);
        }
    }
}