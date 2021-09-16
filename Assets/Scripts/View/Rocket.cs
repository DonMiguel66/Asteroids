using System;
using UnityEngine;

namespace Asteroids
{
    internal sealed class Rocket : PlayerShot, IShot
    {
        public float Damage => 20;

        public float ShotLifeTime => 10;
        public float MoveSpeed = 30;

    }
}
