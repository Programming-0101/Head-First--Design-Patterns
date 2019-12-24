namespace DuckSimulator
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehaviour = new NoCanFly();
            QuackBehaviour = new NormalQuack();
        }

        public override string ToString()
        {
            return "I'm a model duck";
        }
    }
}