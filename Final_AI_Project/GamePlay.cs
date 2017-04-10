using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Black_Jack_AI
{
    class GamePlay
    {
        static Random rn = new Random();
        static User user = new User();
        static User dealer = new User();
        static User Player1 = new User();
        static User Player3 = new User();




        Card1 Card = new Card1("Ace of Spades", 11, (Image)Properties.Resources.Ace_Of_Spades);
        Card1 Card2 = new Card1("2 of Spades", 2, (Image)Properties.Resources._2_Of_Spades);
        Card1 Card3 = new Card1("3 of Spades", 3, (Image)Properties.Resources._3_Of_Spades);
        Card1 Card4 = new Card1("4 of Spades", 4, (Image)Properties.Resources._4_Of_Spades);
        Card1 Card5 = new Card1("5 of Spades", 5, (Image)Properties.Resources._5_Of_Spades);
        Card1 Card6 = new Card1("6 of Spades", 6, (Image)Properties.Resources._6_Of_Spades);
        Card1 Card7 = new Card1("7 of Spades", 7, (Image)Properties.Resources._7_Of_Spades);
        Card1 Card8 = new Card1("8 of Spades", 8, (Image)Properties.Resources._8_Of_Spades);
        Card1 Card9 = new Card1("9 of Spades", 9, (Image)Properties.Resources._9_Of_Spades);
        Card1 Card10 = new Card1("10 of Spades", 10, (Image)Properties.Resources._10_Of_Spades);
        Card1 Card11 = new Card1("Jack of Spades", 10, (Image)Properties.Resources.Jack_Of_Spades);
        Card1 Card12 = new Card1("Queen of Spades", 10, (Image)Properties.Resources.Queen_Of_Spades);
        Card1 Card13 = new Card1("King of Spades", 10, (Image)Properties.Resources.King_Of_Spades);

        // Diamonds
        Card1 Card14 = new Card1("Ace of Diamonds", 11, (Image)Properties.Resources.Ace_Of_Diamonds);
        Card1 Card15 = new Card1("2 of Diamonds", 2, (Image)Properties.Resources._2_Of_Diamonds);
        Card1 Card16 = new Card1("3 of Diamonds", 3, (Image)Properties.Resources._3_Of_Diamonds);
        Card1 Card17 = new Card1("4 of Diamonds", 4, (Image)Properties.Resources._4_Of_Diamonds);
        Card1 Card18 = new Card1("5 of Diamonds", 5, (Image)Properties.Resources._5_Of_Diamonds);
        Card1 Card19 = new Card1("6 of Diamonds", 6, (Image)Properties.Resources._6_Of_Diamonds);
        Card1 Card20 = new Card1("7 of Diamonds", 7, (Image)Properties.Resources._7_Of_Diamonds);
        Card1 Card21 = new Card1("8 of Diamonds", 8, (Image)Properties.Resources._8_Of_Diamonds);
        Card1 Card22 = new Card1("9 of Diamonds", 9, (Image)Properties.Resources._9_Of_Diamonds);
        Card1 Card23 = new Card1("10 of Diamonds", 10, (Image)Properties.Resources._10_Of_Diamonds);
        Card1 Card24 = new Card1("Jack of Diamonds", 10, (Image)Properties.Resources.Jack_Of_Diamonds);
        Card1 Card25 = new Card1("Queen of Diamonds", 10, (Image)Properties.Resources.Queen_Of_Diamonds);
        Card1 Card26 = new Card1("King of Diamonds", 10, (Image)Properties.Resources.King_Of_Diamonds);

        // Hearts
        Card1 Card27 = new Card1("Ace of Hearts", 11, (Image)Properties.Resources.Ace_Of_Hearts);
        Card1 Card28 = new Card1("2 of Hearts", 2, (Image)Properties.Resources._2_Of_Hearts);
        Card1 Card29 = new Card1("3 of Hearts", 3, (Image)Properties.Resources._3_Of_Hearts);
        Card1 Card30 = new Card1("4 of Hearts", 4, (Image)Properties.Resources._4_Of_Hearts);
        Card1 Card31 = new Card1("5 of Hearts", 5, (Image)Properties.Resources._5_Of_Hearts);
        Card1 Card32 = new Card1("6 of Hearts", 6, (Image)Properties.Resources._6_Of_Hearts);
        Card1 Card33 = new Card1("7 of Hearts", 7, (Image)Properties.Resources._7_Of_Hearts);
        Card1 Card34 = new Card1("8 of Hearts", 8, (Image)Properties.Resources._8_Of_Hearts);
        Card1 Card35 = new Card1("9 of Hearts", 9, (Image)Properties.Resources._9_Of_Hearts);
        Card1 Card36 = new Card1("10 of Hearts", 10, (Image)Properties.Resources._10_Of_Hearts);
        Card1 Card37 = new Card1("Jack of Hearts", 10, (Image)Properties.Resources.Jack_Of_Hearts);
        Card1 Card38 = new Card1("Queen of Hearts", 10, (Image)Properties.Resources.Queen_Of_Hearts);
        Card1 Card39 = new Card1("King of Hearts", 10, (Image)Properties.Resources.King_Of_Hearts);

        // Clubs
        Card1 Card40 = new Card1("Ace of Clubs", 11, (Image)Properties.Resources.Ace_Of_Clubs);
        Card1 Card41 = new Card1("2 of Clubs", 2, (Image)Properties.Resources._2_Of_Clubs);
        Card1 Card42 = new Card1("3 of Clubs", 3, (Image)Properties.Resources._3_Of_Clubs);
        Card1 Card43 = new Card1("4 of Clubs", 4, (Image)Properties.Resources._4_Of_Clubs);
        Card1 Card44 = new Card1("5 of Clubs", 5, (Image)Properties.Resources._5_Of_Clubs);
        Card1 Card45 = new Card1("6 of Clubs", 6, (Image)Properties.Resources._6_Of_Clubs);
        Card1 Card46 = new Card1("7 of Clubs", 7, (Image)Properties.Resources._7_Of_Clubs);
        Card1 Card47 = new Card1("8 of Clubs", 8, (Image)Properties.Resources._8_Of_Clubs);
        Card1 Card48 = new Card1("9 of Clubs", 9, (Image)Properties.Resources._9_Of_Clubs);
        Card1 Card49 = new Card1("10 of Clubs", 10, (Image)Properties.Resources._10_Of_Clubs);
        Card1 Card50 = new Card1("Jack of Clubs", 10, (Image)Properties.Resources.Jack_Of_Clubs);
        Card1 Card51 = new Card1("Queen of Clubs", 10, (Image)Properties.Resources.Queen_Of_Clubs);
        Card1 Card52 = new Card1("King of Clubs", 10, (Image)Properties.Resources.King_Of_Clubs);

        List<Card1> List_Of_Cards = new List<Card1>();

        static int DecrRanNum { get; set; }
        static List<Card1> Deck { get; set; }

        public int hit { get; set; }
        public int dealerhit { get; set; }
        public int player1hit { get; set; }
        public int player3hit { get; set; }
        public double bet { get; set; }
        public double money { get; set; }


        public Image Userimage1 { get; set; }
        public Image Userimage2 { get; set; }

        public Image Userimage3 { get; set; }
        public Image Userimage4 { get; set; }
        public Image Userimage5 { get; set; }
        public Image Userimage6 { get; set; }

        public Image Userimage7 { get; set; }
        public Image Userimage8 { get; set; }
        public Image Userimage9 { get; set; }

        //Set images 
        public Image Dealerimage1 { get; set; }
        public Image Dealerimage2 { get; set; }
        public Image Dealerimage3 { get; set; }
        public Image Dealerimage4 { get; set; }
        public Image Dealerimage5 { get; set; }
        public Image Dealerimage6 { get; set; }
        public Image Dealerimage7 { get; set; }
        public Image Dealerimage8 { get; set; }
        public Image Dealerimage9 { get; set; }

        //Used images for Player1 
        public Image Player1image1 { get; set; }
        public Image Player1image2 { get; set; }
        public Image Player1image3 { get; set; }
        public Image Player1image4 { get; set; }
        public Image Player1image5 { get; set; }
        public Image Player1image6 { get; set; }
        public Image Player1image7 { get; set; }
        public Image Player1image8 { get; set; }
        public Image Player1image9 { get; set; }


        //Used images for Player3 
        public Image Player3image1 { get; set; }
        public Image Player3image2 { get; set; }
        public Image Player3image3 { get; set; }
        public Image Player3image4 { get; set; }
        public Image Player3image5 { get; set; }
        public Image Player3image6 { get; set; }
        public Image Player3image7 { get; set; }
        public Image Player3image8 { get; set; }
        public Image Player3image9 { get; set; }

        public int wins { get; set;  }

        //determine how many jacks the payer has.
        //if the user score is abover 21 and it has a jack minus 10 to keep the 
        //the player in the game
        public int HasJack { get; set; }
        
        public int Player1HasJack { get; set; }
        public int Player3HasJack { get; set; }

        public int DealerHasJack { get; set; }

        public int index { get; set; }

        public void CreateDeck()
        {
            //0 Ace of Spades
            List_Of_Cards.Add(Card);

            //1
            List_Of_Cards.Add(Card2);

            //2
            List_Of_Cards.Add(Card3);

            //3
            List_Of_Cards.Add(Card4);

            //4
            List_Of_Cards.Add(Card5);

            //5
            List_Of_Cards.Add(Card6);

            //6
            List_Of_Cards.Add(Card7);

            //7
            List_Of_Cards.Add(Card8);

            //8
            List_Of_Cards.Add(Card9);

            //9
            List_Of_Cards.Add(Card10);

            //10
            List_Of_Cards.Add(Card11);

            //11
            List_Of_Cards.Add(Card12);

            //12
            List_Of_Cards.Add(Card13);


            //13 Ace of Diamonds
            List_Of_Cards.Add(Card14);

            //14
            List_Of_Cards.Add(Card15);

            //15
            List_Of_Cards.Add(Card16);

            //16
            List_Of_Cards.Add(Card17);

            //17
            List_Of_Cards.Add(Card18);

            //18
            List_Of_Cards.Add(Card19);

            //19
            List_Of_Cards.Add(Card20);

            //20
            List_Of_Cards.Add(Card21);

            //21
            List_Of_Cards.Add(Card22);

            //22
            List_Of_Cards.Add(Card23);

            //23
            List_Of_Cards.Add(Card24);

            //24
            List_Of_Cards.Add(Card25);

            //25
            List_Of_Cards.Add(Card26);

            //26 Ace of Hearts
            List_Of_Cards.Add(Card27);

            //27
            List_Of_Cards.Add(Card28);

            //28
            List_Of_Cards.Add(Card29);

            //29
            List_Of_Cards.Add(Card30);

            //30
            List_Of_Cards.Add(Card31);

            //31
            List_Of_Cards.Add(Card32);

            //32
            List_Of_Cards.Add(Card33);

            //33
            List_Of_Cards.Add(Card34);

            //34
            List_Of_Cards.Add(Card35);

            //35
            List_Of_Cards.Add(Card36);

            //36
            List_Of_Cards.Add(Card37);

            //37
            List_Of_Cards.Add(Card38);

            //38
            List_Of_Cards.Add(Card39);

            //39 Ace of Clubs
            List_Of_Cards.Add(Card40);

            //40
            List_Of_Cards.Add(Card41);

            //41
            List_Of_Cards.Add(Card42);

            //42
            List_Of_Cards.Add(Card43);

            //43
            List_Of_Cards.Add(Card44);

            //44
            List_Of_Cards.Add(Card45);

            //45
            List_Of_Cards.Add(Card46);

            //46
            List_Of_Cards.Add(Card47);

            //47
            List_Of_Cards.Add(Card48);

            //48
            List_Of_Cards.Add(Card49);

            //49
            List_Of_Cards.Add(Card50);

            //50
            List_Of_Cards.Add(Card51);

            //51
            List_Of_Cards.Add(Card52);

            Deck = List_Of_Cards;

            hit = 3;
            dealerhit = 3;
            player1hit = 3;
            player3hit = 3;

            Deal();

        }

        public void Deal()
        {
            DecrRanNum = Deck.Count();
            
            //give player one first card
            int location =  getRandomNumber();
            //MessageBox.Show("Deal1 card after player1 " + Deck[location].Getname());
            if (Deck[location].Getname() == "Ace of Spades" || Deck[location].Getname() == "Ace of Diamonds" || Deck[location].Getname() == "Ace of Hearts" || Deck[location].Getname() == "Ace of Clubs")
            {
                Player1HasJack++;
                //MessageBox.Show("Player1 jacks after first deal" + Player1HasJack);
            }

            Player1.SetUserCard(Deck[location]);

            // set Playe 1 image to corresponding card
            Player1image1 = Deck[location].returnImage();

            //remove card from deck
            Deck.RemoveAt(location);
            DecrRanNum = Deck.Count();

            

            //give user first Card
             location = getRandomNumber();
            //MessageBox.Show("Deal1 card after user " + Deck[location].Getname());


            //determine if player has jack
            if (Deck[location].Getname() == "Ace of Spades" || Deck[location].Getname() == "Ace of Diamonds" || Deck[location].Getname() == "Ace of Hearts" || Deck[location].Getname() == "Ace of Clubs")
            {
                HasJack++;
                //MessageBox.Show("User's jacks after user first deal " + HasJack);

            }


            user.SetUserCard(Deck[location]);
           
            //set first image to corresponding card
            Userimage1 = Deck[location].returnImage();

            //remove card from deck
            Deck.RemoveAt(location);
            DecrRanNum = Deck.Count();
            

            //give player3 one first card
             location = getRandomNumber();
            //MessageBox.Show("Deal1 card  player3 " + Deck[location].Getname());
            if (Deck[location].Getname() == "Ace of Spades" || Deck[location].Getname() == "Ace of Diamonds" || Deck[location].Getname() == "Ace of Hearts" || Deck[location].Getname() == "Ace of Clubs")
            {
                Player3HasJack++;
                //MessageBox.Show("Player3 jacks after first deal" + Player1HasJack);
            }

            Player3.SetUserCard(Deck[location]);

            // set Playe 1 image to corresponding card
            Player3image1 = Deck[location].returnImage();

            //remove card from deck
            Deck.RemoveAt(location);
            DecrRanNum = Deck.Count();

                                    


            //Deal cards to dealer
            location = getRandomNumber();

            //MessageBox.Show("deal 1 card after dealer " + Deck[location].Getname());

            //determine if dealer has jack
            if (Deck[location].Getname() == "Ace of Spades" || Deck[location].Getname() == "Ace of Diamonds" || Deck[location].Getname() == "Ace of Hearts" || Deck[location].Getname() == "Ace of Clubs")
            {
                DealerHasJack++;
            }


            dealer.SetUserCard(Deck[location]);

            //set dealers image to card
            Dealerimage1 = Deck[location].returnImage();

            Deck.RemoveAt(location);
            DecrRanNum = Deck.Count();

            ////give player1 second card
            location = getRandomNumber();

            //MessageBox.Show("deal 2 card after player1 " + Deck[location].Getname());

            if (Deck[location].Getname() == "Ace of Spades" || Deck[location].Getname() == "Ace of Diamonds" || Deck[location].Getname() == "Ace of Hearts" || Deck[location].Getname() == "Ace of Clubs")
            {
                Player1HasJack++;
            }

            Player1.SetUserCard(Deck[location]);
            Player1image2 = Deck[location].returnImage();

            //deterimine if player1 has two jacks
            player1SubtrackJack();

            //remove card from deck
            Deck.RemoveAt(location);
            DecrRanNum = Deck.Count();

            //Give user Second Card
            location = getRandomNumber();
            //MessageBox.Show("deal 2 card after user " + Deck[location].Getname());

            //determine if player has a jack
            if (Deck[location].Getname() == "Ace of Spades" || Deck[location].Getname() == "Ace of Diamonds" || Deck[location].Getname() == "Ace of Hearts" || Deck[location].Getname() == "Ace of Clubs")
            {
                HasJack++;
                //MessageBox.Show("User's jacks after user second deal " + HasJack);
            }

            user.SetUserCard(Deck[location]);

            //If user has two jacks it will minus 10 from user score
            PlayerSubtractJack();

            //set second image to corresponding card
            Userimage2 = Deck[location].returnImage();

            ////remove card from deck
            Deck.RemoveAt(location);
            DecrRanNum = Deck.Count();


            //give player3  second card
            location = getRandomNumber();
            //MessageBox.Show("Deal2   player3 " + Deck[location].Getname());
            if (Deck[location].Getname() == "Ace of Spades" || Deck[location].Getname() == "Ace of Diamonds" || Deck[location].Getname() == "Ace of Hearts" || Deck[location].Getname() == "Ace of Clubs")
            {
                Player3HasJack++;
                //MessageBox.Show("Player3 jacks after first deal" + Player1HasJack);
            }

            Player3.SetUserCard(Deck[location]);


            //Subtract 10 if player3 has 2 jacks
            player3SubtrackJack();

            // set Playe 1 image to corresponding card
            Player3image2 = Deck[location].returnImage();

            //remove card from deck
            Deck.RemoveAt(location);
            DecrRanNum = Deck.Count();


            //Give Dealer Second Card
            location = getRandomNumber();
            //MessageBox.Show("deal 2 card after dealer " + Deck[location].Getname());

            //determine if dealer has jack
            if (Deck[location].Getname() == "Ace of Spades" || Deck[location].Getname() == "Ace of Diamonds" || Deck[location].Getname() == "Ace of Hearts" || Deck[location].Getname() == "Ace of Clubs")
            {
                DealerHasJack++;
            }

            dealer.SetUserCard(Deck[location]);
            DealerSubtrackJack();

            //set Dealer second image to the second card. 
            //It won't be revealed until after the uset clicks stay

            Dealerimage2 = Deck[location].returnImage();

            Deck.RemoveAt(location);
            DecrRanNum = Deck.Count();

           

            //if (DetermineScoreForDealer() == 21)
            //{
            //    MessageBox.Show("Dealer Wins!");
            //    //this.Close();
            //}


        }

        static int getRandomNumber()
        {
            int x = rn.Next(DecrRanNum);

            return x;
        }
        public int DetermineScoreForPlayer1()
        {

            return Player1.value;
        }

        public int DetermineScoreForPlayer3()
        {

            return Player3.value;
        }
        public int DetermineScoreForUser()
        {
            //I did change the name from Player to User
            return user.value;
        }
        public int DetermineScoreForDealer()
        {

            return dealer.value;
        }
        public void DetermineWinner()
        {
            if (DetermineScoreForDealer() > 21)
            {
                money = money + bet;

                wins++;
                MessageBox.Show("You Win!");

                //this.Close();
                //   Application.Exit();

            }

            else if (DetermineScoreForUser() <= DetermineScoreForDealer() || DetermineScoreForUser() > 21 || DetermineScoreForDealer() == 21)
            {
                money = money - bet;

                MessageBox.Show("Dealer Wins!");
                //this.Close();

                //  Application.Exit();
            }

            else if (DetermineScoreForUser() > DetermineScoreForDealer() || DetermineScoreForDealer() > 21 || DetermineScoreForUser() == 21)
            {
                wins++;
                money = money + bet;

                MessageBox.Show("You Win! ");
                //this.Close();
                //  Application.Exit();

            }


        }

        public void Hit(string player)
        {
            //Assign another card to user
            //Uses the same logic as deal method
            int location;
            switch(player )
            {
                case "user":

                    location = getRandomNumber();
                    //MessageBox.Show("user hit card " + Deck[location].Getname());
                    if (Deck[location].Getname() == "Ace of Spades" || Deck[location].Getname() == "Ace of Diamonds" || Deck[location].Getname() == "Ace of Hearts" || Deck[location].Getname() == "Ace of Clubs")
                    {
                        HasJack++;
                        //MessageBox.Show("Jacks after user hit " + HasJack);

                    }


                    //this is not adding the correct card
                    user.SetUserCard(Deck[location]);
                    PlayerSubtractJack();

                    //MessageBox.Show("User Image after user hit " + hit);

                    switch (hit)
                    {

                        case 3: Userimage3 = Deck[location].returnImage(); break;
                        case 4: Userimage4 = Deck[location].returnImage(); break;
                        case 5: Userimage5 = Deck[location].returnImage(); break;
                        case 6: Userimage6 = Deck[location].returnImage(); break;
                        case 7: Userimage7 = Deck[location].returnImage(); break;
                        case 8: Userimage8 = Deck[location].returnImage(); break;
                        case 9: Userimage9 = Deck[location].returnImage(); break;
                    }
                    Deck.RemoveAt(location);
                    DecrRanNum = Deck.Count();
                    //MessageBox.Show(user.Cards());



                    if (DetermineScoreForUser() > 21)
                    {
                        money = money - bet;

                        MessageBox.Show("Dealer Wins!!");
                        // Application.Exit();
                    }//end of if

                    
                    break;
                case "AI":


                    location = getRandomNumber();
                    //MessageBox.Show("Dealers card on hit " + Deck[location].Getname());
                    if (Deck[location].Getname() == "Ace of Spades" || Deck[location].Getname() == "Ace of Diamonds" || Deck[location].Getname() == "Ace of Hearts" || Deck[location].Getname() == "Ace of Clubs")
                    {
                        DealerHasJack++;
                    }

                    dealer.SetUserCard(Deck[location]);
                    DealerSubtrackJack();
                    switch (dealerhit)
                    {
                        case 3: Dealerimage3 = Deck[location].returnImage(); break;
                        case 4: Dealerimage4 = Deck[location].returnImage(); break;
                        case 5: Dealerimage5 = Deck[location].returnImage(); break;
                        case 6: Dealerimage6 = Deck[location].returnImage(); break;
                        case 7: Dealerimage7 = Deck[location].returnImage(); break;
                        case 8: Dealerimage8 = Deck[location].returnImage(); break;
                        case 9: Dealerimage9 = Deck[location].returnImage(); break;
                    }//end of switch

                    dealerhit++;
                    Deck.RemoveAt(location);
                    DecrRanNum = Deck.Count();

                   
                    break;
                case "Player1":


                    location = getRandomNumber();
                    //MessageBox.Show("Users card on hit " + Deck[location].Getname());

                    if (Deck[location].Getname() == "Ace of Spades" || Deck[location].Getname() == "Ace of Diamonds" || Deck[location].Getname() == "Ace of Hearts" || Deck[location].Getname() == "Ace of Clubs")
                    {
                        Player1HasJack++;
                    }

                    Player1.SetUserCard(Deck[location]);
                    player1SubtrackJack();
                    
                    switch (player1hit)
                    {
                        case 3: Player1image3 = Deck[location].returnImage(); break;
                        case 4: Player1image4 = Deck[location].returnImage(); break;
                        case 5: Player1image5 = Deck[location].returnImage(); break;
                        case 6: Player1image6 = Deck[location].returnImage(); break;
                        case 7: Player1image7 = Deck[location].returnImage(); break;
                        case 8: Player1image8 = Deck[location].returnImage(); break;
                        case 9: Player1image9 = Deck[location].returnImage(); break;
                    }//end of switch

                    player1hit++;
                    Deck.RemoveAt(location);
                    DecrRanNum = Deck.Count();


                    break;
                case "Player3":

                    location = getRandomNumber();
                    //MessageBox.Show("Users card on hit " + Deck[location].Getname());

                    if (Deck[location].Getname() == "Ace of Spades" || Deck[location].Getname() == "Ace of Diamonds" || Deck[location].Getname() == "Ace of Hearts" || Deck[location].Getname() == "Ace of Clubs")
                    {
                        Player3HasJack++;
                    }

                    Player3.SetUserCard(Deck[location]);
                    player3SubtrackJack();

                    switch (player3hit)
                    {
                        case 3: Player3image3 = Deck[location].returnImage(); break;
                        case 4: Player3image4 = Deck[location].returnImage(); break;
                        case 5: Player3image5 = Deck[location].returnImage(); break;
                        case 6: Player3image6 = Deck[location].returnImage(); break;
                        case 7: Player3image7 = Deck[location].returnImage(); break;
                        case 8: Player3image8 = Deck[location].returnImage(); break;
                        case 9: Player3image9 = Deck[location].returnImage(); break;
                    }//end of switch

                    player3hit++;
                    Deck.RemoveAt(location);
                    DecrRanNum = Deck.Count();
                                                            
                            break;
            }
            
        }//end of hit

        public void PlayerSubtractJack()
        {
            //MessageBox.Show("PlayerSubtractJack() Jacks " + HasJack + "DetermineScoreForPlayer() " + DetermineScoreForUser());
            while (HasJack > 0 && DetermineScoreForUser() > 21)
            {

                user.JackSubtraction();
                //MessageBox.Show("User subtracted 10.");

                HasJack--;
                //MessageBox.Show(" HasJack--");

            }

        }

        public void DealerSubtrackJack()
        {
            //MessageBox.Show("PlayerSubtractJack() Jacks" + HasJack);
            while (DealerHasJack > 0 && DetermineScoreForDealer() > 21)
            {
                //MessageBox.Show("PlayerSubtractJack() inside while " + DetermineScoreForPlayer());

                dealer.JackSubtraction();
                DealerHasJack--;

            }


        }

        public void player1SubtrackJack()
        {
            //MessageBox.Show("PlayerSubtractJack() Jacks" + HasJack);
            while (Player1HasJack > 0 && DetermineScoreForPlayer1() > 21)
            {
                //MessageBox.Show("PlayerSubtractJack() inside while " + DetermineScoreForPlayer());

                Player1.JackSubtraction();
                Player1HasJack--;

            }

        } //end of player1SubtrackJack


        public void player3SubtrackJack()
        {
            //MessageBox.Show("PlayerSubtractJack() Jacks" + HasJack);
            while (Player3HasJack > 0 && DetermineScoreForPlayer3() > 21)
            {
                //MessageBox.Show("PlayerSubtractJack() inside while " + DetermineScoreForPlayer());

                Player3.JackSubtraction();
                Player3HasJack--;

            }

        } //end of player1SubtrackJack

        public void ResetEverything()
        {
            user.resetPlayer();
            Player1.resetPlayer();
            dealer.resetPlayer();
            Player3.resetPlayer();

            HasJack = 0;
            Player1HasJack = 0;
            Player3HasJack = 0;
            DealerHasJack = 0;

            List_Of_Cards.Clear();
            //Deck.Clear();

            CreateDeck();
        }//end of method

        public void suggestion()
        {
            //first get users score
            int NumberNeeded = 0;
            int WinningOdds = 0;
            int LoosingOdds = 0;

            NumberNeeded = 21 - DetermineScoreForUser();

            

            //MessageBox.Show("Number Card Needed " + (NumberNeeded * 4) + "Cards in that range " + Cards_Played_In_Range(NumberNeeded));
            //second calculate how many cards are at or below the number needed

            //Need to account for the aces!!!
           WinningOdds = Cards_Played_In_Range(NumberNeeded);
           LoosingOdds = Cards_Played_Out_Range(NumberNeeded);

            //MessageBox.Show("WinningOdds " + WinningOdds + " LoosingOdds " + LoosingOdds);

            if(DetermineScoreForUser() == 21)
            {
                MessageBox.Show("Computer suggest you stay");
            }
            else if(WinningOdds > LoosingOdds){
                MessageBox.Show("Computer suggest you hit");
                 }
             else{
                MessageBox.Show("Computer suggest you stay");
                 }

            double Percentage_Of_Winning =  Math.Round(((double)WinningOdds / (WinningOdds + LoosingOdds) ) * 100,2);

            if (DetermineScoreForUser() != 21)
            {
                MessageBox.Show("You have a " + Percentage_Of_Winning + "% of drawing a " + NumberNeeded + " or lower");
            }
            else if(DetermineScoreForUser() == 21)
            {
                MessageBox.Show("You have a score of 21!");

            }



        }
        public int Cards_Played_In_Range(int max)
        {
            //MessageBox.Show("Max is " + max);

            int Winningcount = 0;
            for (int x=0; x< Deck.Count;x++)
            {
                //MessageBox.Show("Value of Card: " + Deck[x].Getnumber());
                if (Deck[x].Getnumber() <= max || Deck[x].Getname() == "Ace of Spades" || Deck[x].Getname() == "Ace of Diamonds"
                    || Deck[x].Getname() == "Ace of Hearts" || Deck[x].Getname() == "Ace of Clubs")
                {
                    Winningcount++;
                    //MessageBox.Show("Winningcount has been increased!");
                } 
            }

            //MessageBox.Show("WinningCount is " + Winningcount);

            return Winningcount++;
        }

        public int Cards_Played_Out_Range(int max)
        {
            //MessageBox.Show("Max is " + max);

            int Loosingcount = 0;
            for (int x = 0; x < Deck.Count; x++)
            {
                //MessageBox.Show("Value of Card: " + Deck[x].Getnumber());
                if (Deck[x].Getnumber() > max)
                {
                    Loosingcount++;

                    if (Deck[x].Getname() == "Ace of Spades" || Deck[x].Getname() == "Ace of Diamonds"
                    || Deck[x].Getname() == "Ace of Hearts" || Deck[x].Getname() == "Ace of Clubs")
                    {
                        Loosingcount--;
                    }
                    //MessageBox.Show("Winningcount has been increased!");
                }
            }

            //MessageBox.Show("Loosingcount is " + Loosingcount);



            return Loosingcount++;
        }
    }
}