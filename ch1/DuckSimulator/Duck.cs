using static System.Console;

namespace DuckSimulator
{
    public abstract class Duck
    {
        public FlyBehaviour FlyBehaviour { get; set; }
        public QuackBehaviour QuackBehaviour { get; set; }

        public void PerformFly()
        {
            WriteLine(FlyBehaviour.Fly());
        }

        public void PerformQuack()
        {
            WriteLine(QuackBehaviour.Quack());
        }

        public void Swim()
        {
            WriteLine("All ducks float, even decoys!");
        }
    }
}
// using System;

namespace DuckSimulator
{
}
