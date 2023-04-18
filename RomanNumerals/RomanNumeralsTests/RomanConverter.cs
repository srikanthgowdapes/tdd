using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace RomanNumeralsTests
{
    internal class RomanConverter
    {
        public RomanConverter()
        {
        }

        internal string ConvertNumbertoRoman(int input)
        {
            var output = string.Empty;
            if (input > 9)
            {
                for (int i = 0; i < input / 10; i++)
                    output += "X";
            }

            if (input.ToString().EndsWith("4"))
            {
                output += "IV";
            }
            else if (input.ToString().EndsWith("5"))
            {
                output += "V";
            }
            else if (input.ToString().EndsWith("6"))
            {
                output += "VI";
            }
            else if (input.ToString().EndsWith("7"))
            {
                output += "VII";
            }
            else if (input.ToString().EndsWith("8"))
            {
                output += "VIII";
            }
            else if (input.ToString().EndsWith("9"))
            {
                output += "IX";
            }
            else
            {
                var numberInString = input.ToString();
                for (int i = 0; i < int.Parse(numberInString.Substring(numberInString.Length - 1)); i++)
                {
                    output += "I";
                }
            }

            return output;
        }
    }
}