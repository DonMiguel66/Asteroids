using UnityEngine;

namespace Asteroids
{
    public interface IShot
    {
        float Damage { get; }
        float ShotLifeTime { get; }
    }
}
