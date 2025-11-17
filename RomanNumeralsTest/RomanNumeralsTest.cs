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

        [Fact]
        public void Roman_Numeral_5()
        {

            var result = RomanNumerals.RomanNumerals.Converter(5);

            Assert.Equal("V", result);
        }

        [Fact]
        public void Roman_Numeral_0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            RomanNumerals.RomanNumerals.Converter(0));
        }

        [Fact]
        public void Roman_Numeral_4()
        {

            var result = RomanNumerals.RomanNumerals.Converter(4);

            Assert.Equal("IV", result);
        }

        [Fact]
        public void Roman_Numeral_9()
        {

            var result = RomanNumerals.RomanNumerals.Converter(9);

            Assert.Equal("IX", result);
        }

        [Fact]
        public void Roman_Numeral_10()
        {
            var result = RomanNumerals.RomanNumerals.Converter(10);

            Assert.Equal("X", result);
        }

        [Fact]
        public void Roman_Numeral_Basic_Construction()
        {
            var result = RomanNumerals.RomanNumerals.Converter(8);
            Assert.Equal("VIII", result); 
        }

        [Fact]
        public void Roman_Numeral_Repetition()
        {
            var result = RomanNumerals.RomanNumerals.Converter(4);

            Assert.NotEqual("IIII", result);
            Assert.Equal("IV", result);
        }

        [Fact]
        public void Roman_Numeral_Combining_Rules()
        {
            var result = RomanNumerals.RomanNumerals.Converter(1984);

            Assert.Equal("MCMLXXXIV", result);
        }

        [Fact]
        public void Roman_Numeral_3001_OutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                RomanNumerals.RomanNumerals.Converter(3001));
        }



    }
}
