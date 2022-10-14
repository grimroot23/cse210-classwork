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
    }

    class begin_game
    {
        
        static void Main(string[] args)
        {
            int new_card = new Random().Next(1, 13);
            init_card_score draw_card = new init_card_score();
            draw_card.Lastcard = 0;
            draw_card.Card = new_card;
            int score = 300;

            //get input of h or l
            Console.WriteLine("h or l: ");
            string guess = Console.ReadLine();

            if (guess == "h") 
            {

                if (new_card > draw_card.Lastcard)
                {
                    score += 100;
                    Console.WriteLine($"score:{score}");
                }
                else 
                {
                    score -= 75;
                    Console.WriteLine($"score:{score}");
                }
            }
            else if (guess == "l") 
            {

                if (new_card < draw_card.Lastcard)
                {
                    score += 100;
                    Console.WriteLine($"score:{score}");
                }
                else 
                {
                    score -= 75;
                    Console.WriteLine($"score:{score}");
                }
            }

            draw_card.Lastcard = new_card;

            if (guess == "h") 
            {

                if (new_card > draw_card.Lastcard)
                {
                    score += 100;
                    Console.WriteLine($"score:{score}");
                }
                else 
                {
                    score -= 75;
                    Console.WriteLine($"score:{score}");
                }
            }
            else if (guess == "l") 
            {

                if (new_card < draw_card.Lastcard)
                {
                    score += 100;
                    Console.WriteLine($"score:{score}");
                }
                else 
                {
                    score -= 75;
                    Console.WriteLine($"score:{score}");
                }
            }

            
        }
    }

    
}
