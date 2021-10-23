using UnityEngine;


namespace Asteroids.SimpleState
{
    public sealed class CharacterMovementState
    {

        private State _state;

        public State State
        {
            set
            {
                _state = value;
                Debug.Log("Состояние: " + _state.GetType().Name);
            }
        }

        public CharacterMovementState(State state)
        {
            State = state;
        }


        public void Request()
        {
            _state.Handle(this);
        }

    }
}
