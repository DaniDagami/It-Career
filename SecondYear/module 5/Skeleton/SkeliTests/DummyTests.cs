using NUnit.Framework;

namespace SkeliTests {
    class DummyTests {
        private Dummy dummy;
        private const int DummyHP = 10;
        private const int DummyXP = 10;
        private const int DMG = 10;
        
        [SetUp]
        public void Setup() {
            dummy = new Dummy(DummyHP, DummyXP);
        }


        [Test]
        public void DummyLosesHealth() {
            Axe axe = new Axe(5, 10);

            dummy.TakeAttack(axe.AttackPoints);

            Assert.AreEqual(dummy.Health, 5);
        }
        [Test]
        public void DeadDummyException() {

            dummy.TakeAttack(DMG);

            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(DMG));
        }
        [Test]
        public void DeadDummyGivesXP() {

            dummy.TakeAttack(DMG);

            Assert.AreEqual(dummy.GiveExperience(), 10);
        }

        [Test]
        public void AliveDummyCantGiveXP() {
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}
