using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public interface IIceCream
    {
        int GetPrice();
    }

    public class SimpleICeCream : IIceCream
    {
        public int GetPrice()
        {

            Console.WriteLine("10 Dollars");
            return 10;
        }
    }


    public class ChocolateDecorator : IIceCream
    {
        private readonly IIceCream _iceCream;

        public ChocolateDecorator(IIceCream iceCream)
        {
            _iceCream = iceCream;
        }
        public int GetPrice()
        {
            var newPrice = _iceCream.GetPrice() + 10;
            Console.WriteLine($"IceCreamWithChocolalte price is : {newPrice}");
            return newPrice;
        }
    }

    public class PesteDecorator : IIceCream
    {
        private readonly IIceCream _iceCream;

        public PesteDecorator(IIceCream iceCream)
        {
            _iceCream = iceCream;
        }
        public int GetPrice()
        {
            var newPrice = _iceCream.GetPrice() + 50;
            Console.WriteLine($"IceCreamWithChocolalte price is : {newPrice}");
            return newPrice;
        }
    }
}
