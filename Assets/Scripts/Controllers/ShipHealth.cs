namespace Asteroids
{
    public sealed class ShipHealth : IDamagable
    {
        public float HealtPoint { get; protected set; }

        public ShipHealth(float hp)
        {
            HealtPoint = hp;
        }

        public void ChangeHP(float hpChangeValue)
        {
            HealtPoint += hpChangeValue;
        }
    }
}
