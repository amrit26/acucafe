namespace AcuCafe.Logic
{
    public static class Validation
    {
        public static bool IsInputValid(string userInput)
        {
            return int.TryParse(userInput, out _);
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
