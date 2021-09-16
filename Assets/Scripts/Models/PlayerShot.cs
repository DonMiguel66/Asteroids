using UnityEngine;

namespace Asteroids
{
    internal class PlayerShot : MonoBehaviour, IShot
    {
        public float Damage {get; private set;}

        public float ShotLifeTime { get; private set; }
    }
}
