using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PlayerRPSLS
{
    public class HumanPlayer : Player
    {
        public override Choice GetChoice()
        {
            Console.WriteLine("Enter your choice (Rock, Paper, Scissors, Lizard, Snake):");
            string input = Console.ReadLine();
            return (Choice)Enum.Parse(typeof(Choice), input, true);
        }
    }
}
