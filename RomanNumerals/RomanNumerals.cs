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
            
            if (num <= 0)
                throw new ArgumentException("False");

            if (num == 4) return "IV";
            if (num == 9) return "IX";

            var roman = NumeralList.FirstOrDefault(n => n.Value == num);
            if (roman != default)
                return roman.Numeral;

            var result = "";
            var valuesDesc = NumeralList.OrderByDescending(n => n.Value);

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
