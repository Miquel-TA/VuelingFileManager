using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingFileManager.Transversal.Utilities
{
    public static class Converters
    {
        public static int GetAgeFromBirthday(DateTime birthday)
        {
            var today = DateTime.Today;
            var age = today.Year - birthday.Year;

            if (birthday > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }

}
