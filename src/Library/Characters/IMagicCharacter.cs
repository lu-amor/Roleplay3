namespace RoleplayGame
{
    public interface IMagicCharacter: ICharacter
    {
        void AddMagicItem(IMagicalItem item);

        void RemoveMagicItem(IMagicalItem item);
    }
}
