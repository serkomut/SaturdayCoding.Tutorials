using System;
using NUnit.Framework;

namespace MyTeamBuild.Laptop
{
    [TestFixture]
    public class TestLaptop
    {
        [Test]
        public void LaptopTest()
        {
            BuilderDirector director;

            director = new BuilderDirector((new HighSpeedNotebook()));
            NotebookProduct highSpeedNotebook = director.BuildNotebook();
            PrintProductDetail(highSpeedNotebook);

            director = new BuilderDirector((new StandartNotebook()));
            NotebookProduct standartSpeedNotebook = director.BuildNotebook();
            PrintProductDetail(standartSpeedNotebook);

            Console.ReadLine();
        }

        public static void PrintProductDetail(NotebookProduct product)
        {
            Console.WriteLine("GraphicCard: " + product.ProductDisplayEnvironment.GraphicCard);
            Console.WriteLine("ScreenWide: " + product.ProductDisplayEnvironment.ScreenWide);
            Console.WriteLine("ScreenResolution: " + product.ProductDisplayEnvironment.ScreenResolution);
            Console.WriteLine("Processor: " + product.ProductOEMEnvironment.Processor);
            Console.WriteLine();
        }
    }
}
