using System.Collections;
using System.Diagnostics.PerformanceData;
using System.Drawing.Text;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace Hangman
{
    public partial class Form1 : Form
    {
        ArrayList wordList = new ArrayList() {"SCHOOL", "SOFTWARE", "CAMPUS"}; //List of words to be used in the game
        SortedList<string, int> highScoreList = new SortedList<string, int>(); //Sorted list for the word and its corrosponding score (Lowest amount of guess) will be stored here
        int chances; //Maximum number of incorrect guess a player gets each round
        string chosenWord = ""; //Word randomly picked by program for player
        string underscore = "_";
        string underscores;
        StringBuilder builtUnderscores;
        ArrayList incorrectLettersList = new ArrayList(); //Stores incorrect letters
        int correctGuesses = 0; //Keeps track of the number of correct guess
        int incorrectGuess = 0; //Keeps track of the number of incorrect guess
        bool gameStarted = false; //Is true when the player starts the game and false when the game stops
        int totGuesses = 0; //Total number of guess for each won game


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
        }
        //exitBtn method envoked when the exit button is clicked
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        //Function to create the underscores to be displayed upon starting the game
        private string underscoresCreator(int wordLength)
        {
            underscores = "";
            for (int i = 0; i < wordLength; i++)
            {
                underscores = underscores + underscore;
            }
            return underscores;
        }

        //startBtn method envoked when the start button is clicked
        private void startBtn_Click(object sender, EventArgs e)
        {
            chosenWord = pickName();
            underscores = underscoresCreator(chosenWord.Length);
            builtUnderscores = new StringBuilder(underscores); //Turns underscores string into mutable string
            wordDisplay.Text = underscores;
            //exitBtn.Visible = false;
            //startBtn.Visible = false;
            highScoreDisplayLabel.Visible = false;
            countdownLabel.Visible = true;
            incorrectLettersLabel.Visible = true;
            IncorrectLetters.Visible = true;
            IncorrectLetters.Focus();
            highScoreDisplay.Visible = false;
            chances = 10;
            countdownLabel.Text = $"Chances Left: {chances}";
            gameStarted = true;
            incorrectLettersList.Clear();
            IncorrectLetters.Items.Clear();
            startBtn.Text = "RESTART GAME";
            incorrectGuess = 0;
            correctGuesses = 0;
            totGuesses = 0;
            titleDisplay.Text = "HANGMAN";

        }
        //Function to pick a random word from wordList
        private string pickName()
        {
            Random random = new Random(); // Create a random function
            int num = random.Next(wordList.Count); // Generate a random integer in range with the amount of words in wordList
            string pickedWord = wordList[num].ToString(); // Pick a random word using the generated num as an index
            return pickedWord; // Return picked word
        }
        
        //Function envoked when a key is pressed
        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar; //Get the character pressed
            if (Char.IsLetter(key) && gameStarted == true) // Check if character is a letter
            {
                //MessageBox.Show(key.ToString());
                gameplay(key, builtUnderscores);
                
            }
            
        }
        private void gameplay(char key, StringBuilder builtUnderscores)
        {
            string strKey = key.ToString().ToUpper();
            //MessageBox.Show(strKey);
            if (chosenWord.Contains(strKey) && chances != 0) //Checks if the key exists in chosen word
            {
                //only increments if the letter has not already been guessed
                if (wordDisplay.Text.Contains(strKey) == false)
                {
                    correctGuesses++;
                }
                for (int n = 0; n < chosenWord.Length; n++) //If key does exist then change underscores to letters at the appropriate places
                {
                    if (chosenWord[n].ToString() == strKey)
                    {
                        builtUnderscores[n] = chosenWord[n];
                    }
                    wordDisplay.Text = builtUnderscores.ToString(); //Change the underscores to reflect correct guess
                }
                
            }
            else //Runs when the entered letter is not in chosen word
            {  
                //Adds the incorrect letter into a list of other incorrect letters
                if (incorrectLettersList.Contains(strKey) == false)
                {
                    incorrectLettersList.Add(strKey);
                    IncorrectLetters.Items.Add(strKey);
                    chances--;
                    incorrectGuess++;
                    countdownLabel.Text = $"Chances LEFT: {chances}";
                }
                //When the player is out of chances
                if (chances == 0)
                {
                    titleDisplay.Text = "GAME OVER";
                    wordDisplay.Text = chosenWord;
                    gameStarted = false;
                }
            }
            //When the player has guess the correct word
            if (wordDisplay.Text == chosenWord && chances > 0)
            {
                gameStarted = false;
                titleDisplay.Text = "YOU WON";
                startBtn.Text = "PLAY AGAIN";
                int totGuesses = correctGuesses + incorrectGuess;
                if (highScoreList.ContainsKey(chosenWord)) //Checks if the word already exists in the high score list
                {   //Updates the high score list 
                    if (highScoreList[chosenWord] > totGuesses)
                    {
                        highScoreList[chosenWord] = totGuesses;
                        MessageBox.Show($"Congratulations new high score for {chosenWord}");
                    }
                }
                else
                {
                    highScoreList.Add(chosenWord, totGuesses);
                }
                displayHighScore();
            }
        }
        
        //Displays the highscores
        private void displayHighScore()
        {
            highScoreDisplay.Items.Clear();
            highScoreDisplay.Visible = true;
            highScoreDisplayLabel.Visible = true;
            countdownLabel.Visible = false;
            foreach (var word in highScoreList)
            {

                string key = word.Key;
                int value = word.Value;
                highScoreDisplay.Items.Add($"{key}: {value}");
            }
        }
    }
}