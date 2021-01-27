using System.Collections.Generic;
using System;

namespace NovemberProjekt
{
    public class Deck: Card
    {

        // Int som lagras antalet kort i kortleken.
        private int cardCount;

        // List som lagras det individuella värdena av varje kort.
        public List<int> cardList = new List<int>();

        // Konstruktor som lägger till 4 set av 13 nummer från 1-13 som representerar korts värde.
        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                
                for (int x = 0; x < 13; x++)
                {
                    cardList.Add(x + 1);
                }
                
            }

            cardCount = cardList.Count;
        }
        
        // Metod som skriver ut antal kort i kortleken.
        public void GetCardCount()
        {
            System.Console.WriteLine(cardCount);
            // System.Console.WriteLine(cardList[0]);
            Console.ReadLine();
        }

        // Metod som sätter värdet på kort baserat på deras nummer utefter hur "Blackjack" system fungerar. 
        public int SetValue()
        {
            if (cardNumber <= 10 && cardNumber >= 1)
            {
                cardValue = cardNumber;
            }

            if (cardNumber <= 13 && cardNumber >= 11)
            {
                cardValue = 11;
            }

            return cardValue;
        }
    }
}
