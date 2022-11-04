using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class GameControler

    {
        
        public void noPlay(int playerPosition,int playerRollCount)
        {
            Console.WriteLine("There are No Play");
            Console.WriteLine("Player Position is {0}", playerPosition);
            Console.WriteLine("The Dice Roll {0} times", playerRollCount);
        }
        public int ladder(int playerPosition,int diceVal,int playerRollCount)
        {
            Console.WriteLine("Ladder");
            playerPosition += diceVal;
            if (playerPosition > 100)
            {
                playerPosition -= diceVal;
            }
            
            Console.WriteLine("Player Position is {0}", playerPosition);
            Console.WriteLine("The Dice Roll {0} times", playerRollCount);
            return playerPosition;
        }
        public int snake(int playerPosition, int diceVal, int playerRollCount)
        {
            Console.WriteLine("Snake");
            playerPosition -= diceVal;
            if (playerPosition < 0)
            {
                playerPosition = 0;
            }
            Console.WriteLine("Player Position is {0}", playerPosition);
            Console.WriteLine("The Dice Roll {0} times", playerRollCount);
            return playerPosition;
        }
    }
}
