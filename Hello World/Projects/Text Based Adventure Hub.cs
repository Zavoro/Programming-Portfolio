namespace Hello_World.Projects
{
    internal class Text_Based_Adventure_Hub
    {
        public static void Main()
        {
            //this is a project that will implement mini-games
            //including a number guessing game, dice roller, password strength checker
            //ask the user for their name, show a menu, let the user choose from multiple options
            //loop back to the menu



            //welcome message
            Console.WriteLine("Adventure Hub starting...");
            Console.WriteLine("\nPress any key to initialize...");
            Console.ReadKey();
            Console.Clear();

            //playername,greeting,console clear
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Welcome, {playerName}!");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //if validChoice is false then loop
            //loop breaks when user gives a valid input
            bool validChoice = false;
            while (!validChoice)
            {
                //option menu
                Console.WriteLine("Which option would you like to choose?\n");
                Console.WriteLine("1. Number Guessing Game");
                Console.WriteLine("2. Dice Roller");
                Console.WriteLine("3. Password Strength Checker");
                Console.Write("\n Choose an option (1-3): ");
                string choice = Console.ReadLine();
                Console.Clear();
                if (choice == "1")
                {
                    PlayNumberGuessingGame();
                    validChoice = true;

                }
                else if (choice == "2")
                {
                    PlayDiceRoller();
                    validChoice = true;
                }
                else if (choice == "3")
                {
                    PlayPasswordChecker();
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid option! Please choose 1, 2, or 3.\n");

                }
            }







        }

        static void PlayNumberGuessingGame()
        {
            //user prompted after guessing correctly whether they want to play again (y/n)
            //loop breaks when user inputs n (playAgain false)
            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("--- Number Guessing Game ---");

                //random number generator
                Random random = new Random();
                int secretNumber = random.Next(1, 11);
                Console.WriteLine($"(Debug) Secret number is: {secretNumber}");

                //guessCorrect is false until the correct number is guessed, then guessCorrect is true
                //loop breaks when guessCorrect is true
                //gives user the ability to keep guessing until the guess is correct
                bool guessCorrect = false;
                while (!guessCorrect)
                {
                    Console.WriteLine("Guess the number between 1 and 10: ");
                    string guessInput = Console.ReadLine();
                    int guess;
                    bool isNumber = int.TryParse(guessInput, out guess);
                    Console.WriteLine($"(Debug) isNumber = {isNumber}, guess = {guess}");

                    //if and else statements for checking if guess is correct
                    if (!isNumber)
                    {
                        Console.WriteLine("That's not a valid number");
                    }
                    else if (guess == secretNumber)
                    {
                        Console.WriteLine("Correct! You guessed the number!");
                        guessCorrect = true;
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else
                    {
                        Console.WriteLine("Too High!");
                    }


                }

                //play again prompt
                Console.Write("Play again? (y/n): ");
                string answer = Console.ReadLine().ToLower();

                if (answer != "y")
                {
                    playAgain = false;
                }

                {

                }
            }


        }
        static void PlayDiceRoller()
        {
            bool rollAgain = true;
            while (rollAgain)
            {
                Console.Clear();
                Console.WriteLine("--- Dice Roller ---");
                Random random = new Random();
                int roll = random.Next(1, 7); //roll wil be 1 to 6
                Console.WriteLine($"You rolled a {roll}");

                Console.WriteLine("Roll Again? (y/n): ");
                string answer = Console.ReadLine().ToLower();

                if (answer != "y")
                {
                    rollAgain = false;
                }
            }
        }
        static void PlayPasswordChecker()
        {
            Console.Clear();
            Console.WriteLine("--- Password Checker ---");

            Console.Write("Enter a password to check: ");
            string password = Console.ReadLine();

            if (password.Length < 6)
            {
                Console.WriteLine("Strength: Weak");
            }
            else if (password.Length < 10)
            {
                Console.WriteLine("Strength: Medium");
            }
            else
            {
                Console.WriteLine("Strength: Strong");
            }
        }
    }
}










