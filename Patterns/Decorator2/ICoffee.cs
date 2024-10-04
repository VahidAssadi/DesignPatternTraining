using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator2
{
    public interface ICoffee
    {
        string GetDescription();
        double Cost();
    }


    public class Espresso : ICoffee
    {
        public double Cost()
        {
            return 1.0;
        }

        public string GetDescription()
        {
            return "Espresso";
        }
    }


    public class Latte: ICoffee
    {
       
        public double Cost()
        {
            return 1.5;
        }
        public string GetDescription()
        {
            return "Latte";
        }
    }

    public class Americano: ICoffee
    {
        public string GetDescription()
        {
            return "Americano";
        }

        public double Cost()
        {
            return 2.0;
        }
    }



    public abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee _coffee;
        protected CoffeeDecorator(ICoffee coffee)
        {

            _coffee = coffee;

        }
        public virtual double Cost()
        {
            return _coffee.Cost();
        }

        public virtual string GetDescription() => _coffee.GetDescription();
    }

    public class MochaDecorator : CoffeeDecorator
    {
        readonly ICoffee _coffee;
        public MochaDecorator(ICoffee coffee) : base(coffee)
        {
            _coffee = coffee;
        }

        public double Cost()
        {
            return _coffee.Cost() + 0.4;
        }

        public string GetDescription()
        {
            return _coffee.GetDescription() + ", Mocha";
        }
    }

    public class MilkDecorator : CoffeeDecorator
    {
        readonly ICoffee _coffee;
        public MilkDecorator(ICoffee coffee):base(coffee) {
        
            _coffee = coffee;
        }

        public string GetDescription()
        {
            return _coffee.GetDescription() + ", Milk";
        }

        public double Cost()
        {
            return _coffee.Cost() + 1.5;
        }
    }

    public class SugarDecorator : CoffeeDecorator
    {
        readonly ICoffee _coffee;
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
            _coffee = coffee;        
        }

        public string GetDescription()
        {
            return _coffee.GetDescription() + ", Sugar";
        }

        public double Cost()
        {
            return _coffee.Cost() + 0.6;
        }
    }

}
