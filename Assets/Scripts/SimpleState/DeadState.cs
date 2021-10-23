

namespace Asteroids.SimpleState
{
    public sealed class DeadState : State
    {
        public override void Handle(CharacterMovementState characterMovementType)
        {
            characterMovementType.State = new MoveState();
        }
    }
}
