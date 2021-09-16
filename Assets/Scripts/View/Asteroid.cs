using UnityEngine;

namespace Asteroids
{
    internal sealed class Asteroid : Enemy
    {
        private Rigidbody _rigidBody;
        [SerializeField] private float Speed;

        void Awake()
        {
            _rigidBody = GetComponent<Rigidbody>();
            _rigidBody.velocity = transform.forward * Speed;
            _rigidBody.transform.LookAt(_target.transform);
        }
    }
}