namespace ReFocus
{
    public partial class BunnyRun : Form
    {
        System.Media.SoundPlayer bunnyMusic = new System.Media.SoundPlayer(Properties.Resources.bunny1);

        int gravity; 
        int bushSpeed = 7;
        int force = 10; 
        bool jump = false;
        int score = 0;
        int difficulty = 0;

        //x axis locations for the obstacles to spawn
        List<int> xLocs = new List<int> { 500, 550, 600, 650, 700, 800,}; 
        Random random = new Random();
        TimeSpan tMins = TimeSpan.FromMinutes(MainMenu.minutes);

        public BunnyRun()
        {
            InitializeComponent();
            bunnyMusic.PlayLooping();
            MessageBox.Show(
                "Welcome to Bunny Run - Click anywhere to jump" + Environment.NewLine +
                "Click OK to start");
            timer1.Enabled = true;
        }

        private void gameRestart() 
        {
            difficulty = 0;
            bushSpeed = 7;
            bush1.Top = 453;
            bush1.Width = 62;
            bush1.Height = 54;
            force = 10;
            jump = false;
            score = 0;

            int idx = random.Next(xLocs.Count);
            bush1.Left = xLocs[idx];

            timer1.Start();
        }

        public void gameDifficulty() 
        {
            //Increased difficulty = larger obstacles and faster obstacle speed
            switch (difficulty)
            {
                case 1:
                    bush1.Width = 80;
                    bush1.Height = 70;
                    bush1.Top = 433;
                    bushSpeed = 8;
                    difficulty = 1;
                    break;

                case 2:
                    bush1.Width = 110;
                    bush1.Height = 80;
                    bush1.Top = 423;
                    bushSpeed = 11;
                    difficulty = 2;
                    break;

                case 3:
                    bush1.Width = 140;
                    bush1.Height = 90;
                    bush1.Top = 413;
                    bushSpeed = 14;
                    difficulty = 3;
                    break;

                case 4:
                    bush1.Width = 170;
                    bush1.Height = 100;
                    bush1.Top = 403;
                    bushSpeed = 18;
                    difficulty = 4;
                    break;

                case 5:
                    bush1.Width = 200;
                    bush1.Height = 110;
                    bush1.Top = 393;
                    bushSpeed = 21;
                    difficulty = 5;
                    break;
            }   
        }

        private void timerTick(object sender, EventArgs e) 
        {
            //Main game timer for movement, obstacle spawning and difficulty
            gameDifficulty();
            scoreLabel.Text = "Score: " + score; 
            speedLabel.Text = "Difficulty: " + difficulty;
            bunny.Top += gravity;
            bush1.Left -= bushSpeed;

            if (bush1.Left < -100) 
            {
                score++;
                int idx = random.Next(xLocs.Count);
                bush1.Left = xLocs[idx];
            }

            if (bunny.Top > 446)
            {
                gravity = 0;
                force = 10;
                bunny.Top = 447;
            }

            if (jump == true && force < 0)
            {
                jump = false;
                bunny.Image = Properties.Resources.rabbit_down2;
            }

            if (jump == true)
            {
                bunny.Image = Properties.Resources.rabbit_up2;
                gravity = -15;
                force -= 1;
            }
            else
            {
                gravity = 12;
            }

            if (bunny.Top > 446 && jump == false)
            {
                force = 10;
                bunny.Top = 447;
                gravity = 0;  
            }

            if (bunny.Bounds.IntersectsWith(bush1.Bounds))
            { 
                //if the rabbit hits an obstacle stop the game
                timer1.Stop();
                MessageBox.Show(
                    "Game Over!" + Environment.NewLine +
                    "Your final score is: " + score + Environment.NewLine +
                    "Click OK to restart", "Game over");
                gameRestart();
            }

            //Changes the difficulty for each score interval
            if (score >= 5) 
            {
                difficulty = 1;
            }
            if (score >= 10)
            {
                difficulty = 2;
            }
            if (score >= 15)
            {
                difficulty = 3;
            }
            if (score >= 20)
            {
                difficulty = 4;
            }
            if (score >= 25)
            {
                difficulty = 5;
            }
        }

        private void OnClick(object sender, MouseEventArgs e) 
        {
            jump = true; 
            gravity -= 30; 
        }

        private void OnRelease(object sender, MouseEventArgs e) 
        {
            jump = false; 
            gravity = 5;
            force -= 1;
            bunny.Image = Properties.Resources.rabbit_down2;
        }

        
        private async void timer2Tick(object sender, EventArgs e)
        {
            //Animates the rabbit
            while (bunny.Top > 444) 
            {
                bunny.Image = Properties.Resources.rabbit_up;
                await Task.Delay(200);
                bunny.Image = Properties.Resources.rabbit_normal;
                await Task.Delay(200);
                bunny.Image = Properties.Resources.rabbit_down;
                await Task.Delay(200);
                bunny.Image = Properties.Resources.rabbit_normal;
                await Task.Delay(200);
            }   
        }

        private void appTimerTick(object sender, EventArgs e) 
        {
            //timer for the pre-set app duration
            tMins = tMins.Subtract(TimeSpan.FromSeconds(1));

            if (tMins.TotalSeconds >= 0)
            {
                tTimer.Text = tMins.ToString("mm\\:ss");
            }
            else
            {
                timer1.Stop();
                appTimer.Stop();
                MessageBox.Show("Your time on Re:Focus is up. Click OK to close the app.");
                Application.Exit();
            }
        }

        private void BackToMenu(object sender, EventArgs e) 
        {
            MainMenu menuWindow = new MainMenu();
            this.Close();
            menuWindow.Show();
        }
    }
}
