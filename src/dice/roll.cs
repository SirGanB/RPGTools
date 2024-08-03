using System;

namespace RPGTools.Dice
{
    // Static class for managing rolls
    public static class Roll
    {
        // Method to roll a die with a given type and apply a modifier
        public static int[] RollDice
        (
            DiceType diceType,
            RollType rollType = RollType.Normal,
            int modifier = 0
        )
        {
            // Roll the die and apply the modifier
            int roll1 = 0;
            int roll2 = 0;
            int result = 0;

            roll1 = RollSingleDie(diceType);

            switch (rollType)
            {
                case RollType.Advantage:
                {
                    roll2 = RollSingleDie(diceType);
                    result = Math.Max(roll1, roll2);
                }
                break;
                case RollType.Disadvantage:
                {
                    roll2 = RollSingleDie(diceType);
                    result = Math.Min(roll1, roll2);
                }
                break;
                default:
                    result = roll1;
                break;
            }
            result += modifier;

            return [roll1, roll2, result];
        }

        // Helper method to roll a single die
       private static int RollSingleDie(DiceType diceType)
        {
            // Check if the provided diceType is a valid value within the DiceType enum.
            // Enum.IsDefined checks if the diceType exists within the defined values of the DiceType enum.
            if (!Enum.IsDefined(typeof(DiceType), diceType))
            throw new ArgumentException("Invalid dice type.");

            Random random = new();

            // Generate a random number between 1 and the maximum value of the diceType.
            // The maximum value is determined by casting diceType to an int and adding 1.
            // random.Next(1, maxValue) generates a number in the range [1, maxValue), 
            // so we need to add 1 to include the maximum value.
            return random.Next((int)diceType) +1;
        }
    }
}

public enum RollType {
    Normal,
    Advantage,
    Disadvantage,
}