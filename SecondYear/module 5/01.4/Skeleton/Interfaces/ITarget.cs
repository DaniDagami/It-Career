namespace Skeleton.Interfaces {
    public interface ITarget {
        public void TakeAttack(int attackPoints);
        public int Health => Health;
        public int GiveExperience();
        public bool IsDead();
    }
}
