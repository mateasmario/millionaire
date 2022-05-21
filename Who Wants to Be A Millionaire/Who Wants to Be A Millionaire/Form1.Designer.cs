namespace Who_Wants_to_Be_A_Millionaire
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.FailureLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.AnswerLabel4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AnswerLabel3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AnswerLabel2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AnswerLabel1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(47, 13);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(381, 256);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Randomize questions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(427, 237);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Allow failures";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // FailureLabel
            // 
            this.FailureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FailureLabel.AutoSize = true;
            this.FailureLabel.BackColor = System.Drawing.Color.Transparent;
            this.FailureLabel.ForeColor = System.Drawing.Color.White;
            this.FailureLabel.Location = new System.Drawing.Point(12, 25);
            this.FailureLabel.Name = "FailureLabel";
            this.FailureLabel.Size = new System.Drawing.Size(55, 13);
            this.FailureLabel.TabIndex = 7;
            this.FailureLabel.Text = "Failures: 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 215);
            this.panel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.AnswerLabel4);
            this.panel6.Location = new System.Drawing.Point(277, 143);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(219, 46);
            this.panel6.TabIndex = 5;
            // 
            // AnswerLabel4
            // 
            this.AnswerLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerLabel4.AutoSize = true;
            this.AnswerLabel4.BackColor = System.Drawing.Color.Transparent;
            this.AnswerLabel4.ForeColor = System.Drawing.Color.White;
            this.AnswerLabel4.Location = new System.Drawing.Point(24, 15);
            this.AnswerLabel4.Name = "AnswerLabel4";
            this.AnswerLabel4.Size = new System.Drawing.Size(74, 13);
            this.AnswerLabel4.TabIndex = 1;
            this.AnswerLabel4.Text = "AnswerLabel4";
            this.AnswerLabel4.Click += new System.EventHandler(this.ClickOnAnswer);
            this.AnswerLabel4.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.AnswerLabel4.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.AnswerLabel3);
            this.panel5.Location = new System.Drawing.Point(37, 143);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 46);
            this.panel5.TabIndex = 4;
            // 
            // AnswerLabel3
            // 
            this.AnswerLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerLabel3.AutoSize = true;
            this.AnswerLabel3.BackColor = System.Drawing.Color.Transparent;
            this.AnswerLabel3.ForeColor = System.Drawing.Color.White;
            this.AnswerLabel3.Location = new System.Drawing.Point(24, 15);
            this.AnswerLabel3.Name = "AnswerLabel3";
            this.AnswerLabel3.Size = new System.Drawing.Size(74, 13);
            this.AnswerLabel3.TabIndex = 1;
            this.AnswerLabel3.Text = "AnswerLabel3";
            this.AnswerLabel3.Click += new System.EventHandler(this.ClickOnAnswer);
            this.AnswerLabel3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.AnswerLabel3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.AnswerLabel2);
            this.panel4.Location = new System.Drawing.Point(277, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 46);
            this.panel4.TabIndex = 3;
            // 
            // AnswerLabel2
            // 
            this.AnswerLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerLabel2.AutoSize = true;
            this.AnswerLabel2.BackColor = System.Drawing.Color.Transparent;
            this.AnswerLabel2.ForeColor = System.Drawing.Color.White;
            this.AnswerLabel2.Location = new System.Drawing.Point(24, 15);
            this.AnswerLabel2.Name = "AnswerLabel2";
            this.AnswerLabel2.Size = new System.Drawing.Size(74, 13);
            this.AnswerLabel2.TabIndex = 1;
            this.AnswerLabel2.Text = "AnswerLabel2";
            this.AnswerLabel2.Click += new System.EventHandler(this.ClickOnAnswer);
            this.AnswerLabel2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.AnswerLabel2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.AnswerLabel1);
            this.panel3.Location = new System.Drawing.Point(37, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 46);
            this.panel3.TabIndex = 2;
            // 
            // AnswerLabel1
            // 
            this.AnswerLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerLabel1.AutoSize = true;
            this.AnswerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.AnswerLabel1.ForeColor = System.Drawing.Color.White;
            this.AnswerLabel1.Location = new System.Drawing.Point(24, 15);
            this.AnswerLabel1.Name = "AnswerLabel1";
            this.AnswerLabel1.Size = new System.Drawing.Size(74, 13);
            this.AnswerLabel1.TabIndex = 1;
            this.AnswerLabel1.Text = "AnswerLabel1";
            this.AnswerLabel1.Click += new System.EventHandler(this.ClickOnAnswer);
            this.AnswerLabel1.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.AnswerLabel1.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.QuestionLabel);
            this.panel2.Location = new System.Drawing.Point(81, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 59);
            this.panel2.TabIndex = 1;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel.ForeColor = System.Drawing.Color.White;
            this.QuestionLabel.Location = new System.Drawing.Point(239, 21);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(75, 13);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "QuestionLabel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(15, 256);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(104, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Enable logging";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(534, 516);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.FailureLabel);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Who Wants To Be A Millionaire";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label AnswerLabel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label AnswerLabel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label AnswerLabel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label AnswerLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label FailureLabel;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

