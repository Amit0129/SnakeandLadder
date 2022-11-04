using System.Security.Cryptography.X509Certificates;

namespace SnakeandLadder
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Snake and Ladder Game");

            int playerOnePosition = 0;
            int playerTwoPosition = 0;
            int player1Count = 0;
            int player2Count = 0;
            bool player1 = true;
            bool player2 = false;


            const int WIN_POSI = 100;


            GameControler gameControler = new GameControler();
            Random random = new Random();
            


            Console.WriteLine("The starting position of the player One is {0}", playerOnePosition);
            Console.WriteLine("The starting position of the player Two is {0}", playerTwoPosition);


           



            while (playerOnePosition < WIN_POSI && playerTwoPosition < WIN_POSI)
            {
                if (playerOnePosition == 100)
                {
                    Console.WriteLine("One win");
                }
                if (playerTwoPosition == 100)
                {
                    Console.WriteLine("Two Win");
                }
                if (player1)
                {
                    int diceVal = random.Next(1, 7);
                    Console.WriteLine("The value u ger from rolling the dice is {0} ", diceVal);

                    int checkOp = random.Next(0, 3);
                    Console.WriteLine(checkOp);
                    player1Count++;
                    if (checkOp == 0)
                    {
                        gameControler.noPlay(playerOnePosition, player1Count);
                        
                    }
                    else if (checkOp == 1)
                    {
                        playerOnePosition =gameControler.ladder(playerOnePosition, diceVal, player1Count);


                    }
                    else
                    {
                        playerOnePosition = gameControler.snake(playerOnePosition, diceVal, player1Count);
                        player1 = false;
                        player2 = true;
                        
                    }
                }
                else
                {
                    int diceVal = random.Next(1, 7);
                    Console.WriteLine("The value u ger from rolling the dice is {0} ", diceVal);

                    int checkOp = random.Next(0, 3);
                    Console.WriteLine(checkOp);
                    player2Count++;
                    if (checkOp == 0)
                    {
                        gameControler.noPlay(playerTwoPosition,player2Count);
                    }
                    else if (checkOp == 1)
                    {
                        playerTwoPosition = gameControler.ladder(playerTwoPosition,diceVal, player2Count);
                    }
                    else
                    {
                        playerTwoPosition = gameControler.snake(playerTwoPosition, diceVal, player2Count);
                        player1 = true;
                        player2 = false;
                        
                    }
                }

            }
            if (playerOnePosition == 100)
            {
                Console.WriteLine("---==========Player One Win==========---");
            }
            if (playerTwoPosition == 100)
            {
                Console.WriteLine("---==========Player Two win====---");
            }
        }
    }
}
