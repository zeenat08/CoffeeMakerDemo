using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakerDemo
{ 
    public interface IMakeACoffee
    {
            bool CheckIngredientAvailability();
            string CoffeeMaking(int sugerPerSpoon, int CoffeePack);
    }


}
   


