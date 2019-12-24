namespace DuckSimulator
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehaviour = new NormalQuack();
            FlyBehaviour = new FlyWithWings();
        }

      public override string ToString() 
      {
          return "I'm a real Mallard duck";
      }
  }
}