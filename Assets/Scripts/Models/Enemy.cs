using UnityEngine;
using System;

namespace Asteroids
{
    internal abstract class Enemy : MonoBehaviour, IHit
    {
        public static IEnemyFactory Factory;
        public Health Health { get; private set; }
        [SerializeField]
        public GameObject _target;

        public event Action<float> OnHitChange = delegate (float f) { };
        public static Asteroid CreateAsteroidEnemy (Health hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Prefabs/Enemy/Asteroid"));
            enemy.Health = hp;
            return enemy;
        }

        public static UFO CreateUFOEnemy(Health hp)
        {
            var enemy = Instantiate(Resources.Load<UFO>("Prefabs/Enemy/UFO"));
            enemy.Health = hp;
            return enemy;
        }

        public void SetTarget(GameObject target)
        {
            _target = target; 
        }

        public void DependencyInjectHealth(Health hp)
        {
            Health = hp;
        }

        public void Hit (float damage)
        {
            OnHitChange.Invoke(damage);
        }
    }
}
