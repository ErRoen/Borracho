using System;
using Borracho.AzureFunction.Models;

namespace Borracho.AzureFunction.BizLogic
{
    public static class CocktailExtensions
    {
        public static Cocktail ScaleIt(this Cocktail cocktail, decimal numberOfServings)
        {
            if (numberOfServings == 1)
                return cocktail;

            foreach (var ingredient in cocktail.Ingredients)
            {
                var workingAmount = ingredient.Amount * numberOfServings;
                var workingMeasurement = ingredient.Measurement;

                var newMeasurement = workingMeasurement.DetermineAppropriateMeasurement(workingAmount);
                var newAmount = workingAmount.ConvertAmount(workingMeasurement, newMeasurement);

                ingredient.Amount = newAmount;
                ingredient.Measurement = newMeasurement;
            }
            return cocktail;
        }
    }

    public static class DecimalExtensions
    {
        public static decimal ToNearestQuarter(this decimal input)
        {
            var nearestQuarter = Math.Round(input * 4, MidpointRounding.ToEven) / 4;
            return nearestQuarter;
        }
    }
}
