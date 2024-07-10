namespace Strategy.Duck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();

            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
        }
    }
}
