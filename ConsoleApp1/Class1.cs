namespace ConsoleApp1
{
    internal class Dice
    {
        private readonly Random random = new Random();

        public int RollDice()
        {
            return random.Next(6);
        }
    }
}
