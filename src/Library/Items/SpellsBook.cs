using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook: AttackDefenseItem, IMagicalAttackItem, IMagicalDefenseItem
    {
        private List<ISpell> spells = new List<ISpell>();
        
        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (ISpell spell in this.spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public override int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (ISpell spell in this.spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }

        public bool AddSpell(ISpell spell)
        {
            this.spells.Add(spell);
            return true;
        }

        public bool RemoveSpell(ISpell spell)
        {
            this.spells.Remove(spell);
            return false; 
        }
    }
}