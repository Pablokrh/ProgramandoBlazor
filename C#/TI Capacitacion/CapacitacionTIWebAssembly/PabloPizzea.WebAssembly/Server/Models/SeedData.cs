using PabloPizzea.Shared;

namespace PabloPizzea.Server.Models
{
    public static class SeedData
    {
        //Datos de prueba:
        public static void Initialize(PizzaStoreContext context)
        {
            var Specials = new PizzaSpecial[]
            {
                new PizzaSpecial()
                {
                    Name="Pizza Napolitana",
                    Description="Tomate, aho y albahaca",
                    BasePrice=1850,
                    ImageUrl="/images/Pizzas/napolitana.png"
                },

                 new PizzaSpecial()
                {
                    Name="Pizza de Jamón y Morrón",
                    Description="Jamón, morrón y orégano al oliva",
                    BasePrice=2200,
                    ImageUrl="/images/Pizzas/JamonMorron.png"
                }, new PizzaSpecial()
                {
                    Name="Pizza Fugazzetta",
                    Description="Cebolla con lluvia de quesos, al orégano",
                    BasePrice=2000,
                    ImageUrl="/images/Pizzas/Fugazzetta.png"
                }, new PizzaSpecial()
                {
                    Name="Pizza Peperoni",
                    Description="Salame y ajo, picante",
                    BasePrice=2300,
                    ImageUrl="/images/Pizzas/napolitana.png"
                }, new PizzaSpecial()
                {
                    Name="Pizza Muzzarella",
                    Description="Salsa de tomate y extra queso muzzarella",
                    BasePrice=1700,
                    ImageUrl="/images/Pizzas/Muzzarella.png"
                },
            };
    
            context.Specials.AddRange(Specials);
            context.SaveChanges();

        }
    }
}
