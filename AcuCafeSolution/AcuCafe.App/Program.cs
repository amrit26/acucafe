using AcuCafe.Logic;
using AcuCafe.Logic.Constants;
using AcuCafe.Logic.Services.Concrete;
using System;
using System.Collections.Generic;

namespace AcuCafe.App
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine($"{Message.TypeInput} drink.");
            var service = new Service();
            var drinks = service.ListOfDrinks();
            DisplayContents(drinks);
            var drinkSelected = Console.ReadLine();
            var isDrinkValid = Validation.IsInputValid(drinkSelected);

            if (isDrinkValid)
            {
                Validation.IsDrinkSelectedOnTheList(drinkSelected);
                Console.WriteLine(Message.ToppingQuestion);
                var doYouWantATopping = Console.ReadLine();
                var yesToTopping = Validation.IsInputValid(doYouWantATopping);
                if (yesToTopping && doYouWantATopping == "1")
                {
                    var toppings = service.ListOfToppings();
                    DisplayContents(toppings);
                    Console.WriteLine($"{Message.TypeInput} topping.");
                    var toppingSelected = Console.ReadLine();
                    var isToppingValid = Validation.IsInputValid(Console.ReadLine());
                    if (isToppingValid)
                    {
                        var toppingOnTheList = Validation.IsToppingSelectedOnTheList(toppingSelected);
                        if (toppingOnTheList)
                        {
                            Console.WriteLine(Message.ThankYou);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(Message.ThankYou);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine(Message.ThankYou);
                Console.ReadLine();
            }
        }

        public static void DisplayContents(List<string> listToDisplay)
        {
            foreach (var item in listToDisplay)
            {
                Console.WriteLine(item);
            }
        }
    }
}
