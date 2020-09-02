using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Return a random number between the size of the dice divided by 2 and DiceSize + 1 
            //first number is inclusive, 2nd number is exclusive
            return new Random().Next(DiceSize / 2, DiceSize + 1);
        }

    }
}