using Newtonsoft.Json;

namespace PSTargetSistemas.Tests
{
    public class DailyBillingTests
    {
        
        public List<DailyBilling> dailyBillings = JsonConvert.DeserializeObject<List<DailyBilling>>(File.ReadAllText("data.json"));

        [Theory]
        [InlineData(373.7838)]

        public void TestCalculatesLowestBilling(double expected)
        {
            DailyBilling dailyBilling = new DailyBilling();
            double actual = dailyBilling.CalculatesLowestBilling(dailyBillings);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(48924.2448)]

        public void TestCalculatesHighestBilling(double expected)
        {
            DailyBilling dailyBilling = new DailyBilling();
            double actual = dailyBilling.CalculatesHighestBilling(dailyBillings);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10)]
        public void TestCalculatesNumberOfDaysAboveAverage(int expected)
        {
            DailyBilling dailyBilling = new DailyBilling();
            int actual = dailyBilling.CalculatesNumberOfDaysAboveAverage(dailyBillings);
            Assert.Equal(expected, actual);
        }
    }
}
