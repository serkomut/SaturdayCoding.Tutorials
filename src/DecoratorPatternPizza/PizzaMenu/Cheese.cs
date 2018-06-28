namespace DecoratorPatternPizza.PizzaMenu
{
    public class Cheese: PhotoDecoration
    {
        public Cheese(Photo pizza) : base(pizza)
        {
            Name = "Cheese";
        }

        public override string GetName()
        {
            return string.Format("{0},{1}", _pizza.GetName(), this.Name);
        }

        public override double CalCulateCost()
        {
            return _pizza.CalCulateCost() + 1.25;
        }
    }
}
