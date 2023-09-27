namespace RoleplayGame
{
    public class DefenseItem: IDefenseItem
    {
        public virtual int DefenseValue
        {
            get
            {
                return 0;
            }
        }
    }
}