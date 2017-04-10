using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack_AI
{
    class Card1//: GamePlay
    {
        //(Image)Properties.Resources.Ace_Of_Spades;
        private string name;
        private int number;
        private Image resource;

        //public Card1(string name, int number)
        //{
        //    this.name = name;
        //    this.number = number;
        //}

        public Card1(string name, int number, Image resource)
        {
            this.name = name;
            this.number = number;
            this.resource = resource;
        }

        public string Getname() { return name; }
        public int Getnumber() { return number; }

        // public int number { get; set; }
        public string getValues()
        {
            return "Name: " + name + "   number: " + number;
        }// end of ToString


        public Image returnImage()
        {

            return resource;
        }



    }
}
