using System;
namespace Asteroids
{
    public interface IDamagable
    {
        float HealtPoint{get; }

        void ChangeHP(float hpChangeValue);
    }
}
