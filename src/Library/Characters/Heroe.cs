using System.Collections.Generic;
using System.Collections.Generic;
namespace RoleplayGame
{
    public class Heroe : IHeroe
    {
               public int VictoryPoints {get; set;}

        public void SetVictoryPoints(int points) {
            this.VictoryPoints = points;
        }
        public int GetVictoryPoints() {
            return this.VictoryPoints;
        }
    }
}
