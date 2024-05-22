using System.Data;

namespace Bossfight
{
    internal class Program
    {
        
        public static GameCharacter Player = new GameCharacter("Frode", 100, 20, 40, 40);
        public static GameCharacter Boss = new GameCharacter("The Duke of Flies", 400, 20, 10, 40);
        public static bool gameState = true;
        static void Main(string[] args)
        {
            while (Player.HP > 0 && Boss.HP > 0)
            {
                Console.Clear();
                Console.WriteLine($"{Player.Name}     vs     {Boss.Name}");
                Console.WriteLine($"Health: {Player.HP}          Health:{Boss.HP}");
                Console.WriteLine($"Strength: {Player.Strength}          Strength:{Boss.Strength}");
                Console.WriteLine($"Stamina: {Player.Stamina}          Stamina:{Boss.Stamina}");
                Console.WriteLine();
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Recharge");

                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    GameCharacter.Fight(Player, Boss);
                } else if (userInput == "2")
                {
                    GameCharacter.Recharge(Player);
                }
                Random random = new Random();
                int cpuInput = random.Next(1, 3);
                
                    if (cpuInput == 1)
                    {
                        GameCharacter.Fight(Boss, Player);
                    } else if (cpuInput == 2)
                    {
                        GameCharacter.Recharge(Boss);
                    }
                
            }
        }
    }
}
