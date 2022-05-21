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
        private static string[] content;

        private static int currIndex = 0;
        private static int currPosIndex = 0;
        private static int length = 0;
        private static int noQuestions = 0;
        
        public static void readFile(string path)
        {
            content = System.IO.File.ReadLines(path).ToArray();

            // find length
            length = content.Length;
            noQuestions = length / 6;
        }

        public static string getNext()
        {
            if (content == null)
                Application.Exit();

            string result;
            try
            {
                result = content[currIndex++];
                return result;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                DialogResult diagRes = MessageBox.Show("There are no more questions left. Seems that you finished the game!", "Who Wants To Be A Millionaire", MessageBoxButtons.OK);
                Logger.writeTrace("No more questions left. Exiting game.");
                Logger.setStatus(false);
                if (diagRes == DialogResult.OK)
                    Application.Exit();

                return null;
            }
        }

        public static void Reshift(int pos)
        {
            for(int i = pos+1; i<length; i++)
                content[i - 1] = content[i];
        }

        public static string getNext(int pos)
        {
            if (length == 0)
            {
                DialogResult diagRes = MessageBox.Show("There are no more answers left. Seems that you finished the game!", "Who Wants To Be A Millionaire", MessageBoxButtons.OK);
                Logger.writeTrace("No more questions left. Exiting game.");
                Logger.setStatus(false);
                if (diagRes == DialogResult.OK)
                    Application.Exit();

                return null;
            }
            else
            {
                string result = content[pos];

                Reshift(pos + currPosIndex);
                length--;

                return result;
            }
        }

        public static void decreaseLength()
        {
            noQuestions--;
        }

        public static int getRandomPos()
        {
            Random rand = new Random();
            int result = rand.Next(noQuestions);
            return result * 6;
        }

        public static int getNoQuestions()
        {
            return noQuestions;
        }

    }
}
