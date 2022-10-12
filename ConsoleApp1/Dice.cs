namespace ConsoleApp1
{
    internal class Dice
    {
        private readonly Random random = new Random();
        private int lastRoll;

        public Dice()
        {
        }

        public int RollDice()
        {
            LastRoll = random.Next(6);
            return LastRoll;
        }

        public int LastRoll { get; set; }
    }
}
