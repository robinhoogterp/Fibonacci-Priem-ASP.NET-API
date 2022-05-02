using Microsoft.AspNetCore.Mvc;

namespace Fibonacci_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetSpecialNumber : ControllerBase
    {
        

        [HttpGet(Name = "GetSpecialNumber")]
        public IActionResult Get(long number)
        {
            try
            {
                return Ok(SpecialNumbers.InFibonacci(number) + "\n" + SpecialNumbers.IsPrime(number));
            }
            catch (Exception ex)
            {
                return StatusCode(400);
            }
               
            
            
        }
    }
}