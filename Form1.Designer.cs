namespace StopWatch
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.targetButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.falseTargetButton = new System.Windows.Forms.Button();
            this.falseHitsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time ticker ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 553);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(100, 277);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(152, 46);
            this.targetButton.TabIndex = 4;
            this.targetButton.Text = "TARGET";
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(58, 57);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(51, 20);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Score";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(471, 553);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(145, 54);
            this.playAgainButton.TabIndex = 6;
            this.playAgainButton.Text = "Play again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Location = new System.Drawing.Point(303, 57);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(88, 20);
            this.highScoreLabel.TabIndex = 7;
            this.highScoreLabel.Text = "High Score";
            // 
            // falseTargetButton
            // 
            this.falseTargetButton.Location = new System.Drawing.Point(366, 277);
            this.falseTargetButton.Name = "falseTargetButton";
            this.falseTargetButton.Size = new System.Drawing.Size(189, 46);
            this.falseTargetButton.TabIndex = 8;
            this.falseTargetButton.Text = "FALSE TARGET";
            this.falseTargetButton.UseVisualStyleBackColor = true;
            this.falseTargetButton.Click += new System.EventHandler(this.falseTargetButton_Click);
            // 
            // falseHitsLabel
            // 
            this.falseHitsLabel.AutoSize = true;
            this.falseHitsLabel.Location = new System.Drawing.Point(439, 56);
            this.falseHitsLabel.Name = "falseHitsLabel";
            this.falseHitsLabel.Size = new System.Drawing.Size(77, 20);
            this.falseHitsLabel.TabIndex = 9;
            this.falseHitsLabel.Text = "False hits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 641);
            this.Controls.Add(this.falseHitsLabel);
            this.Controls.Add(this.falseTargetButton);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.targetButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Button falseTargetButton;
        private System.Windows.Forms.Label falseHitsLabel;
    }
}

