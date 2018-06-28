namespace DecoratorPatternPizza.PizzaMenu
{
    public class PhotoDecoration: Photo
    {
        protected Photo _pizza;

        public PhotoDecoration(Photo pizza)
        {
            _pizza = pizza;
        }
        public override string GetName()
        {
            return _pizza.GetName();
        }

        public override double CalCulateCost()
        {
            return _pizza.CalCulateCost();
        }
    }
}
