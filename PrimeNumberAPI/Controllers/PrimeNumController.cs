using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeNumberAPI.Model;
namespace PrimeNumberAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimeNumController : ControllerBase
    {
        PrimeInfo PI = new PrimeInfo();

        [Route("{num}")]
        public ActionResult<bool> Get(long num)
        {
            return PI.IsPrime(num);
        }

        // POST: api/Prime
        [Route("{num1}/{num2}")]
        public ActionResult<long> getToFrom(long num1, long num2)
        {
            return PI.getPrimes(num1, num2);
        }

        // POST: api/PrimeNum
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PrimeNum/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
