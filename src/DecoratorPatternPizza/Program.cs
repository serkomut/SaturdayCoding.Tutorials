using System;
using DecoratorPatternPizza.PizzaMenu;

namespace DecoratorPatternPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo largePizza = new LargePhoto("fromurl", "tourl");
            largePizza = new Cheese(largePizza);
            largePizza= new Peppers(largePizza);

            Console.WriteLine(string.Format("{0},{1}", largePizza.GetName(), largePizza.CalCulateCost()));
            Console.ReadKey(true);
        }
    }
}
