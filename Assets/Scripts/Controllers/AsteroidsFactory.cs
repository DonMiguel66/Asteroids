using UnityEngine;

namespace Asteroids
{
    internal sealed class AsteroidsFactory : IEnemyFactory
    {
        public Enemy Create(Health hp, GameObject target)
        {
            var enemy = Object.Instantiate(Resources.Load<Asteroid>("Prefabs/Enemy/Asteroid"));
            enemy.DependencyInjectHealth(hp);
            enemy.SetTarget(target);
            return enemy;
        }
    }
}
