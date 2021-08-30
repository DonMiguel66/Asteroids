using UnityEngine;

namespace Asteroids
{
    public sealed class Ship: IMove, IRotation, IShooting, IDamagable
    {
        private readonly IMove _moveExecution;
        private readonly IRotation _rotationExecution;
        private readonly IShooting _shootingExecution;
        private readonly IDamagable _hpMax;
        private readonly IDamagable _hpExecution;
        public float Speed => _moveExecution.Speed;
        
        public float ShotSpeed => _shootingExecution.ShotSpeed; 

        public float ShotLifeTime => _shootingExecution.ShotLifeTime;

        public float ShotForce => _shootingExecution.ShotForce;

        public float MaxHP => _hpMax.MaxHP;
        public float CurrentHP => _hpExecution.CurrentHP;

        public Ship(IMove moveImplementation, IRotation rotationImplementation, IShooting shootingExecution, IDamagable hpMax, IDamagable hpExecution)
        {
            _moveExecution = moveImplementation;
            _rotationExecution = rotationImplementation;
            _shootingExecution = shootingExecution;
            _hpMax = hpMax;
            _hpExecution = hpExecution;
        }

        public void Moving(float horizontal, float vertical, float deltaTime)
        {
            _moveExecution.Moving(horizontal, vertical, deltaTime);
        }
        public void Rotation(Vector3 direction)
        {
            _rotationExecution.Rotation(direction);
        }

        public void AddAcceleration()
        {
            if (_moveExecution is ShipMovementAcceleration accelerationMove)
            {
                accelerationMove.AddAcceleration();
            }
        }

        public void RemoveAcceleration()
        {
            if (_moveExecution is ShipMovementAcceleration accelerationMove)
            {
                accelerationMove.RemoveAcceleration();
            }
        }

        public void Shooting(GameObject shot, Transform shootPoint)
        {
            _shootingExecution.Shooting(shot, shootPoint);
        }

        public void ChangeCurrentHealth(float hpChangeValue)
        {
            _hpExecution.ChangeCurrentHealth(hpChangeValue);
        }
    }
}
