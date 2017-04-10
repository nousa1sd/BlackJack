using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Black_Jack_AI
{
    public partial class Black_Jack : Form
    {
 
     

        public Black_Jack()
        {

            InitializeComponent();

            //Set all the picture boxes to fit the images
            Card1_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            Card2_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            Card3_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            Card4_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            Card5_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            Card6_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            Card7_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            Card8_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            Card9_Image.SizeMode = PictureBoxSizeMode.StretchImage;

            DealersPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            DealersPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            DealersPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            DealersPictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            DealersPictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            DealersPictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            DealersPictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            DealersPictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            DealersPictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;

            Player1_Picturebox_1.SizeMode = PictureBoxSizeMode.StretchImage;
            Player1_Picturebox_2.SizeMode = PictureBoxSizeMode.StretchImage;
            Player1_Picturebox_3.SizeMode = PictureBoxSizeMode.StretchImage;
            Player1_Picturebox_4.SizeMode = PictureBoxSizeMode.StretchImage;
            Player1_Picturebox_5.SizeMode = PictureBoxSizeMode.StretchImage;
            Player1_Picturebox_6.SizeMode = PictureBoxSizeMode.StretchImage;
            Player1_Picturebox_7.SizeMode = PictureBoxSizeMode.StretchImage;
            Player1_Picturebox_8.SizeMode = PictureBoxSizeMode.StretchImage;
            Player1_Picturebox_9.SizeMode = PictureBoxSizeMode.StretchImage;

            Player3_Imagebox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Player3_Imagebox2.SizeMode = PictureBoxSizeMode.StretchImage;
            Player3_Imagebox3.SizeMode = PictureBoxSizeMode.StretchImage;
            Player3_Imagebox4.SizeMode = PictureBoxSizeMode.StretchImage;
            Player3_Imagebox5.SizeMode = PictureBoxSizeMode.StretchImage;
            Player3_Imagebox6.SizeMode = PictureBoxSizeMode.StretchImage;
            Player3_Imagebox7.SizeMode = PictureBoxSizeMode.StretchImage;
            Player3_Imagebox8.SizeMode = PictureBoxSizeMode.StretchImage;
            Player3_Imagebox9.SizeMode = PictureBoxSizeMode.StretchImage;

            Me_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            MarkBeckman_picture.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        //values used by the user, dealer, and other players
        public int Player1Value { get; set; }
        public int Player3Value { get; set; }

        public int UserValue{get;set;}
        public int DealerValue { get; set; }


       public double money { get; set; }
        public double bet { get; set; }

        public int wins { get; set; }

        public int gamesplayed { get; set; }



        //Starts the game
        GamePlay gp = new GamePlay();

        //SoundPlayer
        //Stream str = Properties.Resources.The_Dark_Knight_Rises_Main_Them.wav
        //private SoundPlayer Player = new SoundPlayer();



        //used to start and organize the game
        void Flow_Of_Game()
        {

            //gp = new GamePlay();

            gamesplayed++;
            GamesPlayed_text.Text = gamesplayed.ToString();
            //get score for player1
            Player1Value = gp.DetermineScoreForPlayer1();
            SetPlayer1sTextBox();

            Player1_Picturebox_1.Image = gp.Player1image1;
            Player1_Picturebox_2.Image = gp.Player1image2;


            //Gets the score after the deal for the user
            UserValue = gp.DetermineScoreForUser();
            //MessageBox.Show("Users Score: " + UserValue.ToString());
            SetUsersTextBox();
        
            //set first Picture Box to users card
            Card1_Image.Image = gp.Userimage1;
            Card2_Image.Image = gp.Userimage2;

            //get the score for player3
            Player3Value = gp.DetermineScoreForPlayer3();

            //Set textbox for player3
            SetPlayer3sTextBox();

            //Player3's images
            Player3_Imagebox1.Image = gp.Player3image1; 
            Player3_Imagebox2.Image = gp.Player3image2;

            //Gets the score after the deal for the user
            DealerValue = gp.DetermineScoreForDealer();
            //SetDealersTextBox();

            //set dealers Picture Box to deakers card
            DealersPictureBox1.Image = gp.Dealerimage1;

            //call player 1 AI
            Player1AI();

            //Make a suggestion
            gp.suggestion();




        }// end of startgame

        private void HIT_Button_Click(object sender, EventArgs e)
         {
            try
            {
                gp.Hit("user");

                int userhit = gp.hit;

                //MessageBox.Show(hit.ToString());
                switch (userhit)
                {
                    case 3: Card3_Image.Image = gp.Userimage3; break;
                    case 4: Card4_Image.Image = gp.Userimage4; break;
                    case 5: Card5_Image.Image = gp.Userimage5; break;
                    case 6: Card6_Image.Image = gp.Userimage6; break;
                    case 7: Card7_Image.Image = gp.Userimage7; break;
                    case 8: Card8_Image.Image = gp.Userimage8; break;
                    case 9: Card9_Image.Image = gp.Userimage9; break;
                }
                gp.hit = userhit + 1;

                UserValue = gp.DetermineScoreForUser();
                SetUsersTextBox();

                if (gp.DetermineScoreForUser() >= 21)
                {
                    Stay_Button.PerformClick();
                }
                else
                {
                    gp.suggestion();
                }
            }
            catch
            {
                MessageBox.Show("Invalid input. Please click start!!");
            }

        }

        private void stay_button_click(object sender, EventArgs e)
        {
            try
            {
                //Players 3 turn
                Player3AI();

                DealersPictureBox2.Image = gp.Dealerimage2;
                SetDealersTextBox();

                //Dealers turn
                AI();

                //Deterimine winner
                if (gp.DetermineScoreForUser() <= 21) {

                    gp.DetermineWinner();
                }

                //set Wins
                wins = gp.wins;
                Wins.Text = wins.ToString();

                //set money 
                money = gp.money;
                Money_TextBox.Text = "$" + money.ToString();
                betTextBox.Text = bet.ToString();

            }
            catch
            {
                MessageBox.Show("Invalid input. Please click start!");
            }

        }
        
            public void SetUsersTextBox(){


            Users_Number_Textbox.Text = UserValue.ToString();

        }
        public void SetPlayer1sTextBox()
        {


            Player_1_textbox.Text = Player1Value.ToString();
        }

        public void SetPlayer3sTextBox()
        {

            Player_3_textbox.Text = Player3Value.ToString();
        }

        public void SetDealersTextBox()
        {

            DealerNumber_TextBox.Text = DealerValue.ToString();

        }

        private void Black_Jack_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Enter bet and click start to begin");
            money = 10000000;
            Money_TextBox.Text = "$" + money.ToString();
            try
            {
                //this.Player.SoundLocation = ;
                SoundPlayer audio = new SoundPlayer(Black_Jack_AI.Properties.Resources.The_Dark_Knight_Rises_Main_Them);
                audio.PlayLooping();
                //Flow_Of_Game();
            }
            catch
            {
                MessageBox.Show("Error with load");
            }


        }
        public void Player1AI()
        {
            int hitplayer1 = 0;
            gp.player1SubtrackJack();
            hitplayer1 = gp.player3hit - 1;
           while (gp.DetermineScoreForPlayer1() < 17)
          {
            //MessageBox.Show("Player 1 is not going to stop until their score is above 17");

          gp.Hit("Player1");
            gp.DealerSubtrackJack();
            hitplayer1 = gp.player1hit - 1;
            switch (hitplayer1)
            {
                case 3: Player1_Picturebox_3.Image = gp.Player1image3; break;
                case 4: Player1_Picturebox_4.Image = gp.Player1image4; break;
                case 5: Player1_Picturebox_5.Image = gp.Player1image5; break;
                case 6: Player1_Picturebox_6.Image = gp.Player1image6; break;
                case 7: Player1_Picturebox_7.Image = gp.Player1image7; break;
                case 8: Player1_Picturebox_8.Image = gp.Player1image8; break;
                case 9: Player1_Picturebox_9.Image = gp.Player1image9; break;
            }
            Player1Value = gp.DetermineScoreForPlayer1();
            SetPlayer1sTextBox();

            // MessageBox.Show(gp.DetermineScoreForDealer().ToString());
            }

        }
        public void AI()
        {
            int hit = 0;
            while (gp.DetermineScoreForDealer() < 17)
            {
                //MessageBox.Show("The dealer must hit becuase their score is under 17");

               gp.Hit("AI");
               gp.DealerSubtrackJack();
                hit = gp.dealerhit - 1;
                switch (hit)
                {
                    case 3: DealersPictureBox3.Image = gp.Dealerimage3; break;
                    case 4: DealersPictureBox4.Image = gp.Dealerimage4; break;
                    case 5: DealersPictureBox5.Image = gp.Dealerimage5; break;
                    case 6: DealersPictureBox6.Image = gp.Dealerimage6; break;
                    case 7: DealersPictureBox7.Image = gp.Dealerimage7; break;
                    case 8: DealersPictureBox8.Image = gp.Dealerimage8; break;
                    case 9: DealersPictureBox9.Image = gp.Dealerimage9; break;
                }

                DealerValue = gp.DetermineScoreForDealer();
                SetDealersTextBox();

               // MessageBox.Show(gp.DetermineScoreForDealer().ToString());
            }
            }// end of method

        public void Player3AI()
        {
            int hitplayer3 = 0;
            gp.player3SubtrackJack();
            hitplayer3 = gp.player3hit - 1;
            while (gp.DetermineScoreForPlayer3() < 17)
            {
                //MessageBox.Show("Player 3 is not going to stop until their score is above 17");

                gp.Hit("Player3");
                gp.DealerSubtrackJack();
                hitplayer3 = gp.player3hit - 1;
                switch (hitplayer3)
                {
                    case 3: Player3_Imagebox3.Image = gp.Player3image3; break;
                    case 4: Player3_Imagebox4.Image = gp.Player3image4; break;
                    case 5: Player3_Imagebox5.Image = gp.Player3image5; break;
                    case 6: Player3_Imagebox6.Image = gp.Player3image6; break;
                    case 7: Player3_Imagebox7.Image = gp.Player3image7; break;
                    case 8: Player3_Imagebox8.Image = gp.Player3image8; break;
                    case 9: Player3_Imagebox9.Image = gp.Player3image9; break;
                }
                Player3Value = gp.DetermineScoreForPlayer3();
                SetPlayer3sTextBox();

                // MessageBox.Show(gp.DetermineScoreForDealer().ToString());
            }

        }

        private void Start_Game_Button_Click(object sender, EventArgs e)
        {
         
            try {
                bet = Convert.ToDouble(betTextBox.Text);
                MessageBox.Show("Your bet is " + betTextBox.Text);
                gp.bet = bet;
                gp.money = money;
                if (money <= 0)
                {
                    MessageBox.Show("You are all out of money. You loose!");
                    Application.Exit();

                }
                else if (bet > money)
                {
                    MessageBox.Show("Sorry you do not have $" + bet + "to gamble");
                }
                else if (bet<= 0)
                {
                    MessageBox.Show("Invalid input for bet!");
                }
                else
                {

                    betTextBox.Text = "$" + bet.ToString();
                    Card1_Image.Image = null;
                    Card2_Image.Image = null;
                    Card3_Image.Image = null;
                    Card4_Image.Image = null;
                    Card5_Image.Image = null;
                    Card6_Image.Image = null;
                    Card7_Image.Image = null;
                    Card8_Image.Image = null;
                    Card9_Image.Image = null;

                    DealersPictureBox1.Image = null;
               //     DealersPictureBox2.Image = Properties.Resources.Back_Of_Card;
                    DealersPictureBox3.Image = null;
                    DealersPictureBox4.Image = null;
                    DealersPictureBox5.Image = null;
                    DealersPictureBox6.Image = null;
                    DealersPictureBox7.Image = null;
                    DealersPictureBox8.Image = null;
                    DealersPictureBox9.Image = null;

                    Player1_Picturebox_1.Image = null;
                    Player1_Picturebox_2.Image = null;
                    Player1_Picturebox_3.Image = null;
                    Player1_Picturebox_4.Image = null;
                    Player1_Picturebox_5.Image = null;
                    Player1_Picturebox_6.Image = null;
                    Player1_Picturebox_7.Image = null;
                    Player1_Picturebox_8.Image = null;
                    Player1_Picturebox_9.Image = null;

                    Player3_Imagebox1.Image = null;
                    Player3_Imagebox2.Image = null;
                    Player3_Imagebox3.Image = null;
                    Player3_Imagebox4.Image = null;
                    Player3_Imagebox5.Image = null;
                    Player3_Imagebox6.Image = null;
                    Player3_Imagebox7.Image = null;
                    Player3_Imagebox8.Image = null;
                    Player3_Imagebox9.Image = null;

                    Player1Value = 0;
                    Player3Value = 0;
                    UserValue = 0;
                    DealerValue = 0;
                    SetPlayer1sTextBox();
                    SetPlayer3sTextBox();
                    SetDealersTextBox();
                    SetUsersTextBox();

                    gp.ResetEverything();

                    Flow_Of_Game();
                }//end of if else statement
            }
            catch
            {
                MessageBox.Show("Invalid input for bet! Please enter bet!");
            }
            //}
        }
    }
}
