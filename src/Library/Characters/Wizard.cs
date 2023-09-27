using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: Character, IMagicCharacter
    {
        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();
        private int value;

        public Wizard(string name): base(name)
        {
            this.AddItem(new Staff());
        }

        public int MagicAttackValue
        {
            get
            {
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalAttackItem)
                    {
                        value += (item as IMagicalAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public int MagicDefenseValue
        {
            get
            {
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalDefenseItem)
                    {
                        value += (item as IMagicalDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }
        public void AddMagicItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveMagicItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }
    }
}