using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoneAgeConsole
{
    class DiceCup
    {

        List<Die> Dice = new List<Die>();
        Random r1 = new Random();

        public DiceCup (int numDice)
        {
            for(int x = 0; x < numDice; x++)
            {
                Dice.Add(new Die(r1));
                Thread.Sleep(1000);
            }
        }
    }
}
