using System;
using UnityEngine;

namespace Asteroids
{
    internal class ShipMovementTransform : IMove
    {
        private readonly Transform _transform;
        private Vector3 _move;

        public float Speed { get; protected set; }

        public ShipMovementTransform(Transform transform, float speed)
        {
            _transform = transform;
            Speed = speed;
        }

        public void Moving(float horizontal, float vertical, float deltaTime)
        {
            var speed = deltaTime * Speed;
            float verticalAxis = Input.GetAxis("Vertical");
            float horizontalAis = Input.GetAxis("Horizontal");
            _move = _transform.forward * verticalAxis + _transform.right * horizontalAis;
            _move *= speed;
            _transform.localPosition += _move;
            //_move.Set(horizontal * speed, vertical * speed, 0.0f);
        }

    }
}
