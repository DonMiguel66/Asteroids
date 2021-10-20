using System;

namespace Asteroids
{
    internal class HealthModifier : PlayerModifier
    {
        private int _hp;

        public HealthModifier(PlayerController player, int hp) : base(player)
        {
            _hp = hp;
        }

        public override void Handle()
        {
            _player.HP += _hp;
            base.Handle();
        }
    }
}