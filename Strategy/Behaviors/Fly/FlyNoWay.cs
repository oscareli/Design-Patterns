using System;

namespace Strategy
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly() => throw new InvalidOperationException("I can´t fly");
    }
}
