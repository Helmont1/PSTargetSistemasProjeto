namespace PSTargetSistemas.Tests
{
    public class StringInverterTests
    {
        [Theory]
        [InlineData("teste", "etset")]
        [InlineData("targetsistemas", "sametsistegrat")]
        [InlineData("", "")]
        public void InvertTest(string input, string expected)
        {
            StringInverter stringInverter = new StringInverter();

            string output = stringInverter.Invert(input);
            Assert.Equal(expected, output);
        }
    }
}
