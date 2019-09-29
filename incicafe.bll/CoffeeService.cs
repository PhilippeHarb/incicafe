using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace incicafe.bll
{
    public class CoffeeService : ICoffeeService
    {
        public IEnumerable<CoffeeDto> GetCoffees(CancellationToken tk)
        {
            var coffees = new List<CoffeeDto>();
            coffees.Add(new CoffeeDto { name = "Cappucino" });
            return coffees;

        }

        
    }
}
