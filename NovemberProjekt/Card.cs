using System;

namespace NovemberProjekt
{
    public class Card
    {
        // private string suit;
        private int cardNumber;
        private int cardValue;

        public int GetValue()
        {
            if (cardNumber <= 10 && cardNumber >= 2)
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
