using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace incicafe.bll
{
    public interface ICoffeeService
    {
          IEnumerable<CoffeeDto> GetCoffees(CancellationToken tk);
       
    }
}
