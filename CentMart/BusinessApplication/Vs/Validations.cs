using System.Linq;

namespace BusinessApplication.Vs
{
    internal class Validations
    {
        public static bool isConvertableToInt(string s)
        {
            foreach (char c in s)
            {
                if ((int)c < 48 || (int)c > 57)
                {
                    return false;
                }
            }
            return true;
        }

        public static string toLowerCase(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if ((int)c >= 65 && (int)c <= 90)
                {
                    result += (char)((int)c + 32);
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        public static bool isValidPassword(string s)
        {
            if (s.Length < 8)
            {
                return false;
            }
            else
            {
                if (s.Any(char.IsDigit))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                return true;
            }
        }
        public static bool isConvertableToFloat(string s)
        {
            foreach (char c in s)
            {
                if (((int)c < 48 || (int)c > 57) && c != '.')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
