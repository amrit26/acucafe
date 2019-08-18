using System.Collections.Generic;

namespace AcuCafe.Logic.Services.Abstract
{
    public interface IService
    {
        List<string> ListOfDrinks();
        List<string> ListOfToppings();
    }
}
