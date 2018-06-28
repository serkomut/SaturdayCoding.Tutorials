using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyTeamBuild
{
    [TestFixture]
    public class TeamFixture
    {
        private static readonly TeamBuilder Tb = new TeamBuilder();

        private Team team =
            Tb.CreateTeam("Serol")
                .WithNickName("Sahte İsim")
                .WithShirtColor(Color.Blue)
                .FromTown("Türkiye")
                .PlayingAt("Adana Demir Spor")
                .Build();

        [Test]
        public void Buldr()
        {
            var tm = new TeamBuilder();
            var build = tm.CreateTeam("Serol")
                .WithNickName("Sahte İsim")
                .WithShirtColor(Color.Blue)
                .FromTown("Türkiye")
                .PlayingAt("Adana Demir Spor")
                .Build();
        }

        //public void PizzaTest()
        //{
        //    PizzaBuilder vBuilder;
        //    VedenikliKamil kamil = new VedenikliKamil();
        //    vBuilder = new BaharatliPizzaBuilder();

        //    kamil.Olustur(vBuilder);
        //    Console.WriteLine(vBuilder.Pizza.ToString());
        //    vBuilder = new DortMevsimPizzaBuilder();
        //    kamil.Olustur(vBuilder);
        //    Console.WriteLine(vBuilder.Pizza.ToString());
        //}

        public static string FormatCurrency(this decimal amount, string currencyCode)
        {
            var culture = (from c in CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                           let r = new RegionInfo(c.LCID)
                           where r != null
                           && r.ISOCurrencySymbol.ToUpper() == currencyCode.ToUpper()
                           select c).FirstOrDefault();

            if (culture == null)
                return amount.ToString("0.00");

            return string.Format(culture, "{0:C}", amount);
        }
    }
}
