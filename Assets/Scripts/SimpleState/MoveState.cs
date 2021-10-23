

namespace Asteroids.SimpleState
{
    public sealed class MoveState : State
    {
        public override void Handle(CharacterMovementState characterMovement)
        {
            characterMovement.State = new FireState();
        }
    }
}
