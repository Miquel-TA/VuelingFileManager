using System;
using System.Linq;

namespace VuelingFileManager.Transversal.Utilities
{
    public static class Validators
    {
        public static bool VerifyDateTime(DateTime birthday)
        {
            if (birthday < DateTime.Now.AddYears(-120) || birthday > DateTime.Now)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool VerifyFormat(string format)
        {
            string[] validFormats = { "TXT", "JSON", "XML" };

            return validFormats.Contains(format);
        }

        public static bool VerifyName(string name)
        {
            foreach (char letter in name)
            {
                // If letter is unicode or ASCII letters.
                bool valid = (letter >= 'A' && letter <= 'z') || letter >= 160;
                if (!valid)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
