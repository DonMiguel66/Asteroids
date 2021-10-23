using UnityEngine;

namespace Asteroid.State
{
    public sealed class PlayerMovementState
    {

        private State _state;

        public State State
        {
            set
            {
                _state = value;
                Debug.Log("State: " + _state.GetType().Name);
            }
        }


        public PlayerMovementState(State state)
        {
            State = state;
        }


        public void Request()
        {
            _state.Handle(this);
        }

    }
}
