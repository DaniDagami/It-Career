using Moq;
using Skeleton.Interfaces;

namespace _01._5_Tests {
    public class Tests {
        private const string HERO_NAME = "Joey Jordison";

        private Mock<ITarget> _fakeTarget;
        private Mock<IWeapon> _fakeWeapon;
        private Hero? _hero;

        [SetUp]
        public void Setup() {
            _fakeTarget = new Mock<ITarget>();
            _fakeWeapon = new Mock<IWeapon>();
        }

        [Test]
        public void Test1() {
            Assert.Pass();
        }

        public void HeroGainsXPAfterAttackIfTargetDies() {
            
            _fakeTarget.Setup(e => e.Health).Returns(0);
            _fakeTarget.Setup(e => e.GiveExperience()).Returns(20);
            _fakeTarget.Setup(e => e.IsDead()).Returns(true);

            _hero = new Hero(HERO_NAME, _fakeWeapon.Object);
            _hero.Attack(_fakeTarget.Object);
            Assert.AreEqual(20, _hero.Experience);
        }
    }
}