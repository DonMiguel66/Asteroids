using UnityEngine;

namespace Asteroids
{
    internal sealed class UFO : Enemy
    {
        private Rigidbody _rigidBody;
        [SerializeField] private float Speed;

        void Awake()
        {
            _rigidBody = GetComponent<Rigidbody>();
            _rigidBody.transform.LookAt(_target.transform);
            _rigidBody.velocity = transform.forward * Speed;
        }
    }
}
