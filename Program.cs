using RPGTools.Dice;

namespace RPGTools
{
    class Program
    {
        static void Main()
        {
            int[] rolls = [];

            Console.WriteLine("\nNormal Roll");
            rolls = Roll.RollDice(
                diceType: DiceType.D20,
                modifier: 3
            );

            foreach (int roll in rolls) {
                Console.WriteLine(roll);
            }

            Console.WriteLine("\nAdvantage Roll");
            rolls = Roll.RollDice(
                diceType: DiceType.D20,
                modifier: 3,
                rollType: RollType.Advantage
            );

            foreach (int roll in rolls) {
                Console.WriteLine(roll);
            }

            Console.WriteLine("\nDisadvantage Roll");
            rolls = Roll.RollDice(
                diceType: DiceType.D20,
                modifier: 3,
                rollType: RollType.Disadvantage
            );

            foreach (int roll in rolls) {
                Console.WriteLine(roll);
            }
        }
    }
}