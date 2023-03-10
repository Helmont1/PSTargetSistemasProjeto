namespace PSTargetSistemas
{
    /// <summary>
    /// This class calculates the percentage of sales for each state in a given monthly sales data
    /// </summary>
    public class DistributionCompany
    {
        /// <summary>
        /// Calculates the percentage of sales for each state in the given monthly sales data
        /// </summary>
        /// <param name="monthlySales">The monthly sales data for each state as a dictionary with the state abbreviation as the key and the monthly sales amount as the value</param>
        /// <returns>A dictionary with the state abbreviation as the key and the percentage of sales as the value.</returns>
        public Dictionary<string, double> CalculatePercentageOfSales(Dictionary<string, double> monthlySales)
        {
            double totalSales = 0;
            foreach (var sale in monthlySales)
            {
                totalSales += sale.Value;
            }

            Dictionary<string, double> percentageOfSales = new Dictionary<string, double>();
            foreach (var sale in monthlySales)
            {
                percentageOfSales.Add(sale.Key, sale.Value / totalSales);
            }

            return percentageOfSales;
        }
    }
}
