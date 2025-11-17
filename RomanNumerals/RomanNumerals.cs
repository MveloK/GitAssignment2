namespace RomanNumerals
{
    public class RomanNumerals
    {
        private static readonly List<(string Numeral, int Value)> NumeralList = new List<(string Numeral, int Value)>
{
                            ("I", 1),
                            ("II", 2), 
                            ("III", 3), 
                            ("V", 5),
                            ("X", 10),
                            ("L", 50),
                            ("C", 100),
                            ("D", 500),
                            ("M", 1000)
};
        public static string Converter(int num)
        {

            var roman = NumeralList.FirstOrDefault(n => n.Value == num);

            if (roman == default)
                throw new ArgumentException("False");

            return roman.Numeral;




        }
    }
}
