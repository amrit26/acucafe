using AcuCafe.Logic.Services.Abstract;
using System.Collections.Generic;

namespace AcuCafe.Logic.Services.Concrete
{
    public class Service : IService
    {
        public List<string> ListOfDrinks()
        {
            return new List<string>
            {
                $"1. {Constants.Drinks.Americano}",
                $"2. {Constants.Drinks.Cappuccino}",
                $"3. {Constants.Drinks.Espresso}",
                $"4. {Constants.Drinks.IceTea}",
                $"5. {Constants.Drinks.Latte}",
                $"6. {Constants.Drinks.Macchiato}",
                $"7. {Constants.Drinks.Tea}"
            };
        }

        public List<string> ListOfToppings()
        {
            return new List<string>
            {
                $"1. {Constants.Toppings.Chocolate}",
                $"2. {Constants.Toppings.Cinnamon}",
                $"3. {Constants.Toppings.FullFatMilk}",
                $"4. {Constants.Toppings.SemiSkimmedMilk}",
                $"5. {Constants.Toppings.WhiteChocolate}"
            };
        }
    }
}
