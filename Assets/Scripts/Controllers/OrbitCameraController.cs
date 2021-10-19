using UnityEngine;
using System.Collections;

namespace Asteroids 
{
    [AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
    public class OrbitCameraController : MonoBehaviour
    {

        private Transform _target;
        public float _distance = 5.0f;
        public float _xSpeed = 120.0f;
        public float _ySpeed = 120.0f;

        public float _yMinLimit = -20f;
        public float _yMaxLimit = 80f;

        public float _distanceMin = .5f;
        public float _distanceMax = 15f;

        private Rigidbody _rigidbody;

        float _x = 0.0f;
        float _y = 0.0f;

        // Use this for initialization
        void Start()
        {
            _target = GameObject.Find("Ship").transform;
            Vector3 angles = transform.eulerAngles;
            _x = angles.y;
            _y = angles.x;

            _rigidbody = GetComponent<Rigidbody>();

            if (_rigidbody != null)
            {
                _rigidbody.freezeRotation = true;
            }
        }

        void LateUpdate()
        {
            if (_target)
            {
                _x += Input.GetAxis("Mouse X") * _xSpeed * _distance * 0.02f;
                _y -= Input.GetAxis("Mouse Y") * _ySpeed * 0.02f;

                _y = ClampAngle(_y, _yMinLimit, _yMaxLimit);

                Quaternion rotation = Quaternion.Euler(_y, _x, 0);

                _distance = Mathf.Clamp(_distance - Input.GetAxis("Mouse ScrollWheel") * 5, _distanceMin, _distanceMax);

                RaycastHit hit;
                if (Physics.Linecast(_target.position, transform.position, out hit))
                {
                    _distance -= hit.distance;
                }
                Vector3 negDistance = new Vector3(0.0f, 0.0f, -_distance);
                Vector3 position = rotation * negDistance + _target.position;

                transform.rotation = rotation;
                transform.position = position;
            }
        }

        public static float ClampAngle(float angle, float min, float max)
        {
            if (angle < -360F)
                angle += 360F;
            if (angle > 360F)
                angle -= 360F;
            return Mathf.Clamp(angle, min, max);
        }
    }
}

