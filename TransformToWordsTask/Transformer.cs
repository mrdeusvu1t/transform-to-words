using System;
using System.Text;

#pragma warning disable CA1822

namespace TransformToWordsTask
{
    /// <summary>
    /// Provides transformer methods.
    /// </summary>
    public sealed class Transformer
    {
        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Words representation.</returns>
        public string TransformToWords(double number)
        {
            if (number is double.Epsilon)
            {
                return "Double Epsilon";
            }

            if (double.IsNaN(number))
            {
                return "NaN";
            }

            if (number == double.NegativeInfinity)
            {
                return "Negative Infinity";
            }

            if (number == double.PositiveInfinity)
            {
                return "Positive Infinity";
            }

            string result = "";

            char[] n = number.ToString().ToCharArray();

            for (int i = 0; i < n.Length; i++)
            {
                switch (n[i])
                {
                    case '0':
                        result += "zero";
                        break;
                    case '1':
                        result += "one";
                        break;
                    case '2':
                        result += "two";
                        break;
                    case '3':
                        result += "three";
                        break;
                    case '4':
                        result += "four";
                        break;
                    case '5':
                        result += "five";
                        break;
                    case '6':
                        result += "six";
                        break;
                    case '7':
                        result += "seven";
                        break;
                    case '8':
                        result += "eight";
                        break;
                    case '9':
                        result += "nine";
                        break;
                    case '+':
                        result += "plus";
                        break;
                    case '-':
                        result += "minus";
                        break;
                    case 'E':
                        result += "E";
                        break;
                    case ',':
                        result += "point";
                        break;
                }

                if (i < n.Length - 1)
                {
                    result += " ";
                }
            }

            var sb = new StringBuilder(result);
            sb[0] = char.ToUpper(sb[0]);
            result = sb.ToString();

            return result;
        }
    }
}
