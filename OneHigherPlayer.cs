using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer
    {
        public string OnTop { get; set; }

        public void alwaysOneUp()
        {
            Console.WriteLine($"Everythings Coming Up {OnTop}");
        }
    }
}