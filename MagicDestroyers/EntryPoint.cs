using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            Warrior warrior = new Warrior("Phil", 80, 100);
            Console.WriteLine(warrior.Weapon);
            Console.WriteLine(warrior.BodyArmor);
            warrior.Strike();

            Necromancer necromancer = new Necromancer();
            Console.WriteLine(necromancer.Name);
            Console.WriteLine(necromancer.Weapon);
            Console.WriteLine(necromancer.BodyArmor);

            Console.ReadKey();

        }
    }
}
