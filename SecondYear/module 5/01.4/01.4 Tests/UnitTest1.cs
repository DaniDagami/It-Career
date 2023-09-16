using Skeleton;
using Skeleton.Interfaces;

namespace _01._4_Tests {
    public class Tests {
        private const string HeroName = "Joey Jordison";

        [SetUp]
        public void Setup() {
        }

        [Test]
        public void HeroGainsXPAfterAttacksIfTargetDies() {
            ITarget fakeTarget = new FakeTarget();
            IWeapon fakeWeapon = new FakeWeapon();

            Hero hero = new Hero(HeroName, fakeWeapon);
            hero.Attack(fakeTarget);

            Assert.AreEqual(20, hero.Experience, "Fake ASF");
        }

    }
}