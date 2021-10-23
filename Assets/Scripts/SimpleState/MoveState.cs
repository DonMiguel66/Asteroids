

namespace Asteroid.State
{
    public sealed class MoveState : State
    {
        public override void Handle(PlayerMovementState characterMovement)
        {
            characterMovement.State = new FireState();
        }
    }
}
