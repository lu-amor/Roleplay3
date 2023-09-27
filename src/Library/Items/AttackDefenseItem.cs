namespace RoleplayGame
{
    public class AttackDefenseItem: IAttackItem, IDefenseItem
    {
        public virtual int AttackValue
        {
            get
            {
                return 0;
            }
        }
        public virtual int DefenseValue
        {
            get
            {
                return 0;
            }
        }
    }
}