using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;
        [SerializeField] private GameObject _shot;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private float _force;
        private Reference _reference;
        private Camera _camera;
        private Ship _ship;

        private void Start()
        {
            _reference = new Reference();
            _camera = Camera.main;
            var moveTransform = new ShipMovementAcceleration(transform, _speed, _acceleration); 
            var rotation = new ShipRotation(transform);
            var shooting = new PlayerShooting(_reference.Shot, _shootPoint, _force);
            var shipHP = new ShipHealth(_hp);
            _ship = new Ship(moveTransform, rotation, shooting, shipHP);
        }

        private void Update()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);
            _ship.Moving(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

            if (Input.GetButtonDown("Fire1"))
            {
                _ship.Shooting(_reference.Shot, _shootPoint);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }

        }

        private void OnCollisionEnter(Collision other)
        {
            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                _ship.ChangeHP(1);
            }
        }
    }

}