using UnityEngine;

namespace Asteroids.DecoratorPattern
{
    internal interface IAim
    {
        Transform BarrelPositionAim { get; }
        GameObject AimInstance { get; }
    }
}
