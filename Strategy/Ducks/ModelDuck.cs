using System;

namespace Strategy
{
    public class ModelDuck : IDuck
    {
        public ModelDuck()
        {
            this.Display();

            this.FlyBehavior = new FlyNoWay();
            this.QuackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I´m a model duck");
        }
    }
}
