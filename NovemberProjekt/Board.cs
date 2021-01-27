using System.Collections.Generic;
using System;

namespace NovemberProjekt
{
    public class Board: Deck
    {
        // Int-variabel som innehåller det totala värdet av spelarens kort.
        private int boardValue;
        
        // List där korten som placeras på brädet lagras, där de sedan blir beräknade ifrån.
        public List<int> cards = new List<int>();

        // Metod som beräknar det totala värdet av ens kort.
        public int CalcBoardValue()
        {
            
           

            return boardValue;
        }
    }
}
