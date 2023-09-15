/******************************************************************************
* Filename    = UnitTest1.cs
*
* Author      = Kasutubh Chavan
*
* Product     = [Your Product Name]
* 
* Project     = Prototype-Design-Pattern-Demo
*
* Description = Contains unit tests for the Player class in the Prototype Pattern implementation.
*****************************************************************************/
using System.Numerics;
using PrototypeDemo;

namespace UnitTest
{
    /// <summary>
    /// Contains unit tests for the Player class in the Prototype Pattern implementation.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Verifies that the GetShallowClone() method returns a shallow copy of the player object.
        /// </summary>
        [TestMethod]
        public void GetShallowCloneShouldReturnShallowClone()
        {
            // Arrange
            // Create a new player object.
            var player = new Player( "Player 1" , new Stats { level = 20 , health = 4490 } );

            // Act
            // Create a shallow copy of the player object.
            var shallowClone = player.GetShallowClone() as Player;

            // Assert
            // Changing the stats of the shallow clone should also change the stats of the original player,
            // since it is a shallow copy.
            shallowClone.stats.level = 10;
            shallowClone.stats.health = 200;

            // Verify that the stats of the original player have also changed, since the shallow clone is a shallow copy.
            Assert.AreEqual( 10 , player.stats.level );
            Assert.AreEqual( 200 , player.stats.health );
            Assert.AreEqual( player.stats.level , shallowClone.stats.level );
            Assert.AreEqual( player.stats.health , shallowClone.stats.health );
            Assert.AreEqual( player.stats , shallowClone.stats );
        }

        /// <summary>
        /// Verifies that the GetDeepClone() method returns a deep copy of the player object.
        /// </summary>
        [TestMethod]
        public void GetDeepCloneShouldReturnDeepClone()
        {
            // Arrange
            // Create a new player object.
            var player = new Player( "Player 1" , new Stats { level = 20 , health = 440 } );

            // Act
            // Create a deep copy of the player object.
            var deepClone = player.GetDeepClone() as Player;

            // Assert

            // Changing the stats of the deep clone should not change the stats of the original player,
            // since it is a deep copy.
            deepClone.stats.level = 10;
            deepClone.stats.health = 200;

            // Verify that the deep clone has the same name and stats as the original player.
            // Verify that the stats of the original player have not changed, since the deep clone is a deep copy.
            Assert.AreEqual( 20 , player.stats.level );
            Assert.AreEqual( 440 , player.stats.health );
            Assert.AreEqual( 10 , deepClone.stats.level );
            Assert.AreEqual( 200 , deepClone.stats.health );
            Assert.AreNotEqual( player.stats , deepClone.stats );
        }
    }
}
