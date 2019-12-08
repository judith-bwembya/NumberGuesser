using System;

//namespace
namespace NumberGuesser
{
    //Main class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //Run getAppinfo function to get app info
            GetAppInfo();
            //Ask for users name and greet
            GreetUser();

            while (true)
            {

                //init correct number
                //int correctNumber = 7;

                //create a new random object
                Random random = new Random();

                //init correct number
                int correctNumber = random.Next(1, 10);

                //init  Guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //Get Users input
                    string input = Console.ReadLine();

                    //Make sure its a Number
                    if (!int.TryParse(input, out guess))
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                        //Keep going 
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    } 
                }

                // print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT, You guessed it");

                //Ask user to play again 
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer =="Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        //Get and display app info
        static void GetAppInfo() {
            //set up variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Judith Bwembya";

            //change text color
            Console.ForegroundColor = ConsoleColor.Red;

            // write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset color
            Console.ResetColor();

        }
        //Ask users name and greet
        static void GreetUser()
        {
            //Ask User Name
            Console.WriteLine("What is your name?");

            //Get User Input
            String inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }
        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            //Reset color
            Console.ResetColor();
        }
    }

}
