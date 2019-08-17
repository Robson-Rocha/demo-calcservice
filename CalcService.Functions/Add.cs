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
    public static class Add
    {
        private static Calculator _calculator = new Calculator();

        [FunctionName("Add")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "Add/{a}/{b}")] HttpRequest req,
            int a, int b,
            ILogger log)
        {
            int result = _calculator.Add(a, b);

            log.LogInformation($"Add function received a request to Add {a} + {b}. The result is {result}");

            return new OkObjectResult(result);
        }
    }
}
