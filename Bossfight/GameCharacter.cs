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
        public int Strength;
        public int Stamina;
        public int MaxStamina;

        public GameCharacter(string name, int hp, int strength, int stamina, int maxstamina)
        {
            Name = name;
            HP = hp;
            Strength = strength;
            Stamina = stamina;
            MaxStamina = maxstamina;
        }

        public static void Fight(GameCharacter attacker, GameCharacter defender)
        {
            defender.HP -= attacker.Strength;
            attacker.Stamina -= 10;
            Console.WriteLine($"{attacker.Name} attacked {defender.Name} for {attacker.Strength}, {defender.Name} now has {defender.HP} HP");
            Console.ReadKey(true);
        }

        public static void Recharge(GameCharacter user)
        {
            user.Stamina = user.MaxStamina;
            Console.WriteLine($"{user.Name}'s stamina is now {user.Stamina}");
            Console.ReadKey(true);
        }

    }
}
