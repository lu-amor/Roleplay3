using NUnit.Framework;

namespace RoleplayGame
{
    public class EncounterTests {
        [Test]
        public void MissingHeroInEncounter() {
            Orc enemy = new Orc("Alfred");
            Archer hero = new Archer("Andres");

            Encounter enc = new Encounter();
            enc.AddEnemy(enemy);
            // enc.AddHeroe(hero);

            bool statusEncounter = false; //enc.CheckFighters();
            Assert.False(statusEncounter);
        }
    }
}