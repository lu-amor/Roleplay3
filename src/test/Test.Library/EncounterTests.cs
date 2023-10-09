using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Win32.SafeHandles;
using NUnit.Framework;

namespace RoleplayGame
{
    public class EncounterTests
    {

        public List<Heroe> heroesList = new List<Heroe>();
        public List<Enemy> enemiesList = new List<Enemy>();

        [SetUp]
        public void SetUp(){
            Bow bow1 = new Bow();
            Dwarf pepe = new Dwarf("Pepe");
            pepe.SetVictoryPoints(5);
            pepe.AddItem(bow1);
            Axe axe1 = new Axe();
            Skeleton juan = new Skeleton("Juan");
            juan.SetVictoryPoints(2);

            Encounter enc = new Encounter();
            enc.AddHeroe(pepe);
            enc.AddEnemy(juan);

            bool readyToFight = enc.CheckFighters();
            if (readyToFight)
            {
                Console.WriteLine($"Encounter has started! \n");
                enc.DoEncounter();
            }
            else
            {
                System.Console.WriteLine($"Encounter could not be started.");
            }
        }
    }
}