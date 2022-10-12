
namespace ConsoleApp1
{
    internal class Player
    {
        private int score;
        private String name;

        public Player(string name)
        {
            this.score = 0;
            this.name = name;
        }

        public int Score { get; set; }
        public String Name { get; set; }
    }
}
