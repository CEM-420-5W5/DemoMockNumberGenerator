using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoMockNumberGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMockNumberGenerator.Models.Tests
{
    [TestClass()]
    public class PackTests
    {
        [TestMethod()]
        public void OpenPackBasicTest()
        {
            Pack pack = new Pack()
            {
                NbCards = 3,
                RareProbability = 0.333f
            };

            var rarities = pack.OpenPack();

            Assert.AreEqual(3, rarities.Count);
            Assert.AreEqual(2, rarities.Count(r => r == Pack.Rarity.Common));
        }

        [TestMethod()]
        public void OpenPackPremiumTest()
        {
            Pack pack = new Pack()
            {
                NbCards = 4,
                RareProbability = 0.75f
            };

            var rarities = pack.OpenPack();

            Assert.AreEqual(4, rarities.Count);
            Assert.AreEqual(1, rarities.Count(r => r == Pack.Rarity.Common));
            Assert.AreEqual(3, rarities.Count(r => r == Pack.Rarity.Rare));
        }

        // Les étpaes:
        // 1. Créer un MonRandomNumberGenerator et l'utiliser dans OpenPack (Toujours le même problème)
        // 2. Créer un IRandomNumberGenerator
        //    a. Créer un NotSoRandomNumberGenerator
        //    b. Ajouter une option pour le 2e test
        // 3. Explication des Mocks (Info)  
        // 4. Créer un MockIRandomNumberGenerator avec un SetupSequence


    }
}