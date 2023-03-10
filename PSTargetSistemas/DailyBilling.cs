using Newtonsoft.Json;

namespace PSTargetSistemas
{
    /// <summary>
    /// This class represents the DailyBilling object and its associated methods for calculations.
    /// </summary>
    public class DailyBilling
    {
        [JsonProperty("dia")]
        public int Day { get; set; }
        [JsonProperty("valor")]
        public double Value { get; set; }

        /// <summary>
        /// Calculates the lowest billing amount from a list of daily billings.
        /// </summary>
        public double CalculatesLowestBilling(List<DailyBilling> dailyBillings)
        {
            var lowestBilling = dailyBillings.Where(x => x.Value != 0).Min(x => x.Value);
            return lowestBilling;
        }
        
        /// <summary>
        /// Calculates the highest billing amount from a list of daily billings.
        /// </summary>
        public double CalculatesHighestBilling(List<DailyBilling> dailyBillings)
        {
            var highestBilling = dailyBillings.Where(x => x.Value != 0).Max(x => x.Value);
            return highestBilling;
        }
        
        /// <summary>
        /// Calculates the number of days with billing amounts above the average of a list of daily billings.
        /// </summary>
        public int CalculatesNumberOfDaysAboveAverage(List<DailyBilling> dailyBillings)
        {
            double average = 0;
            int numberOfDaysAboveAverage = 0;

            foreach (var dailyBilling in dailyBillings)
            {
                average += dailyBilling.Value;
            }
            average = average / dailyBillings.Where(x => x.Value != 0).Count();

            foreach (var dailyBilling in dailyBillings)
            {
                if (dailyBilling.Value > average)
                {
                    numberOfDaysAboveAverage++;
                }
            }
            return numberOfDaysAboveAverage;
        }
    }
}
