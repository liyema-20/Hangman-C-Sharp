namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.highScoreDisplay = new System.Windows.Forms.ListBox();
            this.IncorrectLetters = new System.Windows.Forms.ListBox();
            this.wordDisplay = new System.Windows.Forms.Label();
            this.titleDisplay = new System.Windows.Forms.Label();
            this.incorrectLettersLabel = new System.Windows.Forms.Label();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.highScoreDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(323, 287);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(174, 80);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(323, 378);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(174, 77);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // highScoreDisplay
            // 
            this.highScoreDisplay.FormattingEnabled = true;
            this.highScoreDisplay.ItemHeight = 21;
            this.highScoreDisplay.Location = new System.Drawing.Point(52, 191);
            this.highScoreDisplay.Name = "highScoreDisplay";
            this.highScoreDisplay.Size = new System.Drawing.Size(177, 277);
            this.highScoreDisplay.TabIndex = 3;
            // 
            // IncorrectLetters
            // 
            this.IncorrectLetters.FormattingEnabled = true;
            this.IncorrectLetters.ItemHeight = 21;
            this.IncorrectLetters.Location = new System.Drawing.Point(629, 190);
            this.IncorrectLetters.Name = "IncorrectLetters";
            this.IncorrectLetters.Size = new System.Drawing.Size(147, 277);
            this.IncorrectLetters.TabIndex = 4;
            this.IncorrectLetters.Visible = false;
            this.IncorrectLetters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // wordDisplay
            // 
            this.wordDisplay.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordDisplay.Location = new System.Drawing.Point(280, 143);
            this.wordDisplay.Name = "wordDisplay";
            this.wordDisplay.Size = new System.Drawing.Size(269, 126);
            this.wordDisplay.TabIndex = 2;
            this.wordDisplay.Text = "PRESS START";
            this.wordDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleDisplay
            // 
            this.titleDisplay.Font = new System.Drawing.Font("Segoe Print", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleDisplay.Location = new System.Drawing.Point(204, -1);
            this.titleDisplay.Name = "titleDisplay";
            this.titleDisplay.Size = new System.Drawing.Size(443, 134);
            this.titleDisplay.TabIndex = 5;
            this.titleDisplay.Text = "HANGMAN";
            this.titleDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // incorrectLettersLabel
            // 
            this.incorrectLettersLabel.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incorrectLettersLabel.Location = new System.Drawing.Point(629, 106);
            this.incorrectLettersLabel.Name = "incorrectLettersLabel";
            this.incorrectLettersLabel.Size = new System.Drawing.Size(184, 81);
            this.incorrectLettersLabel.TabIndex = 6;
            this.incorrectLettersLabel.Text = "INCORRECT LETTERS";
            this.incorrectLettersLabel.Visible = false;
            // 
            // countdownLabel
            // 
            this.countdownLabel.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countdownLabel.Location = new System.Drawing.Point(12, 106);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(239, 204);
            this.countdownLabel.TabIndex = 8;
            this.countdownLabel.Text = "GUESSES LEFT: 10";
            this.countdownLabel.Visible = false;
            // 
            // highScoreDisplayLabel
            // 
            this.highScoreDisplayLabel.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highScoreDisplayLabel.Location = new System.Drawing.Point(45, 143);
            this.highScoreDisplayLabel.Name = "highScoreDisplayLabel";
            this.highScoreDisplayLabel.Size = new System.Drawing.Size(184, 37);
            this.highScoreDisplayLabel.TabIndex = 9;
            this.highScoreDisplayLabel.Text = "HIGH SCORES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 630);
            this.Controls.Add(this.highScoreDisplayLabel);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.incorrectLettersLabel);
            this.Controls.Add(this.titleDisplay);
            this.Controls.Add(this.IncorrectLetters);
            this.Controls.Add(this.highScoreDisplay);
            this.Controls.Add(this.wordDisplay);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.startBtn);
            this.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.ResumeLayout(false);

        }




        #endregion

        private Button startBtn;
        private Button exitBtn;
        private ListBox highScoreDisplay;
        private ListBox IncorrectLetters;
        private Label wordDisplay;
        private Label titleDisplay;
        private Label incorrectLettersLabel;
        private Label countdownLabel;
        private Label highScoreDisplayLabel;
    }
}