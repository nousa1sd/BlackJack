using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack_AI
{
    class User
    {

        public List<String> Cardnames = new List<String>();

        public Card1 TheCard { get; set; }
        //public List<String> Name { get;  set; }
        public int value { get; set; }

        public string name { get; set; }

        public int wins { get; set;  }

        public void SetUserCard(Card1 card)
        {
            TheCard = card;
            Score(TheCard.Getnumber());

        }

        public void JackSubtraction()
        {
            value = value - 10;
        }
        public int Score(int score)
        {
            value = value + TheCard.Getnumber();
            CardsTheyHave();

            return value;

        }

        public void CardsTheyHave()
        {
            Cardnames.Add(TheCard.Getname());

          //  Name = Cardnames;


        }

        public String Cards()
        {
            //String name = "" ;
            for(int x = 0; x< Cardnames.Count(); x++)
            {
                name = name + "\n " + Cardnames[x];
            }
            return "Cards: " + name;
        }

        public int UsersScore()
        {

            int x = value;
            return x;
        }

        public void resetPlayer()
        {
            value = 0;
            name = "";
            Cardnames.Add(name);
            Cardnames.Clear();
            TheCard = null;

        }

    }
}
