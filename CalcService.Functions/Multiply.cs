using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using CalcService.Core;

namespace CalcService.Functions
{
    public static class Multiply
    {
        private static Calculator _calculator = new Calculator();

        [FunctionName("Multiply")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "Multiply/{a}/{b}")] HttpRequest req,
            int a, int b,
            ILogger log)
        {
            int result = _calculator.Multiply(a, b);

            log.LogInformation($"Multiply function received a request to Multiply {a} * {b}. The result is {result}");

            return new OkObjectResult(result);
        }
    }
}
