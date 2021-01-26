using System;

namespace NovemberProjekt
{
    public class Player
    {

        public string action;
        
        public string actionHit()
        {
            return action;
        }

        public string actionHold()
        {

            return action;

        }

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
        }

    }
}
