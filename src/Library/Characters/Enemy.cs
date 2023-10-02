using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleplayGame
{
    public class Enemy : IEnemy
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