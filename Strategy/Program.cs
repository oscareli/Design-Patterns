using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mallard Duck
            IDuck mallard = new MallarDuck();

            mallard.PerformFly();
            mallard.PerformQuack();

            Console.WriteLine("----------------------------------------------------------------------------------");

            // Model Duck
            ModelDuck model = new ModelDuck();

            try
            {
                model.PerformFly();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tradando o comportamento de voar...");
                model.FlyBehavior = new FlyRocketPowerd();
                model.PerformFly();
            }
        }
    }
}
