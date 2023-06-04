using System.Windows.Forms;

namespace VuelingFileManager.Transversal.Utilities
{
    public static class SystemInteraction
    {
        public static void OpenFile(string filePath)
        {
            System.Diagnostics.Process.Start(filePath);
        }

        public static string SelectFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|XML files (*.xml)|*.xml|Text files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
