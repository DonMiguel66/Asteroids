using System;

namespace Asteroids
{
    internal sealed class Shot : IShot
    {
        public float ShotLifeTime => 5;
        public float Damage => 10;

    }
}
