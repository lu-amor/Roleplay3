using System.Collections.Generic;
namespace RoleplayGame
{
    public interface IHeroe
    {
        int VictoryPoints {get; set;}
        void SetVictoryPoints(int points);
        
        int GetVictoryPoints();
    }
}