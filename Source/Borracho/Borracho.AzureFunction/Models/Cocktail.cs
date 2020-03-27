using System.Collections.Generic;

namespace Borracho.AzureFunction.Models
{
    public class Cocktail
    {
        public string Name { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public IEnumerable<string> Instructions { get; set; }
    }
}
