using System;

namespace incicafe.bll
{
    public class CoffeeDto
    {
       

        public string name { get; set; }
        public CoffeeDto(string name)
        {
            this.name = name;
        }
        
    }
}
