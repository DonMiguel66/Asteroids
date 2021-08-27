using UnityEngine;

namespace Asteroids
{
    internal class PlayerShooting : IShooting
    {
        private GameObject _shot;
        private Transform _shootPoint;

        public float ShotForce { get; protected set; }
        public float ShotSpeed { get; protected set; }

        public float ShotLifeTime { get; protected set; }


        public PlayerShooting(GameObject shot, Transform shootPoint, float force)
        {
            _shot = shot;
            _shootPoint = shootPoint;
            ShotForce = force;
        }

        public void Shooting(GameObject shot, Transform shootPoint)
        {
            var currentShot = Object.Instantiate(_shot, _shootPoint.position, _shootPoint.rotation);
            var shotRigidbody = currentShot.GetComponent<Rigidbody>();
            shotRigidbody.AddForce(_shootPoint.up * ShotForce);
        }
    }
}
