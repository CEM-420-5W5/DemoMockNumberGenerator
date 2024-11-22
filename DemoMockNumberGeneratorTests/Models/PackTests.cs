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
        public void OpenPackTest()
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

        // Les étpaes:
        // 1. Créer un MonRandomNumberGenerator
        // 2. Créer un IRandomNumberGenerator et un NotSoRandomNumberGenerator
        // 3. Créer un MockIRandomNumberGenerator avec un SetupSequence
    }
}