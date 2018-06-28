namespace DecoratorPatternPizza.PizzaMenu
{
    public class MediumPhoto: Photo
    {
        public MediumPhoto()
        {
            Name = "Medium Pizza";
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
