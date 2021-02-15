// Author: pra2e
// NumberGuesser Project (Console App using .NET Core)
using System;

namespace NumberGuesser {

    // Main class
    class NumGuess {
        // Global vars
        public string name;
        public int limit;
        public int answer;
        public bool correct;

        // Constructor for NumGuess class
        public NumGuess() {
            Random rnd = new Random();
            answer = rnd.Next(1, 11); // generates a random number between 1 and 10
            limit = 5;
            correct = false;
        }
        
        // Entry point
        static void Main(string[] args) {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "pra2e";

            // Create user object
            NumGuess user = new NumGuess();

            // Greet user
            user.GreetUser(appName, appVersion, appAuthor);
            
            // Start game code
            while (Console.ReadLine() == "") {
                user.DisplayInstruction(user.limit);
                
                for (int i = 0; i <= user.limit; i++) {
                    string userInput = Console.ReadLine();
                    int guess = Int32.Parse(userInput);
                    bool checkAns = user.VerifyAnswer(guess, user.answer);

                    // Correct answer
                    if (checkAns) {
                        Console.WriteLine("Correct!");
                        Console.WriteLine("Guess: {0}    Ans: {1}   Attempts Remaining: {2}.", guess, user.answer, (user.limit - i - 1));
                    }
                    // Incorrect answer
                    else if (!checkAns) {
                        Console.WriteLine("\n\n\n Incorrect...");
                        Console.WriteLine("You have {0} attempt(s) remaining.", (user.limit - i - 1));
                        // Give hints
                        if (guess - user.answer > 0) {
                            Console.WriteLine("(Hint: Your guess is too high.)");
                        }
                        else {
                            Console.WriteLine("Hint: Your guess is too low.");
                        }
                    }
                }
                Console.WriteLine("You have no attempts remaining. LOSER!");
            }
        }

        // Method to initially greet the user
        void GreetUser(string appName, string appAuthor, string appVersion) {
            Console.Beep();
            Console.WriteLine("{0} by {1} --- Version {2}", appName, appAuthor, appVersion);
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Press Enter to start the game...");
        }

        // Method to display insturctions on the console
        void DisplayInstruction(int limit) {
            Console.WriteLine("\n\n\n You have {0} attempts remaining.", limit);
            Console.WriteLine("Guess a number between 1 and 10:");
        }

        // Method to check the user's guess
        bool VerifyAnswer(int guess, int answer) {
            if (guess == answer) {
                return true;
            }
            else {
                return false;
            }
        }
    }

}
