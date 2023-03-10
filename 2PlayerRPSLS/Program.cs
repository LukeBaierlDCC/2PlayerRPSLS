using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PlayerRPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter player 1 name:");
            string player1Name = Console.ReadLine();
            Console.WriteLine("Is player 2 a human or AI? (Enter H or A)");
            string player2Type = Console.ReadLine();
            
            Player player1 = new HumanPlayer { Name = player1Name };
            Player player2 = new AIPlayer { Name = player2Type };


            try
            {
                if (player2Type.ToUpper() == "H")
                {
                    Console.WriteLine("Enter player 2 name:");
                    string player2Name = Console.ReadLine();
                    player2 = new HumanPlayer { Name = player2Name };
                }
                else if (player2Type.ToUpper() == "A")
                {
                    player2 = new AIPlayer { Name = "AI Player" };
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("That wasn't an option. Look, goofball. The options are 'H' or 'A'. \nNow please try again, or I'll really confuse you.");
                Main(null);
                return;
            }

            int player1Wins = 0;
            int player2Wins = 0;

            while (true)
            {
                Choice player1Choice = player1.GetChoice();
                Choice player2Choice = player2.GetChoice();

                Console.WriteLine("{0} chose {1}", player1.Name, player1Choice);
                Console.WriteLine("{0} chose {1}", player2.Name, player2Choice);

                if (player1Choice == player2Choice)
                {
                    Console.WriteLine("It's a draw!");
                }
                else if ((player1Choice == Choice.Rock && (player2Choice == Choice.Scissors || player2Choice == Choice.Lizard)) ||
                    (player1Choice == Choice.Paper && (player2Choice == Choice.Rock || player2Choice == Choice.Spock)) ||
                    (player1Choice == Choice.Scissors && (player2Choice == Choice.Paper || player2Choice == Choice.Lizard)) ||
                    (player1Choice == Choice.Lizard && (player2Choice == Choice.Paper || player2Choice == Choice.Spock)) ||
                    (player1Choice == Choice.Spock && (player2Choice == Choice.Rock || player2Choice == Choice.Scissors)))
                {
                    Console.WriteLine("{0} wins!", player1.Name);
                    player1Wins++;
                }
                else
                {
                    Console.WriteLine("{0} wins!", player2.Name);
                    player2Wins++;
                }

                //Console.WriteLine("Score: {0} - {1}", player1Wins, player2Wins);

                Console.WriteLine("{0}'s score: {1}", player1.Name, player1Wins);
                Console.WriteLine("{0}'s score: {1}", player2.Name, player2Wins);

                Console.WriteLine("Press Q to quit or any other key to continue");
                string exit = Console.ReadLine();
                if (exit.ToUpper() == "Q")
                {
                    break;
                }

                Console.Clear();
            }
        }
    }
}
