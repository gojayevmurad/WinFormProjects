using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    static public class FileHandler
    {
        private const string ERROR_FILENAME = "error.log";

        public static void ErrorLog(Exception ex)
        {
            using (StreamWriter writer = new StreamWriter(ERROR_FILENAME, true))
            {
                writer.WriteLine($"[Error Date : {DateTime.Now}]");
                writer.WriteLine($"[Message : {ex.Message}]");
                writer.WriteLine($"[StackTrace : {ex.StackTrace}]");
                writer.WriteLine();
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
