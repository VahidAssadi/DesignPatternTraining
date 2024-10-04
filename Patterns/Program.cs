using Builder;
using DesignPattern.Decorator;
using DesignPattern.Decorator2;
using System;

namespace DesignPattern
{
    public abstract class Foo
    {
        public abstract DateTime TimeCreated { get; set; }
        private readonly string _name;
        public Foo(string name)
        {
            _name = name;   
            this.TimeCreated = DateTime.Now;
        }
    }

    public abstract class Bar : Foo
    {
        //public Bar() : base() //Bar's constructor's must call Foo's parameterless constructor.
        //{ }
        public Bar(string name) : base(name)
        {
        }
        public abstract void download();
    }
    public class FooBuilder : Bar
    {
        public FooBuilder(string name) : base(name)
        {
        }

        public override DateTime TimeCreated { get => DateTime.Now; set { value = DateTime.Now;  } }

        public override void download()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
       
        static void Main(string[] args)
        {

            ////Bar bar = new FooBulder("ddada"); 

            //StoreCreditCard(new CompressStream(new EncryptedStream(new CloudStream())));
            ////IIceCream icecream = new SimpleICeCream();
            ////icecream.GetPrice();
            ////IIceCream iceCreamWithChocolate = new ChocolateDecorator(icecream);
            ////var chocoandpeste = new PesteDecorator(iceCreamWithChocolate);
            ////Console.WriteLine("Standard basic product:" + chocoandpeste.GetPrice().ToString());
            ///


            ICoffee coffee = new Espresso();  // Start with an espresso


            coffee = new MochaDecorator(coffee);  // Add mocha

            coffee = new SugarDecorator(coffee);  // Add sugar

            coffee = new MilkDecorator(coffee);  // Add milk layer

            Console.WriteLine(coffee.GetDescription() + " $" + coffee.Cost());

        }

        static void StoreCreditCard(IStream stream)
        {
            stream.Write("123-1234-1234-1234");
        }
    }
}
