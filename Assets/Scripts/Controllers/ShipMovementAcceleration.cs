using System;
using UnityEngine;

namespace Asteroids
{
    internal sealed class ShipMovementAcceleration : ShipMovementTransform
    {
        private readonly float _acceleration;

        public ShipMovementAcceleration(Transform transform, float speed, float acceleration) : base(transform, speed)
        {
            _acceleration = acceleration;
        }

        public void AddAcceleration()
        {
            Speed += _acceleration;
        }

        public void RemoveAcceleration()
        {
            Speed -= _acceleration;
        }
    }
}
