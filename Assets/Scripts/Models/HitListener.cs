using UnityEngine;

namespace Asteroids
{
    public class HitListener
    {
        private MessageBroker.MessageBroker _messageBroker;

        public HitListener(MessageBroker.MessageBroker messageBroker)
        {
            _messageBroker = messageBroker;
        }

        public void Add(IHit value)
        {
            value.OnHitChange += ActionOnHit;
        }

        public void Remove(IHit value)
        {
            value.OnHitChange -= ActionOnHit;
        }

        private void ActionOnHit(float damage)
        {
            _messageBroker.ProduceMessage($"Was damaged on {damage}");
        }
    }
}
