﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakerDemo
{
    public class Starbucks : IMakeACoffee
    {
        public bool CheckIngredientAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugerPerSpoon, int CoffeePack)
        {
            throw new NotImplementedException();
        }
    }

    public class StubStarbucks : IMakeACoffee
    {
        public bool CheckIngredientAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugerPerSpoon, int CoffeePack)
        {
            return "Your order is received.";
        }
    }
}

