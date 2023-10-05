using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace RoleplayGame
{
    public class Encounter
    {
        public List<Heroe> Heroes = new List<Heroe>();
        public List<Enemy> Enemies = new List<Enemy>();

        public Encounter() {}

        public void AddHeroe(Heroe h) {
            this.Heroes.Add(h);
        }
        public void AddEnemy(Enemy e) {
            this.Enemies.Add(e);
        }

        public bool CheckFighters() {
            if (this.Heroes.Any() && this.Enemies.Any()) { return true; }
            return false;
        }

        private void CheckAliveness() {
            foreach (Heroe heroe in Heroes){
                if (heroe.Health <= 0) {
                    Heroes.Remove(heroe);
                }
            }
            foreach (Heroe enemy in Heroes){
                if (enemy.Health <= 0) {
                    Heroes.Remove(enemy);
                }
            }
        }

        public void DoEncounter() {
            if (!CheckFighters()) { return; }

            bool battleStatus = true;
            int roundCount = 1;
            while (battleStatus){
                CheckAliveness();

                if ((this.Heroes.Count > 0) && (this.Enemies.Count > 0)) {
                    Console.WriteLine($"<--- ROUND {roundCount} --->");
                    // Si hay más de un enemigo y más de un héroe
                    if ((this.Heroes.Count > 1) && (this.Enemies.Count > 1)) {
                        foreach (Enemy enemy in this.Enemies) {
                            int enemyIndex = this.Enemies.IndexOf(enemy);
                            Heroe h = this.Heroes[enemyIndex];

                            enemy.Attack(h);
                        }   
                    } else if (this.Heroes.Count < this.Enemies.Count) {
                        int heroeIndex = 0;
                        foreach (Enemy enemy in this.Enemies) {
                            int nextEnemyIndex = this.Enemies.IndexOf(enemy) + 1;
                            Enemy nextEnemy = this.Enemies[nextEnemyIndex];

                            Heroe h = this.Heroes[heroeIndex];
                            enemy.Attack(h);

                            heroeIndex += 1;
                        }
                    }

                    if ((this.Heroes.Count > 0) && (this.Enemies.Count > 0)) {
                        if ((this.Heroes.Count > 1) && (this.Enemies.Count > 1)) {
                            foreach (Heroe heroe in this.Heroes) {
                                int heroeIndex = this.Heroes.IndexOf(heroe);
                                Enemy e = this.Enemies[heroeIndex];

                                heroe.Attack(e);
                            }   
                        } else if (this.Enemies.Count < this.Heroes.Count) {
                            int enemyIndex = 0;
                            foreach (Heroe heroe in this.Heroes) {
                                int nextHeroeIndex = this.Heroes.IndexOf(heroe) + 1;
                                Heroe nextHeroe = this.Heroes[nextHeroeIndex];

                                Enemy e = this.Enemies[enemyIndex];
                                heroe.Attack(e);
                                enemyIndex += 1;
                            }
                        }
                    } else { battleStatus = false; }

                    Console.WriteLine("\n");
                    roundCount++;

                    if ((!this.Heroes.Any() && this.Enemies.Any()) || (this.Heroes.Any() && !this.Enemies.Any())) { battleStatus = false; }
                }
            }
        }
    }
}