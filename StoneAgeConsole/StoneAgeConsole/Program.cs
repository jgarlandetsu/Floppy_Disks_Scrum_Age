using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneAgeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            String userInput;
            Boolean working = false;
            List<Player> playerList = new List<Player>();
            List<String> colorsRemaining = new List<String>();

            colorsRemaining.Add("Blue");
            colorsRemaining.Add("Red");
            colorsRemaining.Add("Green");
            colorsRemaining.Add("Yellow");

            //This for loop will allow the user to enter how many players and also error check for bad input
            while(working == false)
            {
                Console.SetWindowPosition(0, 0);
                Console.SetWindowSize(((Console.LargestWindowWidth/4)*3), ((Console.LargestWindowHeight / 4) * 3));
                Console.WriteLine("Welcome to the Game. How many Players will there be?");
                Console.WriteLine("*Note: The game may only be played by 2-4 players.\n");
                userInput = Console.ReadLine();

                if(Int64.TryParse(userInput,out long holdInput) == true)
                {
                    if (holdInput == 2)
                    {
                        playerList.Add(new Player(1));
                        colorsRemaining.RemoveAt(colorsRemaining.IndexOf(playerList[0].chooseColor(colorsRemaining)));
                        playerList.Add(new Player(2));
                        colorsRemaining.RemoveAt(colorsRemaining.IndexOf(playerList[0].chooseColor(colorsRemaining)));
                        working = true;
                    }
                    else if (holdInput == 3)
                    {
                        playerList.Add(new Player(1));
                        colorsRemaining.RemoveAt(colorsRemaining.IndexOf(playerList[0].chooseColor(colorsRemaining)));
                        playerList.Add(new Player(2));
                        colorsRemaining.RemoveAt(colorsRemaining.IndexOf(playerList[0].chooseColor(colorsRemaining)));
                        playerList.Add(new Player(3));
                        colorsRemaining.RemoveAt(colorsRemaining.IndexOf(playerList[0].chooseColor(colorsRemaining)));
                        working = true;
                    }
                    else if (holdInput == 4)
                    {
                        playerList.Add(new Player(1));
                        colorsRemaining.RemoveAt(colorsRemaining.IndexOf(playerList[0].chooseColor(colorsRemaining)));
                        playerList.Add(new Player(2));
                        colorsRemaining.RemoveAt(colorsRemaining.IndexOf(playerList[0].chooseColor(colorsRemaining)));
                        playerList.Add(new Player(3));
                        colorsRemaining.RemoveAt(colorsRemaining.IndexOf(playerList[0].chooseColor(colorsRemaining)));
                        playerList.Add(new Player(4));
                        colorsRemaining.RemoveAt(colorsRemaining.IndexOf(playerList[0].chooseColor(colorsRemaining)));
                        working = true;
                    }
                    else
                    {
                        Console.WriteLine("You entered a non-valid number. Please Try Again. \n\n\n");
                    }
                }
                else
                {
                     Console.WriteLine("You entered a non-valid number. Please Try Again. \n\n\n");
                }
            }
        }
    }
}
