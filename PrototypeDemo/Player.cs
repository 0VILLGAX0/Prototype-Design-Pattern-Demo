/******************************************************************************
* Filename    = Player.cs
*
* Author      = Kaustubh Chavan
*
* Product     = [Your Product Name]
* 
* Project     = Prototype-Design-Pattern-Demo
*
* Description = Represents a player with name, stats, and provides cloning methods.
*****************************************************************************/
using System;

namespace PrototypeDemo
{
    /// <summary>
    /// Represents a player with a name, stats, and provides methods for cloning.
    /// </summary>
    public class Player : IPlayer
    {
        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the player's statistics.
        /// </summary>
        public Stats stats;

        /// <summary>
        /// Initializes a new instance of the Player class with the given name and stats.
        /// </summary>
        /// <param name="name">The name of the player.</param>
        /// <param name="stats">The player's statistics.</param>
        public Player( string name , Stats stats )
        {
            this.name = name;
            this.stats = stats;
        }

        /// <summary>
        /// Creates a shallow clone of the player object.
        /// </summary>
        /// <returns>A shallow clone of the player.</returns>
        public IPlayer? GetShallowClone()
        {
            return MemberwiseClone() as IPlayer;
        }

        /// <summary>
        /// Creates a deep clone of the player object.
        /// </summary>
        /// <returns>A deep clone of the player.</returns>
        public IPlayer? GetDeepClone()
        {
            var player = (Player)MemberwiseClone();
            if (player != null)
            {
                player.stats = new Stats { level = 10 , health = 150 };
                return player;
            }
            return null;
        }

        /// <summary>
        /// Displays the player's name and statistics on the console.
        /// </summary>
        public void ShowStats()
        {
            Console.WriteLine( $"Name is : {name}" );
            Console.WriteLine( $"Health : {stats.health}" );
            Console.WriteLine( $"Current Level : {stats.level}" );
        }
    }
}
