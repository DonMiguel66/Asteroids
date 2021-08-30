using UnityEngine;

namespace Asteroids
{
    internal sealed class UFOsFactory : IEnemyFactory
    {
        public Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<UFO>("Prefabs/Enemy/UFO"));
            enemy.DependencyInjectHealth(hp);
            return enemy;
        }
    }
}
