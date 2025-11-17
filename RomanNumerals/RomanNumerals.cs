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
           
            if (num <= 0 || num >= NumeralList.Count)
            {
                throw new ArgumentException("False");
            }

            return NumeralList[num].Numeral.ToString();
        



    }
    }
}
