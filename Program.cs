using RPGTools.calculators;
using RPGTools.Dice;

namespace RPGTools
{
    class Program
    {
        static void Main()
        {
            int value;

            //Ability Score Calculate Example
            value = Calculator.CalculateAbilityModifier(
                abilityScore: 20
            );

            Console.WriteLine($"Ability Score Modifier: {value}");

            //Average Health Points Calculate Example
            value = Calculator.CalculateHealthPoints(
                diceType: DiceType.D12,
                characterLevel: 20,
                constitutionModifier: 6,
                isAverage: true
            );
            Console.WriteLine($"Barbarian HP Average: {value}");

            //Normal Health Points Calculate Example
            value = Calculator.CalculateHealthPoints(
                diceType: DiceType.D10,
                characterLevel: 12,
                constitutionModifier: 3
            );
            Console.WriteLine($"Fighter HP Roll: {value}");

            //Profiency Bonus Calculate Example
            value = Calculator.CalculateProficiencyBonus(
                characterLevel: 20
            );
            Console.WriteLine($"Profiency Bonus: {value}");
        }
    }
}