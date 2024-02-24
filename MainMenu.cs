namespace ReFocus
{
    public partial class MainMenu : Form
    {
        public static int minutes;
        System.Media.SoundPlayer menuMusic = new System.Media.SoundPlayer(Properties.Resources.mainmenu);

        public MainMenu()
        {
            InitializeComponent();
            menuMusic.Play();
            button3.Enabled = false;
            button3.BackColor = Color.Gray;
            button4.Enabled = false;
            button4.BackColor = Color.Gray;
            button5.Enabled = false;
            button5.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            minutes = 5;
            button3.Enabled = true;
            button3.BackColor = Color.FromArgb(236, 255, 245);
            button4.Enabled = true;
            button4.BackColor = Color.FromArgb(243, 252, 255);
            button5.Enabled = true;
            button5.BackColor = Color.FromArgb(252, 246, 255);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            minutes = 10;
            button3.Enabled = true;
            button3.BackColor = Color.FromArgb(236, 255, 245);
            button4.Enabled = true;
            button4.BackColor = Color.FromArgb(243, 252, 255);
            button5.Enabled = true;
            button5.BackColor = Color.FromArgb(252, 246, 255);
        }
        private void MenuClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void LoadTrivia(object sender, EventArgs e) 
        {
            menuMusic.Stop();
            TriviaGame triviaWindow = new TriviaGame();
            this.Hide();
            triviaWindow.Show();
        }

        private void LoadPuzzle(object sender, EventArgs e)
        {
            menuMusic.Stop();
            SlideGame slideWindow = new SlideGame();
            this.Hide();
            slideWindow.Show();
        }

        private void LoadBunnyRun(object sender, EventArgs e)
        {
            menuMusic.Stop();
            BunnyRun bunnyWindow = new BunnyRun();
            this.Hide();
            bunnyWindow.Show();
        }
    }
}
