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
            Console.WriteLine("Enter your choice (Rock, Paper, Scissors, Lizard, Spock):");
            string input = Console.ReadLine();
            return (Choice)Enum.Parse(typeof(Choice), input, true);
            try
            {
                return (Choice)Enum.Parse(typeof(Choice), input, true);
            }
            catch (Exception)
            {
                Console.WriteLine("That is an invalid option, my friend. \nI literally cannot make this easier for you. \nPlease enter: rock, paper, scissors, lizard, spock.");
                return GetChoice();
            }
        }
    }
}
