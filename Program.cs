using System;

namespace CSE210_Hilo 
{
    class init_card_score
    {
        private int card = 0;
        public int Card
        {
            get{return card;}
            set{card=value;}
        }
        //---------------------------------------
        private int lastcard = 0;
        public int Lastcard
        {
            get{return lastcard;}
            set{lastcard=value;}
        }
        //---------------------------------------
        int score = 300;
    }

    class begin_game
    {
        
        static void Main(string[] args)
        {
            int new_card = new Random().Next(1, 13);

            init_card_score draw_card = new init_card_score();
            draw_card.Card = new_card;
            draw_card.Lastcard = new_card;
        }
    }

    
}
