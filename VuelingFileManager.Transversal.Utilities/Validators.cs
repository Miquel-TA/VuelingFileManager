using System;
using System.Linq;
using VuelingFileManager.Transversal.Utilities.Models;

namespace VuelingFileManager.Transversal.Utilities
{
    public static class Validators
    {
        public static bool VerifyDateTime(DateTime birthday, int minimumStudentAge)
        {
            if (birthday < DateTime.Now.AddYears(-120) || birthday > DateTime.Now.AddYears(-minimumStudentAge))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool VerifyFormat(object unsafeFileFormat)
        {
            if (unsafeFileFormat != null && unsafeFileFormat is FileType)
            {
                return true;   
            }
            else
            {
                return false;
            }
        }

        public static bool VerifyName(string name)
        {
            if (name.Length == 0 || name.Length > 100) return false;

            foreach (char letter in name)
            {
                bool valid = 
                    (letter >= 'A' && letter <= 'Z') ||
                    (letter >= 'a' && letter <= 'z') ||
                    letter == '\'' ||
                    letter == '.' ||
                    letter == ',' ||
                    letter == ' ' ||
                    letter == '-' ||
                    letter >= 160;

                if (!valid)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
