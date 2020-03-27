using System.Collections.Generic;
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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Borracho.AzureFunction
{
    public static class ListDrinksByIngredient
    {
        [FunctionName("ListDrinksByIngredient")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
            HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var qsIngredients = (string)req.Query["ingredients"];
            var ingredients = qsIngredients.Split(',');

            var cocktails = CocktailList
                .GetCocktails()
                .Where(c => CheckForIngredient(c, ingredients))
                .Select(c => c.Name);

            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            var json = JsonConvert.SerializeObject(cocktails, new StringEnumConverter());

            return new OkObjectResult(json);
        }

        //private static bool CheckForIngredient(Cocktail c, string requestedIngredients)
        //{
        //    return c.Ingredients
        //        .Select(i => i.Name)
        //        .Contains(requestedIngredients, StringComparer.InvariantCultureIgnoreCase);
        //}

        private static bool CheckForIngredient(Cocktail cocktail, IReadOnlyCollection<string> requestedIngredients)
        {
            var cocktailIngredients = cocktail.Ingredients.Select(i => i.Name);

            var matchCount = requestedIngredients
                .Intersect(cocktailIngredients, new StringContainsComparer())
                .ToList()
                .Count;

            return matchCount == requestedIngredients.Count;
        }
    }
}
