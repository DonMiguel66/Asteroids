using System.Collections;
using UnityEngine;

namespace Asteroids
{
    internal sealed class Shell : PlayerShot, IShot
    {
        private readonly ViewServices _viewServices;
        public float ShotLifeTime;
        public float Damage;

        public float ShotForce;

        public Shell(float damage, float shotLifeTime, ViewServices viewServices)
        {
            ShotLifeTime = shotLifeTime;
            Damage = damage;
            _viewServices = viewServices;
        }

    }
}
