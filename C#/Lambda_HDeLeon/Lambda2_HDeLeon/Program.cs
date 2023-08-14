using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda2_HDeLeon
{
    class Program
    {
        static void Main(string[] args)
        {/*
            var beer = new Beer() { Name = "Minerva", Country = "México" };
            Console.WriteLine(validator.Validate(beer, BeerValidations.validations));
            Console.ReadKey();*/

            Func<int, double, double> Numerole = (numero1, numero2) => numero1* numero2;
            Console.WriteLine(Numerole(4,5.6d));
            Console.ReadKey();
        }
    }

    /*
    public class BeerValidations
    {
        public static readonly Predicate<Beer>[] validations =
        {
            (d) => d.Name != null,
            (d) => d.Country != null,
            (d) =>d.Name.Count()<10,
            (d)=> d.Country.Count()<5,
        };
    }

    public class validator
    {
        public static bool Validate(Beer beer, params Predicate<Beer>[] validations) =>
            validations.ToList().Where(d =>
            {
                return !d(beer);

            }).Count() == 0;

    }

    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }

    */
}
