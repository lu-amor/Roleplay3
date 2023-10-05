using System.Reflection;

namespace RoleplayGame
{
    public class EncounterTests : Encounter {
        [Test]
        public void MissingHeroInEncounter() {
            Enemy enemy = new Enemy("Alfred");
            Heroe hero = new Heroe("Andres");

            Encounter enc = new Encounter();
            enc.AddEnemy(enemy);
            // enc.AddHeroe(hero);

            bool statusEncounter = enc.CheckFighters();
            Assert.False(statusEncounter);
        }
    }
}