using UnityEngine;

namespace Asteroids.DecoratorPattern
{
    internal sealed class Example : MonoBehaviour
    {
        private IFire _fire;
        [Header("Start Gun")]
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private Transform _barrelPosition;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private AudioClip _audioClip;

        [Header("Muffler Gun")]
        [SerializeField] private AudioClip _audioClipMuffler;
        [SerializeField] private float _volumeFireOnMuffler;
        [SerializeField] private Transform _barrelPositionMuffler;
        [SerializeField] private GameObject _muffler;

        [Header("Aim on Gun")]
        [SerializeField] private Transform _aimPosition;
        [SerializeField] private GameObject _aim;

        private void Start()
        {
            IAmmunition ammunition = new Bullet(_bullet, 3.0f);
            var weapon = new Weapon(ammunition, _barrelPosition, 999.0f, _audioSource, _audioClip);

            var muffler = new Muffler(_audioClipMuffler, _volumeFireOnMuffler, _barrelPosition, _muffler);
            ModificationWeapon muffleMOdification = new ModificationMuffler(_audioSource, muffler, _barrelPositionMuffler.position);
            muffleMOdification.ApplyModification(weapon);

            var aim = new Aim(_aimPosition, _aim);
            ModificationWeapon aimModification = new ModificationAim(aim, _aimPosition.position);

            _fire = muffleMOdification;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _fire.Fire();
            }
        }
    }
}
