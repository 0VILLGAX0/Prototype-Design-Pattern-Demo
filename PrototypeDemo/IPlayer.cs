using System;


namespace PrototypeDemo
{
    public interface IPlayer
    {
        IPlayer? GetShallowClone();
        IPlayer? GetDeepClone();
    }
}
