namespace PSTargetSistemas.Tests
{
    
    public class DistriburionCompanyTests
    {
        [Fact]
        public void CalculatePercentageOfSalesTest()
        {
            var company = new DistributionCompany();
            var monthlySales = new Dictionary<string, double>()
            {
                {"SP", 67836.43},
                {"RJ", 36678.66},
                {"MG", 29229.88},
                {"ES", 27165.48},
                {"Outros", 19849.53}
            };

            var percentageOfSales = company.CalculatePercentageOfSales(monthlySales);

            Assert.Equal(0.3753, percentageOfSales["SP"], 4);
            Assert.Equal(0.2029, percentageOfSales["RJ"], 4);
            Assert.Equal(0.1617, percentageOfSales["MG"], 4);
            Assert.Equal(0.1503, percentageOfSales["ES"], 4);
            Assert.Equal(0.1098, percentageOfSales["Outros"], 4);
        }
    }
}
