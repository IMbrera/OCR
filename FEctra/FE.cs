using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace HistogramOCRTrainer.FEctra
{
    public static class FileExtras
    {
        /// <summary>
        /// load a file from a path into a string
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        public static string LoadFile(string filename)
        {
            var fs = new FileStream(filename, FileMode.Open);
            var sr = new StreamReader(fs);
            var filestr = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            return filestr;
        }

        /// <summary>
        /// Saves to file.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="text">The text.</param>
        /// <param name="append">if set to <c>true</c> [append].</param>
        /// <returns></returns>
        public static bool SaveToFile(string filename, string text, bool append = false)
        {
            var exist = "";
            if (append && File.Exists(filename))
                exist = LoadFile(filename);

            var fs = new FileStream(filename, FileMode.Create);
            var sw = new StreamWriter(fs);
            sw.Write(exist + Environment.NewLine);
            sw.Write(text);
            sw.Close();
            fs.Close();
            return true;
        }

     
    }
}