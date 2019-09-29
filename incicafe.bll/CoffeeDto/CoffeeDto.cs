using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace incicafe.bll
{
    public class CoffeeDto
    {

        public string name { get; set; }
 
        public ICollection<CoffeeDto> Coffees;
       
        
    }
}
