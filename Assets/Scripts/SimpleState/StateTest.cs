using UnityEngine;


namespace Asteroid.State
{
    public sealed class StateTest : MonoBehaviour
    {
        private void Start()
        {
            PlayerMovementState playerMovementState = new PlayerMovementState(new MoveState());
            playerMovementState.Request();
            playerMovementState.Request();
            playerMovementState.Request();
            playerMovementState.Request();
        }
    }
}
