using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        //added a property to hold onto the users roll value
        public int RollValue { get; set; }

        //once its the humans turn it starts asking questions, and it verifys its a number (try/catch), and that the number is between 6 and 1(if / else)
        public HumanPlayer()
        {
            Console.WriteLine("Welcome to your Destiny, I know you are here because you want to play a game...");
            Console.WriteLine("Wwwwhhat is your name traveler?");
            Name = Console.ReadLine();
            string PlayerName = Name.ToString();
            Console.WriteLine($"WeelCome  {Name}? ... Isnt that a weird name");
            ReRoll:
                Console.WriteLine($"Please Roll a 6 sided dice and enter your number OR enter without a number and let me do the rolling");
            string RollValuestr = Console.ReadLine();
            try
            {
                RollValue = Int32.Parse(RollValuestr);
                if (RollValue > 6 || RollValue < 1)
                {
                    Console.WriteLine($"How did you roll '{RollValue}' with a 6 sided die?");
                    Console.WriteLine($"Try again");
                    goto ReRoll;
                }
                else
                {
                    Console.WriteLine($"I see you rolled a {RollValue}, Lets see how this plays out");
                }
            }
            // expected exception
            catch (FormatException)
            {
                Console.WriteLine($"Something went wrong, i dont think that '{RollValuestr}' was a number");
                goto ReRoll;

            }
        }

        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = RollValue;
            int otherRoll = other.Roll();

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