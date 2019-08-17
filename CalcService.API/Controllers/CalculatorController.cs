using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcService.Core;
using Microsoft.AspNetCore.Mvc;

namespace CalcService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly Calculator _calculator;

        public CalculatorController(Calculator calculator)
        {
            _calculator = calculator;
        }

        // GET api/calculator/add/{a}/{b}
        [HttpGet("add/{a}/{b}")]
        public ActionResult<int> Add(int a, int b)
        {
            return _calculator.Add(a, b);
        }

        // GET api/calculator/subtract/{a}/{b}
        [HttpGet("subtract/{a}/{b}")]
        public ActionResult<int> Subtract(int a, int b)
        {
            return _calculator.Subtract(a, b);
        }

        // GET api/calculator/multiply/{a}/{b}
        [HttpGet("multiply/{a}/{b}")]
        public ActionResult<int> Multiply(int a, int b)
        {
            return _calculator.Multiply(a, b);
        }

        // GET api/calculator/divide/{a}/{b}
        [HttpGet("divide/{a}/{b}")]
        public ActionResult<int> Divide(int a, int b)
        {
            return _calculator.Divide(a, b);
        }
    }
}
