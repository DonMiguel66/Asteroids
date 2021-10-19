using UnityEngine;

namespace Asteroids.DecoratorPattern
{
    internal interface IAmmunition
    {
        Rigidbody BulletInstance { get; }
        float TimeToDestroy { get; }
    }
}
