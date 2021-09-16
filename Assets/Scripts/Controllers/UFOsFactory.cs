using UnityEngine;

namespace Asteroids
{
    internal sealed class UFOsFactory : IEnemyFactory
    {
        public Enemy Create(Health hp, GameObject target)
        {
            var enemy = Object.Instantiate(Resources.Load<UFO>("Prefabs/Enemy/UFO"));
            enemy.DependencyInjectHealth(hp);
            enemy.SetTarget(target);
            return enemy;
        }
    }
}
