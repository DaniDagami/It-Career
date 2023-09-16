namespace Skeleton.Interfaces {
    public interface IWeapon {
        public void Attack(ITarget target);
        public int AttackPoints => AttackPoints;
        public int DurabilityPoints => DurabilityPoints;
    }
}
