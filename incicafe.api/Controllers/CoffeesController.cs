using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using incicafe.bll;
using Microsoft.AspNetCore.Mvc;

namespace incicafe.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeesController : ControllerBase
    {
        // GET api/values
        private readonly ICoffeeService _CoffeeService;

        
        public CoffeesController(ICoffeeService _CoffeeService)
        {
            this._CoffeeService = _CoffeeService;
                
        }
        [HttpGet]
        public ActionResult<IEnumerable<CoffeeDto>> Get(CancellationToken tk)
        {
            var liste = _CoffeeService.GetCoffees(tk);
            return Ok(liste);
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
