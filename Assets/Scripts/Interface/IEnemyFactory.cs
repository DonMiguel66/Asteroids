using UnityEngine;

namespace Asteroids
{
    internal interface IEnemyFactory
    {
        Enemy Create(Health hp, GameObject target);
    }
}
