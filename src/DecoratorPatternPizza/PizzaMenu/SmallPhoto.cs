namespace DecoratorPatternPizza.PizzaMenu
{
    public class SmallPhoto: Photo
    {
        public SmallPhoto()
        {
            Name = "Small Pizza";
        }

        public override string GetName()
        {
            return Name;
        }

        public override double CalCulateCost()
        {
            return 6.0;
        }
    }
}
