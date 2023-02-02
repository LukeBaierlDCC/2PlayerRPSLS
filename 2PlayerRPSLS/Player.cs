using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PlayerRPSLS
{
    public enum Choice
    {
        Rock,
        Paper,
        Scissors,
        Lizard,
        Spock
    }

    public abstract class Player
    {
        public string Name { get; set; }

        public abstract Choice GetChoice();
    }
}
