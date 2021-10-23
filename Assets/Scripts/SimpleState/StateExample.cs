using UnityEngine;


namespace Asteroids.SimpleState
{
    public sealed class StateExample : MonoBehaviour
    {
        private void Start()
        {
            CharacterMovementState characterMovementState = new CharacterMovementState(new MoveState());
            characterMovementState.Request();
            characterMovementState.Request();
            characterMovementState.Request();
            characterMovementState.Request();
        }
    }
}
