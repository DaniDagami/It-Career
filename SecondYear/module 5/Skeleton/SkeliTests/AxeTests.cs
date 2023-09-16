using NUnit.Framework;

namespace SkeliTests {
    class AxeTests {
        private Dummy dummy;
        private const int DummyHP = 10;
        private const int DummyXP = 10;

        [SetUp] 
        public void SetUp() {
            dummy = new Dummy(DummyHP, DummyXP);
        }


        [Test]
        public void AxeLoseDurabilyAfterAttack() {
            Axe axe = new Axe(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints, "Axe durability doesnt change after attack");
        }

        [Test]
        public void BrokenAxeCantAttack() {
            Axe axe = new Axe(2, 2);

            axe.Attack(dummy);
            axe.Attack(dummy);

            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
        }
    }
}
