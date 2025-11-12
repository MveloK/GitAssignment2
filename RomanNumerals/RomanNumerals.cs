namespace RomanNumerals
{
    public class RomanNumerals
    {
        public static string Converter(int num)
        {
            if (num >= 1) {
                return "I";

            }
            else
            {
                throw new ArgumentException("False");
            }
        }
    }
}
