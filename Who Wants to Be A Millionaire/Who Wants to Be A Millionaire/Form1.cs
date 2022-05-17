using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Who_Wants_to_Be_A_Millionaire
{
    public partial class Form1 : Form
    {
        private string answer;
        private int score;
        private bool isOnMenu = true;

        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public void VisualFix()
        {
            Application.EnableVisualStyles();

            this.SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);

            ScoreLabel.Font = new Font("Tahoma", 8, FontStyle.Bold);
            ScoreLabel.Parent = pictureBox1;
            ScoreLabel.Refresh();
        }

        public void ResetElements()
        {
            QuestionLabel.AutoSize = false;
            QuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
            QuestionLabel.Dock = DockStyle.Fill;
            QuestionLabel.Font = new Font("Tahoma", 10, FontStyle.Bold);
            QuestionLabel.Text = "";

            AnswerLabel1.AutoSize = false;
            AnswerLabel1.TextAlign = ContentAlignment.MiddleCenter;
            AnswerLabel1.Dock = DockStyle.Fill;
            AnswerLabel1.Font = new Font("Tahoma", 8, FontStyle.Bold);
            AnswerLabel1.ForeColor = Color.White;
            AnswerLabel1.Text = "";

            AnswerLabel2.AutoSize = false;
            AnswerLabel2.TextAlign = ContentAlignment.MiddleCenter;
            AnswerLabel2.Dock = DockStyle.Fill;
            AnswerLabel2.Font = new Font("Tahoma", 8, FontStyle.Bold);
            AnswerLabel2.ForeColor = Color.White;
            AnswerLabel2.Text = "";

            AnswerLabel3.AutoSize = false;
            AnswerLabel3.TextAlign = ContentAlignment.MiddleCenter;
            AnswerLabel3.Dock = DockStyle.Fill;
            AnswerLabel3.Font = new Font("Tahoma", 8, FontStyle.Bold);
            AnswerLabel3.ForeColor = Color.White;
            AnswerLabel3.Text = "";

            AnswerLabel4.AutoSize = false;
            AnswerLabel4.TextAlign = ContentAlignment.MiddleCenter;
            AnswerLabel4.Dock = DockStyle.Fill;
            AnswerLabel4.Font = new Font("Tahoma", 8, FontStyle.Bold);
            AnswerLabel4.ForeColor = Color.White;
            AnswerLabel4.Text = "";
        }

        public void InitializeMenu()
        {
            QuestionLabel.Text = "Welcome to \"Who Wants To Be A Millionaire\"!";
            AnswerLabel1.Text = "Start Game";
            AnswerLabel2.Text = "Add your own questions";
            AnswerLabel3.Text = "About";
            AnswerLabel4.Text = "Exit Game";
            ScoreLabel.Text = "";
        }

        public void NextQuestion()
        {
            score++;
            ScoreLabel.Text = "Score: " + score.ToString();

            QuestionLabel.Text = QuestionReader.getNext();
            AnswerLabel1.Text = QuestionReader.getNext();
            AnswerLabel2.Text = QuestionReader.getNext();
            AnswerLabel3.Text = QuestionReader.getNext();
            AnswerLabel4.Text = QuestionReader.getNext();
            answer = QuestionReader.getNext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VisualFix();
            ResetElements();
            InitializeMenu();

            this.score = -1;
            QuestionReader.readFile(@"data/questions.dat");

            // play theme song
            System.IO.Stream str = Properties.Resources.theme;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.PlayLooping();
        }

        private void ClickOnAnswer(Object sender, EventArgs eventArgs)
        {
            if (isOnMenu)
            {
                if (((Label)sender).Text == "Start Game") {
                    // play "thinking" song
                    System.IO.Stream str = Properties.Resources.song;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.PlayLooping();

                    NextQuestion();
                    isOnMenu = false;
                }
                else if (((Label)sender).Text == "Add your own questions")
                {
                    MessageBox.Show("The game features only a short set of basic questions.\nIn order to implement your own question set, you'll need to replace the \"questions.dat\" file from the \"data\" folder.\nYou should add each question, answer and correct answer on a different line.\nThe file structure should be of the following:\n<Line 1> Question text\n<Line 2> First answer\n<Line 3> Second Answer\n<Line 4>Third Answer\n<Line 5>Fourth Answer\n<Line 6>Correct Answer\nThe correct answer should be one of the four answers above, duplicated. Add every line without the <>.", "Who Wants To Be A Millionaire", MessageBoxButtons.OK);
                }
                else if (((Label)sender).Text == "About")
                {
                    MessageBox.Show("\"Who Wants To Be A Millionaire\" version 1.00\nLast updated on May 17 2022\nCreated by Mateaș Mario\nFor more updates or apps, visit https://github.com/mateasmario/", "Who Wants To Be A Millionaire", MessageBoxButtons.OK);
                }
                else if (((Label)sender).Text == "Exit Game") {
                    Application.Exit();
                }
            }
            else
            {
                if (((Label)sender).Text == answer)
                {
                    Console.WriteLine("YES!");
                }
                else
                {
                    DialogResult diagRes = MessageBox.Show("Incorrect answer. The correct answer was \"" + answer + "\".", "Who Wants To Be A Millionaire", MessageBoxButtons.OK);
                    if (diagRes == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                NextQuestion();
            }
        }

        private new void MouseEnter(Object sender, EventArgs eventArgs)
        {
            ((Label)sender).ForeColor = Color.Orange;
        }        
        
        private new void MouseLeave(Object sender, EventArgs eventArgs)
        {
            ((Label)sender).ForeColor = Color.White;
        }

    }
}
