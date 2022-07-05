using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sampleclasslibrary;


namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Calc mycalc = new Calc();

        [HttpGet("/average")]
        public int Average([FromQuery] int[] nums)
        {
           return mycalc.Average(nums);
        }

        [HttpGet("/smallest")]
        public int Smallest([FromQuery] int[] nums)
        {
           return mycalc.Smallest(nums);
        }

        [HttpGet("/largest")]
        public int Largest([FromQuery] int[] nums)
        {
           return mycalc.Largest(nums);

        }
    }
}
