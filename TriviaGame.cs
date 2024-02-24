namespace ReFocus
{
    public partial class TriviaGame : Form
    {
        System.Media.SoundPlayer triviaMusic = new System.Media.SoundPlayer(Properties.Resources.trivia);

        int ans; 
        int qNum = 1; 
        int score; 
        int ansPercent;
        int totalQs; 

        TimeSpan tMins = TimeSpan.FromMinutes(MainMenu.minutes);

        public TriviaGame()
        {
            InitializeComponent();
            triviaMusic.PlayLooping();
            timer1.Start();
            newQuestion(qNum); 
            totalQs = 25; 
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender; 

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == ans)
            {
                score += 1;
            }

            if (qNum == totalQs) 
            {
                ansPercent = (int)Math.Round((double)(score * 100) / totalQs);

                MessageBox.Show(
                    "Quiz Complete!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + ansPercent  + "%" + Environment.NewLine +
                    "Click OK to go back to the main menu"
                    );

                MainMenu menuWindow = new MainMenu();
                this.Close();
                menuWindow.Show();
            }
                
            qNum++;
            newQuestion(qNum);
            scoreLabel.Text = score + "/" + (qNum - 1);
        }

        private void newQuestion(int qnum) 
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.world_map; 
                    Question.Text = "How many countries are there in the world?";

                    button1.Text = "142";
                    button2.Text = "195";
                    button3.Text = "181";
                    button4.Text = "203";

                    ans = 2;
                    break;

                 case 2:
                    pictureBox1.Image = Properties.Resources.california; 
                    Question.Text = "What is the nickname of the US state of California?";

                    button1.Text = "Sunshine state";
                    button2.Text = "Rainy state";
                    button3.Text = "Golden state";
                    button4.Text = "Rich state";

                    ans = 3;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.poland; 
                    Question.Text = "What is the name of Poland in Polish?";

                    button1.Text = "Polska";
                    button2.Text = "Polski";
                    button3.Text = "Poland";
                    button4.Text = "Pola";

                    ans = 1;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.dollar; 
                    Question.Text = "Who is depicted on the US 100 dollar bill?";

                    button1.Text = "George Washington";
                    button2.Text = "Barack Obama";
                    button3.Text = "Thomas Jefferson";
                    button4.Text = "Benjamin Franklin";

                    ans = 4;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.phobia; 
                    Question.Text = "What is Cynophobia the fear of?";

                    button1.Text = "Cats";
                    button2.Text = "The colour Cyan";
                    button3.Text = "Dogs";
                    button4.Text = "Copper";

                    ans = 3;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.eu; 
                    Question.Text = "How many stars are on the European Union flag?";

                    button1.Text = "9";
                    button2.Text = "12";
                    button3.Text = "10";
                    button4.Text = "14";

                    ans = 2;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.food; 
                    Question.Text = "Which restaurant's mascot is a clown?";

                    button1.Text = "McDonalds";
                    button2.Text = "Burger King";
                    button3.Text = "Wendy's";
                    button4.Text = "KFC";

                    ans = 1;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.spices; 
                    Question.Text = "What is the world's most expensive spice by weight?";

                    button1.Text = "Chilli";
                    button2.Text = "Cumin";
                    button3.Text = "Saffron";
                    button4.Text = "Pure vanilla";

                    ans = 3;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.alcohol;
                    Question.Text = "Which alcohol drink is mainly made from juniper berries?";

                    button1.Text = "Vodka";
                    button2.Text = "Gin";
                    button3.Text = "Tequila";
                    button4.Text = "Wine";

                    ans = 2;
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.greece; 
                    Question.Text = "What is the last letter of the Greek alphabet?";

                    button1.Text = "Theta";
                    button2.Text = "Gamma";
                    button3.Text = "Alpha";
                    button4.Text = "Omega";

                    ans = 4;
                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.brazil; 
                    Question.Text = "What is the Portugese word for Brazil?";

                    button1.Text = "Brazil";
                    button2.Text = "Brazilia";
                    button3.Text = "Brasil";
                    button4.Text = "Brasilia";

                    ans = 3;
                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.pineapple; 
                    Question.Text = "Where did the pineapple plant originate?";

                    button1.Text = "Africa";
                    button2.Text = "South America";
                    button3.Text = "North America";
                    button4.Text = "Asia";

                    ans = 2;
                    break;

                case 13:
                    pictureBox1.Image = Properties.Resources.globe; 
                    Question.Text = "Which of the following languages do not use gender as part of its grammar?";

                    button1.Text = "French";
                    button2.Text = "German";
                    button3.Text = "Turkish";
                    button4.Text = "Punjabi";

                    ans = 3;
                    break;

                case 14:
                    pictureBox1.Image = Properties.Resources.piano; 
                    Question.Text = "How many notes are there on a standard grand piano?";

                    button1.Text = "88";
                    button2.Text = "120";
                    button3.Text = "96";
                    button4.Text = "82";

                    ans = 1;
                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources.sport; 
                    Question.Text = "Which sport is known as the 'American pastime'?";

                    button1.Text = "Baseball";
                    button2.Text = "Basketball";
                    button3.Text = "American Football";
                    button4.Text = "Soccer";

                    ans = 1;
                    break;

                case 16:
                    pictureBox1.Image = Properties.Resources.seeds; 
                    Question.Text = "If you planted the seeds of Quercus robur, what would grow?";

                    button1.Text = "Trees";
                    button2.Text = "Lychees";
                    button3.Text = "Poison Ivy";
                    button4.Text = "Potatoes";

                    ans = 1;
                    break;

                case 17:
                    pictureBox1.Image = Properties.Resources.copper; 
                    Question.Text = "In the periodic table, what is the symbol for Copper?";

                    button1.Text = "Co";
                    button2.Text = "C";
                    button3.Text = "Cu";
                    button4.Text = "Cr";

                    ans = 3;
                    break;

                case 18:
                    pictureBox1.Image = Properties.Resources.jolibee; 
                    Question.Text = "Which country is famous for the fast-food chain 'Jolibee'?";

                    button1.Text = "South Korea";
                    button2.Text = "Philippines";
                    button3.Text = "America";
                    button4.Text = "Spain";

                    ans = 2;
                    break;

                case 19:
                    pictureBox1.Image = Properties.Resources.bibimbap; 
                    Question.Text = "What is the name of the popular mixed rice, meat, and vegetable dish in Korea?";

                    button1.Text = "Bulgogi";
                    button2.Text = "Bibimbap";
                    button3.Text = "Galbitang";
                    button4.Text = "Tteokbokki";

                    ans = 2;
                    break;

                case 20:
                    pictureBox1.Image = Properties.Resources.gpu; 
                    Question.Text = "What does the term GPU stand for?";

                    button1.Text = "General Processing Unit";
                    button2.Text = "General Procedure Unit";
                    button3.Text = "Graphics Producing Unit";
                    button4.Text = "Graphics Processing Unit";

                    ans = 4;
                    break;

                case 21:
                    pictureBox1.Image = Properties.Resources.picasso; 
                    Question.Text = "What is Picasso's nationality?";

                    button1.Text = "Turkish";
                    button2.Text = "French";
                    button3.Text = "Spanish";
                    button4.Text = "German";

                    ans = 3;
                    break;

                case 22:
                    pictureBox1.Image = Properties.Resources.dreams; 
                    Question.Text = "Which film involves people entering other people's dreams?";

                    button1.Text = "Inception";
                    button2.Text = "Lord of the Rings";
                    button3.Text = "Avengers";
                    button4.Text = "The Matrix";

                    ans = 1;
                    break;

                case 23:
                    pictureBox1.Image = Properties.Resources.projectiles; 
                    Question.Text = "Which science deals with the motion of projectiles?";

                    button1.Text = "Rocket Science";
                    button2.Text = "Ballistics";
                    button3.Text = "Astrophysics";
                    button4.Text = "Meteorology";

                    ans = 2;
                    break;

                case 24:
                    pictureBox1.Image = Properties.Resources.pina; 
                    Question.Text = "What do you call a cocktail consisting of coconut milk, rum, and pineapple?";

                    button1.Text = "Cosmopolitan";
                    button2.Text = "Martini";
                    button3.Text = "Mai Tai";
                    button4.Text = "Pina Colada";

                    ans = 4;
                    break;

                case 25:
                    pictureBox1.Image = Properties.Resources.pool; 
                    Question.Text = "How many balls are on a pool table at the start of the game?";

                    button1.Text = "10";
                    button2.Text = "12";
                    button3.Text = "16";
                    button4.Text = "18";

                    ans = 3;
                    break;
            }
        }

        private void BackToMenu(object sender, EventArgs e)
        {
            MainMenu menuWindow = new MainMenu();
            this.Close();
            menuWindow.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tMins = tMins.Subtract(TimeSpan.FromSeconds(1));

            if (tMins.TotalSeconds >= 0)
            {
                tTimer.Text = tMins.ToString("mm\\:ss");
            }
            else
            {
                timer1.Stop();
                MessageBox.Show(
                    "Your time on Re:Focus is up. Click OK to close the app."
                    );
                Application.Exit();
            }
        }
    }
}