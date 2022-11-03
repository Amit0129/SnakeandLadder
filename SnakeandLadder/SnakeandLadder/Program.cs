using System.Security.Cryptography.X509Certificates;

namespace SnakeandLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Snake and Ladder Game");

            int plearPosition = 0;
            const int WIN_POSI = 100;
            int playerRollCount = 0;
            Console.WriteLine("The starting position of the player is {0}", plearPosition);


            while (plearPosition < WIN_POSI)
            {
                playerRollCount++;


                Random randon = new Random();
                int diceVal = randon.Next(1, 7);
                Console.WriteLine("The value u ger from rolling the dice is {0} ", diceVal);

                int checkOp = randon.Next(0, 3);
                Console.WriteLine(checkOp);

               
                    //plearPosition += diceVal;
                    //Console.WriteLine("The Player PositionNow is {0} ", plearPosition);

                    switch (checkOp)
                    {
                        case 0:
                            Console.WriteLine("There are No Play");
                            Console.WriteLine("Player Position is {0}", plearPosition);
                            break;
                        case 1:

                            Console.WriteLine("Ladder");
                            plearPosition += diceVal;
                            Console.WriteLine("Player Position is {0}", plearPosition);

                            break;
                        case 2:
                            Console.WriteLine("Snake");
                            plearPosition -= diceVal;
                            if (plearPosition < 0)
                            {
                                plearPosition = 0;
                            }
                            Console.WriteLine("Player Position is {0}", plearPosition);
                            break;
                    }

                }
            
            
        





        }
    }
}