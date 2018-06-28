namespace DecoratorPatternPizza.PizzaMenu
{
    public abstract class Photo
    {
        public string Name { get; set; }
        public abstract string GetName();
        public abstract double CalCulateCost();
    }
}
