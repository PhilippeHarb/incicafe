using incicafe.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace incicafe.dal
{
  
    class CoffeeInitializer 
    {
        public static void Initialize(CoffeeContext context)
        {
            context.Database.EnsureCreated();

            if (context.Coffees.Any())
            {
                return;

            }
            var coffees = new CoffeeDto[]
                {
                    new CoffeeDto{name = "Cappuccino"},
                    new CoffeeDto{name = "Latte"}


                };
            foreach(CoffeeDto c in coffees)
            {
                context.Coffees.Add(new Entities.Coffee() {  Name = c.name});
                context.SaveChanges();
            }

        }


      
    }
}