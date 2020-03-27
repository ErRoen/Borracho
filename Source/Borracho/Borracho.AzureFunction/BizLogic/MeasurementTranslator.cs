using Borracho.AzureFunction.Models;

namespace Borracho.AzureFunction.BizLogic
{
    public static class MeasurementTranslator
    {
        //private static readonly Dictionary<Tuple<Measurement, Measurement>, decimal> Conversions =
        //    new Dictionary<Tuple<Measurement, Measurement>, decimal>
        //    {
        //        {Tuple.Create(Measurement.Cup, Measurement.Oz), 8M},
        //        {Tuple.Create(Measurement.Cup, Measurement.Teaspoon), 48M},
        //        {Tuple.Create(Measurement.Cup, Measurement.Dash), 384M},

        //        {Tuple.Create(Measurement.Oz, Measurement.Cup), .125M},
        //        {Tuple.Create(Measurement.Oz, Measurement.Teaspoon), 6M},
        //        {Tuple.Create(Measurement.Oz, Measurement.Dash), 48M},

        //        {Tuple.Create(Measurement.Teaspoon, Measurement.Cup), 0.0208333M},
        //        {Tuple.Create(Measurement.Teaspoon, Measurement.Oz), 0.166667M},
        //        {Tuple.Create(Measurement.Teaspoon, Measurement.Dash), 8M},

        //        {Tuple.Create(Measurement.Dash, Measurement.Cup), 0.002604167M},
        //        {Tuple.Create(Measurement.Dash, Measurement.Oz), 0.0278M},
        //        {Tuple.Create(Measurement.Dash, Measurement.Teaspoon), 0.125M},
        //    };

        //public static decimal ConvertAmount(this decimal amount, Measurement oldMeasurement, Measurement newMeasurement)
        //{
        //    if (oldMeasurement == newMeasurement)
        //        return amount;

        //    var tuple = Tuple.Create(oldMeasurement, newMeasurement);

        //    var conversionFound = Conversions
        //        .TryGetValue(tuple, out var conversionFactor);

        //    var convertMeasurementAmount = amount * conversionFactor;

        //    var cups = (amount / (int)oldMeasurement);
        //    var snarf = (cups * (int)newMeasurement).ToNearestQuarter();

        //    return conversionFound
        //        ? convertMeasurementAmount
        //        : throw new NotImplementedException();
        //}

        public static decimal ConvertAmount(this decimal amount, Measurement oldMeasurement, Measurement newMeasurement)
        {
            if (oldMeasurement == newMeasurement)
                return amount;

            var inCups = amount / (int)oldMeasurement;

            return (inCups * (int)newMeasurement)
                .ToNearestQuarter(); // Do we want to do this with larger measurements?
        }

        public static Measurement DetermineAppropriateMeasurement(this Measurement measurement, decimal amount)
        {
            var minCup = .25M;
            var minOz = .25M;
            var minTsp = .25M;

            return amount >= minCup.ConvertAmount(Measurement.Cup, measurement)
                ? Measurement.Cup
                : amount >= minOz.ConvertAmount(Measurement.Oz, measurement)
                    ? Measurement.Oz
                    : amount >= minTsp.ConvertAmount(Measurement.Teaspoon, measurement)
                        ? Measurement.Teaspoon
                        : Measurement.Dash;
        }
    }
}
