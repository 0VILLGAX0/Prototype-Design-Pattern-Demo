using System.Numerics;
using PrototypeDemo;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetShallowCloneShouldReturnShallowClone()
        {
            // Arrange
            var player = new Player("Player 1", new Stats { level = 20, health = 4490 });

            // Act
            var shallowClone = player.GetShallowClone() as Player;

            // Assert
            // Changing the stats of the shallow clone should also change the stats of the original player,
            // since it is a shallow copy.
            shallowClone.stats.level = 10;
            shallowClone.stats.health = 200;

            Assert.AreEqual(10, player.stats.level);
            Assert.AreEqual(200, player.stats.health);
            Assert.AreEqual(player.stats.level, shallowClone.stats.level);
            Assert.AreEqual( player.stats.health , shallowClone.stats.health );
            Assert.AreEqual(player.stats, shallowClone.stats );
        }
        [TestMethod]
        public void GetDeepCloneShouldReturnDeepClone()
        {
            // Arrange
            var player = new Player("Player 1", new Stats { level = 20, health = 440 });

            // Act
            var deepClone = player.GetDeepClone() as Player;

            // Assert

            // Changing the stats of the deep clone should not change the stats of the original player,
            // since it is a deep copy.
            deepClone.stats.level = 10;
            deepClone.stats.health = 200;

            Assert.AreEqual(20, player.stats.level);
            Assert.AreEqual(440, player.stats.health);
            Assert.AreEqual(10,deepClone.stats.level);
            Assert.AreEqual(200,deepClone.stats.health);
            Assert.AreNotEqual(player.stats, deepClone.stats);
        }

    }
}
