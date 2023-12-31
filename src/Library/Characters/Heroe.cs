using System;
using System.Collections.Generic;
namespace RoleplayGame
{
    public class Heroe : IHeroe, ICharacter
    {
        public int VictoryPoints {get; set;}

        public void SetVictoryPoints(int points) {
            this.VictoryPoints = points;
        }
        public int GetVictoryPoints() {
            return this.VictoryPoints;
        }
        protected int health = 100;

        protected List<IItem> items = new List<IItem>();

        public Heroe(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
                Console.WriteLine($"{this.Name} now has ❤️ {this.Health}");
            }
        }

        public void Cure()
        {
            this.Health = 100;
            Console.WriteLine($"Someone cured {this.Name}. {this.Name} now has ❤️ {this.Health}");
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }

        public void Attack(ICharacter target) {
            Console.WriteLine($"{this.Name} attacks {target.Name} with ⚔️ {this.AttackValue}");
            target.ReceiveAttack(this.AttackValue);
        }
    }
}
