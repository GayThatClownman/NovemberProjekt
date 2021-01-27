using System;
using System.Collections.Generic;

namespace NovemberProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //BlackJack

            // Bool för game-states som gör att spelet fortsätter att köras tills spelaren väljer att avsluta det.
            bool endState = false;
            bool gameState = true; //Temporär

            // While-loop som grund till game-state
            while (endState != true)
            {
                // Instanser av klasser.
                Player player = new Player();
                Deck deck = new Deck();

                player.IntroPrompt();

                gameState = false;

                // While-loop som startar och håller igång spel-aspekten av programmet, som gör att man inte behöver gå igenom introduktionen varje gång man spelar.
                while (gameState != true)
                {
                    deck.GetCardCount();
                    gameState = true;
                }
                
            }

            
        }
    }
}
