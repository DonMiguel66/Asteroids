﻿using UnityEngine;

namespace Asteroids
{
    internal abstract class Enemy : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        public Health Health { get; private set; }

        public static Asteroid CreateAsteroidEnemy (Health hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Prefabs/Enemy/Asteroid"));
            enemy.Health = hp;
            return enemy;
        }

        public void DependencyInjectHealth(Health hp)
        {
            Health = hp;
        }
    }
}