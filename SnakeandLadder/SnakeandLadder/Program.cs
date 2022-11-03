namespace SnakeandLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Snake and Ladder Game");

            int plearPosition = 0;
            Console.WriteLine("The starting position of the player is {0}", plearPosition);



            Random randon = new Random();
            int diceVal = randon.Next(1, 7);
            Console.WriteLine("The value u ger from rolling the dice is {0} ", diceVal);

            int checkOp = randon.Next(0, 3);
            Console.WriteLine( checkOp);
            switch (checkOp)
            {
                case 0: Console.WriteLine("There are No Play");break;
                case 1: Console.WriteLine("Ladder");break;
                case 2: Console.WriteLine("Snake");break;
            }





        }
    }
}