using UnityEngine;

namespace Asteroids.DecoratorPattern
{
    internal sealed class Weapon : IFire
    {
        private Transform _barrelPosition;
        private IAmmunition _bullet;
        private float _force;
        private AudioClip _audioClip;
        private readonly AudioSource _audioSource;

        private Transform _defaultBarrelPosition;
        private AudioClip _defaultAudioClip;
        private float _defaultForce;

        public Weapon(IAmmunition bullet, Transform barrelPosition, float force, AudioSource audioSource, AudioClip audioClip)
        {
            _bullet = bullet;
            _barrelPosition = barrelPosition;
            _defaultBarrelPosition = barrelPosition;
            _force = force;
            _defaultForce = force;
            _audioSource = audioSource;
            _audioClip = audioClip;
            _defaultAudioClip = audioClip;
        }

        public void SetBarrelPosition(Transform barrelPosition)
        {
            _barrelPosition = barrelPosition;
        }

        public void SetBullet(IAmmunition bullet)
        {
            _bullet = bullet;
        }

        public void SetForce(float force)
        {
            _force = force;
        }

        public void SetAudioClip(AudioClip audioClip)
        {
            _audioClip = audioClip;
        }

        public void SetDefaultBarrelPosition()
        {
            _barrelPosition = _defaultBarrelPosition;
        }

        public void SetDefaultAudioClip()
        {
            _audioClip = _defaultAudioClip;
        }
        public void Fire()
        {
            var bullet = Object.Instantiate(_bullet.BulletInstance, _barrelPosition.position, Quaternion.identity);
            bullet.AddForce(_barrelPosition.forward * _force);
            Object.Destroy(bullet.gameObject, _bullet.TimeToDestroy);
            _audioSource.PlayOneShot(_audioClip);
        }
    }
}
