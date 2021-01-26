using System.Collections.Generic;
using System;

namespace NovemberProjekt
{
    public class Board: Deck
    {
        
        public int boardValue;
        
        private List<int> cards = new List<int>();

        public int CalcBoardValue()
        {
            
            // For-Loop för att ta värdena från listen och addera ihop till ett värde.

            return boardValue;
        }
    }
}
