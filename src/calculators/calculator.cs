using RPGTools.Dice;

namespace RPGTools.calculators; 

public static class Calculator {
    public static int CalculateAbilityModifier (int abilityScore)
    { return (abilityScore - 10) / 2; }

    // Calculate proficiency bonus based on character level
    public static int CalculateProficiencyBonus (int characterLevel)
    { return ((characterLevel - 1) / 4) + 2; }

    // Calculate health points based on dice type, character level,
    // constitution modifier, and average rolls
    public static int CalculateHealthPoints
    (
        DiceType diceType,
        int characterLevel,
        int constitutionModifier,
        bool isAverage = false
    )
    {
        if (characterLevel < 0)
        {
            throw new ArgumentOutOfRangeException
            (
                nameof(characterLevel),
                "Character level can't be negative."
            );
        }

        // First level HP
        int HPValue = (int)diceType + constitutionModifier;
        
        // Subsequent levels
        for (int level = 2; level <= characterLevel; level++)
        {
            if (isAverage)
            {
                HPValue += (int)diceType / 2 + 1 + constitutionModifier;
            }
            else
            {
                HPValue += Roll.RollDice(diceType)[2] + constitutionModifier;
            }
        }
        return HPValue;
    }
}