﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakerDemo
{ 
    public class StarbuckStore
    {
      private readonly IMakeACoffee service;

    //readonly const

      public StarbuckStore(IMakeACoffee service)
      {
        this.service = service;
      }

      public string OrderCoffee(int sugarPerSpoon, int coffeeCount)
      {
        if (service.CheckIngredientAvailability())
        {
            return service.CoffeeMaking(sugarPerSpoon, coffeeCount);
        }
        else
        {
            return "Sorry! Coffee is not available.";
        }
      }

    }
}

