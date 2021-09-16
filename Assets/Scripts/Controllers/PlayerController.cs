using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;
        [SerializeField] private Transform _shootPoint;
        private Reference _reference;
        private ViewServices _viewServices;
        private Camera _camera;
        private Ship _ship;

        private void Start()
        {
            _reference = new Reference();
            _camera = Camera.main;
            _viewServices = new ViewServices(); 
            var moveTransform = new ShipMovementAcceleration(transform, _speed, _acceleration); 
            var rotation = new ShipRotation(transform);
            var shooting = new PlayerShooting(_reference.Shell,_reference.Rocket, _shootPoint, _viewServices);
            var shipHP = new Health(_hp, _hp);
            _ship = new Ship(moveTransform, rotation, shooting, shipHP, shipHP);
        }

        private void Update()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);
            _ship.Moving(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

            if (Input.GetButtonDown("Fire1"))
            {
                _ship.ShellShooting();
            }
            if (Input.GetButtonDown("Fire2"))
            {
                _ship.RocketShooting();
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
            if (other.gameObject.GetComponent<Asteroid>() != null) 
            {
                if (_hp <= 0)
                {
                    Destroy(gameObject);
                }
                else
                {
                    _ship.ChangeCurrentHealth(1);
                }
            }
            
        }
    }

}