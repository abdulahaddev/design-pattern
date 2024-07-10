﻿namespace Strategy.Duck
{
    public interface IFlyBehavior
    {
        void DoFly();
    }

    public interface IQuackBehavior
    {
        void DoQuack();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void DoFly()
        {
            Console.WriteLine("I'm flying...");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void DoFly()
        {
            Console.WriteLine("I can't fly!");
        }
    }

    public class Quack : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Quack...");
        }
    }

    public class Squeak : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Squeak...");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("...Silence...");
        }
    }

    public abstract class Duck
    {
        private IQuackBehavior quackBehavior;
        private IFlyBehavior flyBehavior;

        protected IQuackBehavior QuackBehavior { get => quackBehavior; set => quackBehavior = value; }
        protected IFlyBehavior FlyBehavior { get => flyBehavior; set => flyBehavior = value; }

        public void PerformQuack()
        {
            quackBehavior.DoQuack();
        }

        public void PerformFly()
        {
            FlyBehavior.DoFly();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public void Display()
        {
            Console.WriteLine("I'm a real Mallard Duck!");
        }
    }
}
