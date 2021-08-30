using UnityEngine;

namespace Asteroids
{
    internal sealed class AsteroidsFactory : IEnemyFactory
    {
        public Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<Asteroid>("Prefabs/Enemy/Asteroid"));
            enemy.DependencyInjectHealth(hp);
            return enemy;
        }
    }
}
