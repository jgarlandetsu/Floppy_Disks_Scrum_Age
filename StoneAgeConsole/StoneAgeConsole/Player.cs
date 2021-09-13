using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneAgeConsole
{
    class Player
    {
        String PlayerName;
        String PlayerNumber;
        String PlayerColor;
        int AgricultureTrack;
        int ScoreTrack;

        public Player(int playerNum)
        {
            Console.Clear();
            PlayerNumber = "Player Number " + playerNum;
            Console.WriteLine("Welcome Player " + playerNum + "!");
            Console.WriteLine("What is your name? \n");
            PlayerName = Console.ReadLine();
        }

        public String chooseColor(List<String> colorList)
        {
            Console.Clear();
            Console.WriteLine("Hello " + PlayerName + "!");
            Console.WriteLine("\nWhich color would you like to play as? \nThese are your options:\n");

            for(int x=0; x < colorList.Count; x++)
            {
                Console.WriteLine(colorList[x]);
            }

            Console.WriteLine("\n");

            for(;;)
            {
                String userInput = Console.ReadLine();

                if (colorList.Contains(userInput) == false)
                {
                    Console.WriteLine("That was not one of the options, please try again.");
                }
                else
                {
                    PlayerColor = userInput;
                    return userInput;
                }
            }

        }
    }
}
