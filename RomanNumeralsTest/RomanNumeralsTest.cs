using Xunit;
using RomanNumerals; 

namespace RomanNumeralsTest
{
    public class RomanNumeralsTest
    {
        [Fact]
        public void Roman_Numeral_1()
        {
           
            var result = RomanNumerals.RomanNumerals.Converter;

            Assert.Equal("I", result.ToString());
        }
    }
}
