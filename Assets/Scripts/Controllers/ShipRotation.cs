
using UnityEngine;

namespace Asteroids
{
    internal sealed class ShipRotation : IRotation
    {
        private readonly Transform _transform;
        private float _sensivity;
        private float _mouseX;
        private float _mouseY;
        public float _mouseYMinLimit = -20f;
        public float _mouseYMaxLimit = 80f;
        public ShipRotation(Transform transform, float sensivity)
        {
            _transform = transform;
            _sensivity = sensivity;
            Vector3 angles = transform.eulerAngles;
            _mouseX = angles.y;
            _mouseY = angles.x;
        }

        public void Rotation(Vector3 direction)
        {
            _mouseX = Input.GetAxis("Mouse X");
            _mouseY = Input.GetAxis("Mouse Y");
            _mouseY = OrbitCameraController.ClampAngle(_mouseY, _mouseYMinLimit, _mouseYMaxLimit);

            Quaternion rotation = Quaternion.Euler(_mouseY, _mouseX, 0);

            _transform.rotation = rotation;
            //Vector3 rotation = new Vector3(0, _mouseX, 0);
            //_transform.transform.Rotate(rotation * _sensivity);
            //var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            //_transform.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

    }
}
