using System;

namespace Strategy
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack() => throw new InvalidOperationException("<< Silence >>");
    }
}
