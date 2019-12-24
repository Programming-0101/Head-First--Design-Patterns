using System;

namespace DuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.FlyBehaviour = new FlyRocketPowered();
            model.PerformFly();
        }
    }
}
