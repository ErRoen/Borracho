using System.Linq;
using System.Threading.Tasks;
using Borracho.AzureFunction.BizLogic;
using Borracho.AzureFunction.Cocktails;
using Borracho.AzureFunction.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Borracho.AzureFunction
{
    public static class GetRecipe
    {
        [FunctionName("GetRecipe")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
            HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];
            var servings = GetServings(req.Query["servings"]);

            if (name == null)
                return new BadRequestObjectResult("Please pass a name on the query string or in the request body");

            var comparer = new StringContainsComparer();

            var cocktails =
                CocktailList.GetCocktails()
                    .Where(c => CompareNames(c, name, comparer))
                    .Select(cocktail1 => cocktail1.ScaleIt(servings));

            var json = JsonConvert.SerializeObject(cocktails, new StringEnumConverter());

            return new OkObjectResult(json);
        }

        private static bool CompareNames(Cocktail c, string name, StringContainsComparer comparer)
        {
            return comparer
                .Equals(c.Name, name);
        }

        private static decimal GetServings(StringValues stringValues)
        {
            var tryParse = decimal.TryParse(stringValues, out var servings);
            if (!tryParse || servings == 0)
                servings = 1;
            return servings;
        }
    }
}
