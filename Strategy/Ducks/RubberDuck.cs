using System;

namespace Strategy
{
    public class RubberDuck : IDuck
    {
        public RubberDuck()
        {
            this.Display();

            this.FlyBehavior = new FlyNoWay();
            this.QuackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I´m a real Rubber Duck");
        }
    }
}
