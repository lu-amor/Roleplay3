using System.Collections.Generic;
using System.Collections.Generic;
namespace RoleplayGame
{
    public class IHeroe
        public interface IEnemy
    {
        int VictoryPoints {get; set;}
        void SetVictoryPoints(int points);
        
        int GetVictoryPoints();
    }
}