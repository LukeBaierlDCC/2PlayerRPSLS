using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PlayerRPSLS
{
    public class AIPlayer : Player
    {
        private readonly Random _random = new Random();

        public override Choice GetChoice()
        {
            int choice = _random.Next(0, 5);
            return (Choice)choice;
        }
    }
}
