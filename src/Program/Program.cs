using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args) {
            Console.Clear();

            SpellsBook sb = new SpellsBook();
            sb.AddSpell(new SpellOne());
            sb.AddSpell(new SpellOne());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(sb);

            Dwarf gimli = new Dwarf("Gimli");

            Giant giant = new Giant("Ryan the Giant");
            Goblin goblin = new Goblin("Bob");

            Encounter enc = new Encounter();
            
            enc.AddHeroe(gandalf);
            enc.AddHeroe(gimli);
            enc.AddEnemy(giant);
            enc.AddEnemy(goblin);

            bool readyToFight = enc.CheckFighters();
            if (readyToFight) {
                Console.WriteLine($"Encounter has started!\n");
                enc.DoEncounter();
            } else { Console.WriteLine("Encounter has could not be started..."); }
        }
    }
}
