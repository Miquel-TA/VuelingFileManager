using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingFileManager.Transversal.Utilities
{
    public static class SystemInteraction
    {
        public static void OpenFile(string filePath)
        {
            System.Diagnostics.Process.Start(filePath);
        }
    }
}
