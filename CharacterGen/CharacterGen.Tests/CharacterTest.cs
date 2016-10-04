using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterGen.Tests
{
    [TestClass]
    public class CharacterTest
    {
        [TestMethod]
        public void AbilityModifiersCalculateCorrectly()
        {
            Character TestCharacter = new Character();
            double[] TestCharacterStats = new double[6];

            //Strength
            TestCharacterStats[0] = 8;
            //Dexterity
            TestCharacterStats[1] = 10;
            //Constitution
            TestCharacterStats[2] = 12;
            //Intelligence
            TestCharacterStats[3] = 14;
            //Wisdom
            TestCharacterStats[4] = 16;
            //Charisma
            TestCharacterStats[5] = 18;

            TestCharacter.UpdateStats(TestCharacterStats);

            Assert.AreEqual(TestCharacter.StrengthModifier, -1);
            Assert.AreEqual(TestCharacter.DexterityModifier, 0);
            Assert.AreEqual(TestCharacter.ConstitutionModifier, 1);
            Assert.AreEqual(TestCharacter.IntelligenceModifier, 2);
            Assert.AreEqual(TestCharacter.WisdomModifier, 3);
            Assert.AreEqual(TestCharacter.CharismaModifier, 4);

            //Strength
            TestCharacterStats[0] = 9;
            //Dexterity
            TestCharacterStats[1] = 11;
            //Constitution
            TestCharacterStats[2] = 13;
            //Intelligence
            TestCharacterStats[3] = 15;
            //Wisdom
            TestCharacterStats[4] = 17;
            //Charisma
            TestCharacterStats[5] = 19;

            Assert.AreEqual(TestCharacter.StrengthModifier, -1);
            Assert.AreEqual(TestCharacter.DexterityModifier, 0);
            Assert.AreEqual(TestCharacter.ConstitutionModifier, 1);
            Assert.AreEqual(TestCharacter.IntelligenceModifier, 2);
            Assert.AreEqual(TestCharacter.WisdomModifier, 3);
            Assert.AreEqual(TestCharacter.CharismaModifier, 4);
        }
    }
}
