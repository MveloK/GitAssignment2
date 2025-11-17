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
            ("XL", 40),
            ("L", 50),
            ("XC", 90),
            ("C", 100),
            ("CD", 400),
            ("D", 500),
            ("CM", 900),
            ("M", 1000)
        };

        public static string Converter(int num)
        {
            if (num == 0 || num >= 3001)
            {
                throw new ArgumentOutOfRangeException(nameof(num), "Out of range.");
            }

            if (num == 4) return "IV";
            if (num == 9) return "IX";

            var roman = NumeralList.FirstOrDefault(n => n.Value == num);
            if (roman != default)
                return roman.Numeral;

            var result = "";

            var valuesDesc = new List<(string Numeral, int Value)>
            {
                ("M", 1000),
                ("CM", 900),
                ("D", 500),
                ("CD", 400),
                ("C", 100),
                ("XC", 90),
                ("L", 50),
                ("XL", 40),
                ("X", 10),
                ("IX", 9),
                ("V", 5),
                ("IV", 4),
                ("I", 1)
            };

            

            foreach (var item in valuesDesc)
            {
                while (num >= item.Value)
                {
                    result += item.Numeral;
                    num -= item.Value;
                }
            }

            return result;
        }
    }
}
