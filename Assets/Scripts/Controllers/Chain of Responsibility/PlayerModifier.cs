using UnityEngine;

namespace Asteroids
{
    internal class PlayerModifier
    {
        protected PlayerController _player;
        protected PlayerModifier Next;

        public PlayerModifier(PlayerController player)
        {
            _player = player;
        }

        public void Add(PlayerModifier pm)
        {
            if (Next != null)
            {
                Next.Add(pm);
            }
            else
            {
                Next = pm;
            }
        }

        public virtual void Handle() => Next?.Handle();
    }
}
