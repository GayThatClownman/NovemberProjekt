using System.Collections.Generic;
using System;

namespace NovemberProjekt
{
    public class Deck
    {
        private int cardCount;
        public List<int> cardList = new List<int>();

        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                
                for (int x = 0; x < 13; x++)
                {
                    cardList.Add(x);
                }
                
            }

            cardCount = cardList.Count;
        }
    }
}
