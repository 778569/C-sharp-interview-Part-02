using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_and_Generics
{
    public class StackItem
    {


        public void Check()
        {
            Stack<string> deckOfCard = new Stack<string>();

            string card1 = "Jack : Diamonds";
            string card2 = "8 : Hearts";
            string card3 = "3 : Clubs";

            deckOfCard.Push(card1);
            deckOfCard.Push(card2);
            deckOfCard.Push(card3);

            //See what is in the top

            string Top = deckOfCard.Peek();
            Console.WriteLine("Top : " + Top);

            Console.WriteLine("Size of the Stack : " + deckOfCard.Count);

            string removeItem;
            while (deckOfCard.TryPop(out removeItem))
            {
                Console.WriteLine("Removed : " + removeItem);
            }

        }



        
    }
}
