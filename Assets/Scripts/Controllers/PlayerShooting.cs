using UnityEngine;

namespace Asteroids
{
    internal class PlayerShooting : IShooting
    {
        private readonly GameObject _shellGO;
        private readonly GameObject _rocketGO;
        private readonly Transform _shootPoint;
        private ViewServices _viewServices;
        private Shell _shell;
        private Rocket _rocket;

        public PlayerShooting(GameObject shell, GameObject rocket, Transform shootPoint, ViewServices viewServices)
        {
            _shellGO = shell;
            _rocketGO = rocket;
            _shootPoint = shootPoint;
            _viewServices = viewServices;
        }

        public void ShellShooting()
        {
            var currentShot = _viewServices.Instantiate(_shellGO);
            currentShot.transform.position = _shootPoint.position;
            currentShot.transform.rotation = _shootPoint.rotation;
            var shotRigidbody = currentShot.GetComponent<Rigidbody>();
            _shell = _shellGO.GetComponent<Shell>();
            shotRigidbody.AddForce(_shootPoint.up * _shell.ShotForce);
        }

        public void RocketShooting()
        {
            var currentShot = _viewServices.Instantiate(_rocketGO);
            currentShot.transform.position = _shootPoint.position;
            currentShot.transform.rotation = _shootPoint.rotation;
            var shotRigidbody = currentShot.GetComponent<Rigidbody>();
            _rocket = _rocketGO.GetComponent<Rocket>();
            //shotRigidbody.transform.Translate(Vector3.forward * _rocket.MoveSpeed * Time.deltaTime);
        }
    }
}
