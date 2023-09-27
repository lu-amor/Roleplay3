namespace RoleplayGame
{
    public class Staff: AttackDefenseItem
    {
        public override int AttackValue 
        {
            get
            {
                return 100;
            } 
        }

        public override int DefenseValue
        {
            get
            {
                return 100;
            }
        }
    }
}