using System;
namespace Asteroids
{
    public interface IDamagable
    {
        float MaxHP { get; }
        float CurrentHP { get; }

        void ChangeCurrentHealth(float hpChangeValue);
    }
}
