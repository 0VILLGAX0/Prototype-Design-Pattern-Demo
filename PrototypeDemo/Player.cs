

namespace PrototypeDemo
{
    public class Player : IPlayer
    {
        public string name { get; set; }

        public Stats stats;

        public Player(string name, Stats stats)
        {
            this.name = name;
            this.stats = stats;
        }


        public IPlayer? GetShallowClone()
        {
            return MemberwiseClone() as IPlayer;
        }

        public IPlayer? GetDeepClone()
        {
            var player = (Player)MemberwiseClone();
            if (player != null)
            {
                player.stats = new Stats { level = 10, health = 150 };
                return player;
            }
            return null;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Name is : {name}");
            Console.WriteLine($"Health : {stats.health}");
            Console.WriteLine($"Current Level : {stats.level}");
        }
    }
}
