using Xunit;
using RomanNumerals; 

namespace RomanNumeralsTest
{
    public class RomanNumeralsTest
    {
        [Fact]
        public void Roman_Numeral_1()
        {
           
            var result = RomanNumerals.RomanNumerals.Converter(1);

            Assert.Equal("I", result);
        }

        [Fact]
        public void Roman_Numeral_2()
        {

            var result = RomanNumerals.RomanNumerals.Converter(2);

            Assert.Equal("II", result);
        }

        [Fact]
        public void Roman_Numeral_3()
        {

            var result = RomanNumerals.RomanNumerals.Converter(3);

            Assert.Equal("III", result);
        }

    }
}
