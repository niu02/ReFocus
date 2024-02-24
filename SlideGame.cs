namespace ReFocus
{
    public partial class SlideGame : Form
    {
        int puzzleNum = 1; 
        TimeSpan tMins = TimeSpan.FromMinutes(MainMenu.minutes);
        System.Media.SoundPlayer puzzleMusic = new System.Media.SoundPlayer(Properties.Resources.puzzle1); 

        public SlideGame()
        {
            InitializeComponent();
            newPuzzle(puzzleNum);
            puzzleMusic.PlayLooping(); 
        }

        private void newPuzzle(int puzzleNum) 
        {
            //Each case is a new puzzle, each block is assigned an image and tag
            switch (puzzleNum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.landscape1;
                    pb1.Image = Properties.Resources._13;
                    pb1.Tag = 3;
                    pb2.Image = Properties.Resources._21;
                    pb2.Tag = 5;
                    pb3.Image = Properties.Resources._33;
                    pb3.Tag = 11;
                    pb4.Image = Properties.Resources._12;
                    pb4.Tag = 2;
                    pb5.Image = Properties.Resources._42;
                    pb5.Tag = 14;
                    pb6.Image = Properties.Resources._32;
                    pb6.Tag = 10;
                    pb7.Image = Properties.Resources._11;
                    pb7.Tag = 1;
                    pb8.Image = Properties.Resources._31;
                    pb8.Tag = 9;
                    pb9.Image = Properties.Resources._43;
                    pb9.Tag = 15;
                    pb10.Image = Properties.Resources._24;
                    pb10.Tag = 8;
                    pb11.Image = Properties.Resources._14;
                    pb11.Tag = 4;
                    pb12.Image = Properties.Resources._41;
                    pb12.Tag = 13;
                    pb13.Image = Properties.Resources._23;
                    pb13.Tag = 7;
                    pb14.Image = Properties.Resources._22;
                    pb14.Tag = 6;
                    pb15.Image = Properties.Resources._34;
                    pb15.Tag = 12;
                    pb16.Image = Properties.Resources.black;
                    pb16.Tag = 16;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.landscape2;
                    pb1.Image = Properties.Resources._9;
                    pb1.Tag = 9;
                    pb2.Image = Properties.Resources._2;
                    pb2.Tag = 2;
                    pb3.Image = Properties.Resources._212;
                    pb3.Tag = 12;
                    pb4.Image = Properties.Resources._4;
                    pb4.Tag = 4;
                    pb5.Image = Properties.Resources._10;
                    pb5.Tag = 10;
                    pb6.Image = Properties.Resources._213;
                    pb6.Tag = 13;
                    pb7.Image = Properties.Resources._1;
                    pb7.Tag = 1;
                    pb8.Image = Properties.Resources._6;
                    pb8.Tag = 6;
                    pb9.Image = Properties.Resources._5;
                    pb9.Tag = 5;
                    pb10.Image = Properties.Resources._3;
                    pb10.Tag = 3;
                    pb11.Image = Properties.Resources._15;
                    pb11.Tag = 15;
                    pb12.Image = Properties.Resources._8;
                    pb12.Tag = 8;
                    pb13.Image = Properties.Resources._214;
                    pb13.Tag = 14;
                    pb14.Image = Properties.Resources._211;
                    pb14.Tag = 11;
                    pb15.Image = Properties.Resources._7;
                    pb15.Tag = 7;
                    pb16.Image = Properties.Resources.black;
                    pb16.Tag = 16;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.landscape3; 
                    pb1.Image = Properties.Resources.r3c2;
                    pb1.Tag = 10;
                    pb2.Image = Properties.Resources.r1c4;
                    pb2.Tag = 4;
                    pb3.Image = Properties.Resources.r4c1;
                    pb3.Tag = 13;
                    pb4.Image = Properties.Resources.r4c3;
                    pb4.Tag = 15;
                    pb5.Image = Properties.Resources.r2c1;
                    pb5.Tag = 5;
                    pb6.Image = Properties.Resources.r2c3;
                    pb6.Tag = 7;
                    pb7.Image = Properties.Resources.r1c1;
                    pb7.Tag = 1;
                    pb8.Image = Properties.Resources.r3c4;
                    pb8.Tag = 12;
                    pb9.Image = Properties.Resources.r1c2;
                    pb9.Tag = 2;
                    pb10.Image = Properties.Resources.r4c2;
                    pb10.Tag = 14;
                    pb11.Image = Properties.Resources.r2c2;
                    pb11.Tag = 6;
                    pb12.Image = Properties.Resources.r1c3;
                    pb12.Tag = 3;
                    pb13.Image = Properties.Resources.r2c4;
                    pb13.Tag = 8;
                    pb14.Image = Properties.Resources.r3c1;
                    pb14.Tag = 9;
                    pb15.Image = Properties.Resources.r3c3;
                    pb15.Tag = 11;
                    pb16.Image = Properties.Resources.black;
                    pb16.Tag = 16;
                    break;
            }
        }

        private void MovePossible(PictureBox piece1, PictureBox piece2)
        {
            int piece2Tag = Convert.ToInt32(piece2.Tag);

            //If the block clicked on is adjacent to the black block (black tagged as 16)
            if (piece2Tag == 16)
            {
                (piece2.Image, piece1.Image) = (piece1.Image, piece2.Image); 
                (piece2.Tag, piece1.Tag) = (piece1.Tag, piece2.Tag); 
            }
        }

        private void PuzzleComplete()
        {   
            //Check if all of the image tags correspond to the picture box number to see if they are in the right place
            if (Convert.ToInt32(pb1.Tag) == 1 && Convert.ToInt32(pb2.Tag) == 2 && Convert.ToInt32(pb3.Tag) == 3
                && Convert.ToInt32(pb4.Tag) == 4 && Convert.ToInt32(pb5.Tag) == 5 && Convert.ToInt32(pb6.Tag) == 6 &&
                Convert.ToInt32(pb7.Tag) == 7 && Convert.ToInt32(pb8.Tag) == 8 && Convert.ToInt32(pb9.Tag) == 9 &&
                Convert.ToInt32(pb10.Tag) == 10 && Convert.ToInt32(pb11.Tag) == 11 && Convert.ToInt32(pb12.Tag) == 12
                && Convert.ToInt32(pb13.Tag) == 13 && Convert.ToInt32(pb14.Tag) == 14 && Convert.ToInt32(pb15.Tag) == 15
                && Convert.ToInt32(pb16.Tag) == 16) 
            { 
                //If all puzzles are completed
                if (puzzleNum == 3) 
                {
                    MessageBox.Show(
                    "You have successfully completed all puzzles!" + Environment.NewLine +
                    "Click OK to go back to the main menu"
                    );
                    MainMenu menuWindow = new MainMenu();
                    this.Close();
                    menuWindow.Show();
                }
                else 
                {
                    //If not, proceed to next puzzle
                    MessageBox.Show(
                    "Puzzle complete!" + Environment.NewLine +
                    "Click OK to continue to the next puzzle"
                    );
                    puzzleNum++;
                    newPuzzle(puzzleNum);
                }
            }
        }

        private void OnPb1Click(object sender, EventArgs e) 
        { 
            //Check each individual block next to the selected block to see if they are next
            //to a black block, and if yes, they can be moved.
            //After each move check whether the puzzle is completed
            MovePossible(pb1, pb2);
            MovePossible(pb1, pb5);
            PuzzleComplete();
        }

        private void OnPb2Click(object sender, EventArgs e)
        {
            MovePossible(pb2, pb3);
            MovePossible(pb2, pb1);
            MovePossible(pb2, pb6);
            PuzzleComplete();
        }

        private void OnPb3Click(object sender, EventArgs e)
        {
            MovePossible(pb3, pb2);
            MovePossible(pb3, pb4);
            MovePossible(pb3, pb7);
            PuzzleComplete();
        }

        private void OnPb4Click(object sender, EventArgs e)
        {
            MovePossible(pb4, pb3);
            MovePossible(pb4, pb8);
            PuzzleComplete();
        }

        private void OnPb5Click(object sender, EventArgs e)
        {
            MovePossible(pb5, pb6);
            MovePossible(pb5, pb9);
            MovePossible(pb5, pb1);
            PuzzleComplete();
        }

        private void OnPb6Click(object sender, EventArgs e)
        {
            MovePossible(pb6, pb2);
            MovePossible(pb6, pb5);
            MovePossible(pb6, pb7);
            MovePossible(pb6, pb10);
            PuzzleComplete();
        }

        private void OnPb7Click(object sender, EventArgs e)
        {
            MovePossible(pb7, pb3);
            MovePossible(pb7, pb6);
            MovePossible(pb7, pb8);
            MovePossible(pb7, pb11);
            PuzzleComplete();
        }

        private void OnPb8Click(object sender, EventArgs e)
        {
            MovePossible(pb8, pb7);
            MovePossible(pb8, pb4);
            MovePossible(pb8, pb12);
            PuzzleComplete();
        }

        private void OnPb9Click(object sender, EventArgs e)
        {
            MovePossible(pb9, pb10);
            MovePossible(pb9, pb5);
            MovePossible(pb9, pb13);
            PuzzleComplete();
        }

        private void OnPb10Click(object sender, EventArgs e)
        {
            MovePossible(pb10, pb9);
            MovePossible(pb10, pb11);
            MovePossible(pb10, pb6);
            MovePossible(pb10, pb14);
            PuzzleComplete();
        }

        private void OnPb11Click(object sender, EventArgs e)
        {
            MovePossible(pb11, pb10);
            MovePossible(pb11, pb12);
            MovePossible(pb11, pb7);
            MovePossible(pb11, pb15);
            PuzzleComplete();
        }

        private void OnPb12Click(object sender, EventArgs e)
        {
            MovePossible(pb12, pb8);
            MovePossible(pb12, pb16);
            MovePossible(pb12, pb11);
            PuzzleComplete();
        }

        private void OnPb13Click(object sender, EventArgs e)
        {
            MovePossible(pb13, pb14);
            MovePossible(pb13, pb9);
            PuzzleComplete();
        }

        private void OnPb14Click(object sender, EventArgs e)
        {
            MovePossible(pb14, pb13);
            MovePossible(pb14, pb15);
            MovePossible(pb14, pb10);
            PuzzleComplete();
        }

        private void OnPb15Click(object sender, EventArgs e)
        {
            MovePossible(pb15, pb14);
            MovePossible(pb15, pb16);
            MovePossible(pb15, pb11);
            PuzzleComplete();
        }

        private void OnPb16Click(object sender, EventArgs e)
        {
            MovePossible(pb16, pb15);
            MovePossible(pb16, pb12);
            PuzzleComplete();
        }

        private void BackToMenu(object sender, EventArgs e) 
        {
            //Takes the user back to the main menu if the back button is clicked
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
