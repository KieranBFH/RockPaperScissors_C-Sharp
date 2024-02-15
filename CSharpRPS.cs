namespace RockPaperScissors   ///////////////// Created By KieranBFH on Github for CSE2140.
{
    public class Game
    {
        private static void ComparePlayers(string p1, string p2, int players)   ////////////////////// Calculation of who won for both 1 and 2 players.
        {
            Console.Clear();
            string player1def;
            string player2def;

            if (players == 1)
            {
                player1def = "You";
                player2def = "CPU";
            }

            else
            {
                player1def = "Player 1";
                player2def = "Player 2";
            }

            if (p1 == "ROCK")
            {
                if (p2 == "ROCK")
                {
                    Console.WriteLine("Tie!");
                }

                else if (p2 == "PAPER")
                {
                    Console.WriteLine(player2def + " Won!");
                }

                else if (p2 == "SCISSORS")
                {
                    Console.WriteLine(player1def + " Won!");
                }

                else
                {
                    Console.WriteLine("Error: Player 2 Typo.");
                }
            }

            else if (p1 == "PAPER")
            {
                if (p2 == "ROCK")
                {
                    Console.WriteLine(player1def + " Won!");
                }
                else if (p2 == "PAPER")
                {
                    Console.WriteLine("Tie!");
                }
                else if (p2 == "SCISSORS")
                {
                    Console.WriteLine(player2def + " Won!");
                }
                else
                {
                    Console.WriteLine("Error: Player 2 Typo.");
                }
            }

            else if (p1 == "SCISSORS")
            {
                if (p2 == "ROCK")
                {
                    Console.WriteLine(player2def + " Won!");
                }
                else if (p2 == "PAPER")
                {
                    Console.WriteLine(player1def + " Won!");
                }
                else if (p2 == "SCISSORS")
                {
                    Console.WriteLine("Tie!");
                }
                else
                {
                    Console.WriteLine("Error: Player 2 Typo.");
                }
            }
            else
            {
                Console.WriteLine("Error: Player 1 Typo.");
            }
        }
        private static void OnePlayer() /////////////////////// Singleplayer CPU choice and Player choice.
        {
            Console.Clear();
            Console.WriteLine("Rock, Paper or Scissors?");
            var p1choice = Console.ReadLine().ToUpper();
            var CPU = new Random();
            int cpuchoice = CPU.Next(1, 4);
            string cpustrchoice;

            if (cpuchoice == 1)
            {
                cpustrchoice = "ROCK";
                
            }

            else if (cpuchoice == 2)
            {
                cpustrchoice = "PAPER";
            }

            else
            {
                cpustrchoice = "SCISSORS";
            }
            ComparePlayers(p1choice, cpustrchoice, 1);
        }

        private static void TwoPlayer() //////////////////// Two player choices
        {
            Console.Clear();
            Console.WriteLine("Player 1: Rock, Paper or Scissors?");
            var p1choice = Console.ReadLine().ToUpper();
            Console.Clear();
            Console.WriteLine("Player 2: Rock, Paper or Scissors?");
            var p2choice = Console.ReadLine().ToUpper();
            ComparePlayers(p1choice, p2choice, 2);
        }
        static void Main(string[] args)  /////////////////// Player count chooser
        {
            Console.WriteLine("How many players? (1 or 2)"); 
            string mode = Console.ReadLine();
            if (mode == "1")
            {
                OnePlayer();
            }

            else if (mode == "2")
            {
                TwoPlayer();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Option");
            }
        }

    }
}
