using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleplayGame
{
    public interface IEnemygit 
    {
        int VictoryPoints {get; set;}
        void SetVictoryPoints(int points);
        
        int GetVictoryPoints();
    }
}