/******************************************************************************
* Filename    = IPlayer.cs
*
* Author      = Kasutubh Chavan
*
* Product     = [Your Product Name]
* 
* Project     = Prototype-Design-Pattern-Demo
*
* Description = Interface for Player cloning in the Prototype Pattern
*****************************************************************************/
using System;

namespace PrototypeDemo
{
    /// <summary>
    /// Defines methods for creating shallow and deep clones of a Player object.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Creates a shallow copy of the Player object.
        /// </summary>
        /// <returns>A shallow copy of the Player.</returns>
        IPlayer? GetShallowClone();

        /// <summary>
        /// Creates a deep copy of the Player object.
        /// </summary>
        /// <returns>A deep copy of the Player.</returns>
        IPlayer? GetDeepClone();
    }
}
