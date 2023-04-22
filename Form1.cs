using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public static Stopwatch Stopwatch = new Stopwatch();
        private Random rand = new Random();
        private int hitCount = 0;
        private int missCount = 0;
        private int timeElapsed = 0;
        private int falseHitCount = 0;
        private int targetSize = 100;  // Initial size of the target button
        public Form1()
        {
            InitializeComponent();

            // Add a click event handler for the "Play again" button
            playAgainButton.Click += playAgainButton_Click;

            // Load the high score from the settings
            int highScore = Properties.Settings.Default.HighScore;

            // Display the high score
            highScoreLabel.Text = "High Score: " + highScore.ToString();

            // Add a click event handler for the false target button
            falseTargetButton.Click += falseTargetButton_Click;


            // Set the size of the target button
            targetButton.Size = new Size(targetSize, targetSize);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the background color of the button
            targetButton.BackColor = Color.Yellow;
            falseTargetButton.BackColor = Color.Red;

            // Set the font of the button
            targetButton.Font = new Font("Arial", 12, FontStyle.Bold);
            falseTargetButton.Font = new Font("Arial", 12, FontStyle.Bold);

            // Set the background image of the button
            targetButton.BackgroundImage = Properties.Resources.target_image;
            targetButton.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stopwatch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Stopwatch.Elapsed.ToString(@"hh\:mm\:ss");

            if (rand.Next(0, 10) < 5)
            {
                targetButton.Left = rand.Next(0, this.Width);
                targetButton.Top = rand.Next(0, this.Height);
                targetButton.Visible = true;
            }

            // Check if the game has ended
            if (timeElapsed >= 60 || missCount >= 3)
            {
                // End the game if time is up or if the player missed 3 times
                Stopwatch.Stop();
                targetButton.Visible = false;
                falseTargetButton.Visible = false;

                // Show the "Play again" button
                playAgainButton.Visible = true;

                // Update the high score if necessary
                if (hitCount > Properties.Settings.Default.HighScore)
                {
                    Properties.Settings.Default.HighScore = hitCount;
                    Properties.Settings.Default.Save();

                    // Update the high score label
                    highScoreLabel.Text = "High Score: " + hitCount.ToString();
                }

                // Show the game over message box with the final score and high score
                MessageBox.Show($"Game Over! Final score: {hitCount}\nHigh score: {Properties.Settings.Default.HighScore}");
            }

            // Decrease the size of the target button as the score gets higher
            if (hitCount > 0 && hitCount % 10 == 0)
            {
                targetSize -= 20;
                targetButton.Size = new Size(targetSize, targetSize);
            }
        }

        private int score = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            score++;
            scoreLabel.Text = $"Score: {score}";
            targetButton.Visible = false;
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            // Reset the game
            hitCount = 0;
            missCount = 0;
            timeElapsed = 0;
            scoreLabel.Text = "Score: 0";
            
            playAgainButton.Visible = true;
        }

        private void falseTargetButton_Click(object sender, EventArgs e)
        {
            // Increment the false hit count
            falseHitCount++;

            // Update the score and false hit count labels
            scoreLabel.Text = "Score: " + hitCount.ToString();
            falseHitsLabel.Text = "False Hits: " + falseHitCount.ToString();
            
        }
    }
}
