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
            Player player1 = new HumanPlayer { Name = "Player 1" };

            Player player2 = new AIPlayer { Name = "AI Player" };

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
                    (player1Choice == Choice.Paper && (player2Choice == Choice.Rock || player2Choice == Choice.Snake)) ||
                    (player1Choice == Choice.Scissors && (player2Choice == Choice.Paper || player2Choice == Choice.Lizard)) ||
                    (player1Choice == Choice.Lizard && (player2Choice == Choice.Paper || player2Choice == Choice.Snake)) ||
                    (player1Choice == Choice.Snake && (player2Choice == Choice.Rock || player2Choice == Choice.Scissors)))
                {
                    Console.WriteLine("{0 wins!}", player1.Name);
                }
                else
                {
                    Console.WriteLine("{0} wins!", player2.Name);
                }

                Console.WriteLine();
            }
        }
    }
}
