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





        }
    }
}