using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {

        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int otherRoll = other.Roll();
            int myRoll = Roll();

            //conditional on rolling a 6 to avoid rolling 7... NO One Likes a Cheater!@!
            if (otherRoll < 6)
            {
                myRoll = otherRoll + 1;
            }
            else
            {
                myRoll = otherRoll;

            }
            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }

        }
    }
}