namespace DecoratorPatternPizza.PizzaMenu
{
    public class LargePhoto: Photo
    {
        public LargePhoto(string fromurl, string tourl)
        {
            Name = "Large Photo";
        }
        public override string GetName()
        {
            return Name;
        }

        public override double CalCulateCost()
        {
            return 9.0;
        }
    }
}
