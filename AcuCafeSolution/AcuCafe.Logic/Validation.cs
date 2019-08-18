using System;

namespace AcuCafe.Logic
{
    public static class Validation
    {
        public static bool IsInputValid(string userInput)
        {
            return int.TryParse(userInput, out _) && Convert.ToInt32(userInput) > 0;
        }

        public static bool IsDrinkSelectedOnTheList(string drinkSelected)
        {
            switch (drinkSelected)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                    return true;
            }
            return false;
        }

        public static bool IsToppingSelectedOnTheList(string toppingSelected)
        {
            switch (toppingSelected)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    return true;
            }
            return false;
        }
    }
}
