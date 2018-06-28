namespace DecoratorPatternPizza.PizzaMenu
{
    public class Peppers: PhotoDecoration
    {
        public Peppers(Photo pizza) : base(pizza)
        {
            this.Name = "Peppers";
        }

        public override string GetName()
        {
            return string.Format("{0},{1}", _pizza.GetName(), this.Name);
        }

        public override double CalCulateCost()
        {
            return _pizza.CalCulateCost() + 0.75;
        }
    }
}
