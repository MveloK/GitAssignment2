namespace RomanNumerals
{
    public class RomanNumerals
    {
        public static string Converter(int num)
        {
            if (num == 1)
            {
                return "I";
            }
            else if (num == 2)
            {
                return "II";
            }
            else if (num == 3)
            {
                return "III";
            }
            else
            {
                throw new ArgumentException("False");
            }

            //Because using If else for all the numbers is time consuming I'll be switching over to a list or dictionary



        }
    }
}
