using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal class GameCharacter
    {
        public string Name;
        public int HP;
        public int MinStrength;
        public int MaxStrength;
        public int Stamina;
        public int MaxStamina;

        public GameCharacter(string name, int hp, int minstrength, int maxstrenght, int stamina, int maxstamina)
        {
            Name = name;
            HP = hp;
            MinStrength = minstrength;
            MaxStrength = maxstrenght;
            Stamina = stamina;
            MaxStamina = maxstamina;
        }

        public static void Fight(GameCharacter attacker, GameCharacter defender)
        {
            Random random = new Random();
            int attack = random.Next(attacker.MinStrength, attacker.MaxStrength);
            defender.HP -= attack;
            attacker.Stamina -= 10;
            Console.WriteLine($"{attacker.Name} attacked {defender.Name} for {attack}, {defender.Name} now has {defender.HP} HP");
            Console.ReadKey(true);
        }

        public static void Recharge(GameCharacter user)
        {
            user.Stamina = user.MaxStamina;
            Console.WriteLine($"{user.Name} is recharging. His stamina is now {user.Stamina}");
            Console.ReadKey(true);
        }

    }
}
