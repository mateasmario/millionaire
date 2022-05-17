using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Who_Wants_to_Be_A_Millionaire
{
    internal static class QuestionReader
    {
        private static IEnumerable<string> content;
        private static int currIndex = 0;
        
        public static void readFile(string path)
        {
            content = System.IO.File.ReadLines(path);
        }

        public static string getNext()
        {
            if (content == null)
                Application.Exit();

            string result;
            try
            {
                result = content.Skip(currIndex++).First();
                return result;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                DialogResult diagRes = MessageBox.Show("There are no more answers left. Seems that you finished the game!", "Who Wants To Be A Millionaire", MessageBoxButtons.OK);
                if (diagRes == DialogResult.OK)
                {
                    Application.Exit();
                }

                return null;
            }
        }

    }
}
