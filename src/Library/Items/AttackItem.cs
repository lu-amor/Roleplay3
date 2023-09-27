namespace RoleplayGame
{
    public class AttackItem: IAttackItem
    {
        public virtual int AttackValue
        {
            get
            {
                return 0;
            }
        }
    }
}