namespace Borracho.AzureFunction.Models
{
    public class Ingredient
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public Measurement Measurement { get; set; }
    }
}