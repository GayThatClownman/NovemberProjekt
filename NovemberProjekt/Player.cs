using System;

namespace NovemberProjekt
{
    public class Player
    {
        // Variabel "action" som används i olika actionmetoder som utför det spelaren vill göra.
        public string action;
        
        // Metod för spelaren som utför handlingen  "Hit", där ett kort tas från dens List, och dess värde adderas till spelarens totala kort-värde.
        public string ActionHit()
        {
            return action;
        }

        // Metod för spelaren som utför handlingen "Hold", där spelarens kort-värde jämförs med det slumpade talet för att se om han vinner. 
        public string ActionHold()
        {

            return action;

        }

        // Metod för spelaren som utför handlingen "End", som avslutar spelet.
        public string ActionEnd()
        {
            return action;
        }

        // Metod som körs i början av spelet som skriver ut instruktioner till spelaren om hur spelet körs. 
        public void IntroPrompt()
        {
            System.Console.WriteLine("Welcome to BlackJack!");
            System.Console.WriteLine("Press ENTER to get started!");
            Console.ReadLine();

            Console.Clear();

            System.Console.WriteLine("Instructions:");
            System.Console.WriteLine("You goal is to have the value of your cards get as close to 21, without ever exceeding the number.");
            System.Console.WriteLine("You have two actions: 'HIT' and 'HOLD'.");
            System.Console.WriteLine("HIT - Hands you another card and adds its value to your total.");
            System.Console.WriteLine("HOLD - Ends your turn and compares your hand to the dealer.");
            System.Console.WriteLine("");
            System.Console.WriteLine("At any point, type STOP to exit out of the game.");
            System.Console.WriteLine("");
            System.Console.WriteLine("Press ENTER to start playing.");

            Console.ReadLine();
            Console.Clear();
        }

    }
}
