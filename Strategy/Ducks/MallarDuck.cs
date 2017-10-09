using System;

namespace Strategy
{
    public class MallarDuck : IDuck
    {
        public MallarDuck()
        {
            this.Display();

            this.FlyBehavior = new FlyWithWings();
            this.QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I´m a real Mallard Duck");
        }
    }
}
