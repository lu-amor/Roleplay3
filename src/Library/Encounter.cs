using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace RoleplayGame
{
    public class Encounter
    {
        private List<Heroe> Heroes;
        private List<Enemy> Enemies;

        public Encounter() {}

        public void AddHeroe(Heroe h) {
            this.Heroes.Add(h);
        }
        public void AddEnemy(Enemy e) {
            this.Enemies.Add(e);
        }

        public void DoEncounter() {
            if ((this.Heroes.Count > 0) && (this.Enemies.Count > 0)) {
                // Si hay más de un enemigo y más de un héroe
                if ((this.Heroes.Count > 1) && (this.Enemies.Count > 1)) {
                    foreach (Enemy enemy in this.Enemies) {
                        int enemyIndex = this.Enemies.IndexOf(enemy);
                        Heroe h = this.Heroes[enemyIndex];

                        // enemy.Attack(h);
                    }   
                }

                // Si hay menos héroes (N) que enemigos (M)
                if (this.Heroes.Count < this.Enemies.Count) {
                    int heroeIndex = 0;
                    foreach (Enemy enemy in this.Enemies) {
                        int nextEnemyIndex = this.Enemies.IndexOf(enemy) + 1;
                        Enemy nextEnemy = this.Enemies[nextEnemyIndex];

                        Heroe h = this.Heroes[heroeIndex];
                        // enemy.Attack(h)

                        heroeIndex += 1;
                    }
                }
            } else { /* Se necesita minimo un heroe y un enemy para arrancar */ }
        }
    }
}