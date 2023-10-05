using Microsoft.Win32.SafeHandles;
using NUnit.Framework;

namespace RoleplayGame
{
    public class EncounterTests : Encounter
    {   
        [Test]
        public void DwarfReceiveAttack() {
            Dwarf Dw = new Dwarf("Pepe");
            Dw.SetVictoryPoints(5);

            Skeleton Sk = new Skeleton("Juan");
            Sk.SetVictoryPoints(2);
        
            Heroes.AddHeroe(Dwarf Dw);
        }
    }
}